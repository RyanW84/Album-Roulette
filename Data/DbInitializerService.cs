using AlbumRoulette.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumRoulette.Data;

/// <summary>
/// Service for initializing and seeding the database with initial album data.
/// Follows the Single Responsibility Principle by handling only database initialization.
/// </summary>
public class DbInitializerService(
    AlbumRouletteDbContext context,
    ILogger<DbInitializerService> logger
)
{
    private readonly AlbumRouletteDbContext _context =
        context ?? throw new ArgumentNullException(nameof(context));
    private readonly ILogger<DbInitializerService> _logger =
        logger ?? throw new ArgumentNullException(nameof(logger));

    /// <summary>
    /// Initializes the database: creates tables and seeds initial data if empty.
    /// </summary>
    public async Task InitializeAsync()
    {
        try
        {
            // Create database and apply migrations
            await _context.Database.EnsureCreatedAsync();
            _logger.LogInformation("Database initialized");

            // Seed data if database is empty
            if (!_context.Albums.Any())
            {
                _logger.LogInformation("Seeding database with initial album data");
                await SeedAlbumsAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error initializing database");
            throw;
        }
    }

    /// <summary>
    /// Seeds the database with albums, implementing deduplication logic to prevent duplicate insertions.
    /// Uses the Rank field as a unique identifier to check for existing albums.
    /// </summary>
    private async Task SeedAlbumsAsync()
    {
        int addedCount = 0;

        foreach (var (rank, title, artist, label, year) in AlbumSeedData.Albums)
        {
            // Check if album with this rank already exists (deduplication)
            if (await _context.Albums.AnyAsync(a => a.Rank == rank))
            {
                _logger.LogDebug("Album rank {Rank} already exists, skipping", rank);
                continue;
            }

            // Create new album and add to context
            var album = new Album
            {
                Rank = rank,
                AlbumTitle = title,
                Artist = artist,
                Label = label,
                Year = year,
                IsEnriched = false,
                LastEnrichedAt = DateTime.MinValue,
            };

            await _context.Albums.AddAsync(album);
            addedCount++;

            // Save in batches of 50 to avoid excessive memory usage
            if (addedCount % 50 == 0)
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Batch saved: {Count} albums inserted so far", addedCount);
            }
        }

        // Save remaining albums
        if (addedCount % 50 != 0)
        {
            await _context.SaveChangesAsync();
        }

        _logger.LogInformation(
            "Database seeding complete: {Count} new albums inserted",
            addedCount
        );
    }
}
