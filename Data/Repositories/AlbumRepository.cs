using AlbumRoulette.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumRoulette.Data.Repositories;

/// <summary>
/// Implementation of the IAlbumRepository interface for SQLite database operations.
/// Handles all data access logic for Album entities.
/// </summary>
public class AlbumRepository(AlbumRouletteDbContext context, ILogger<AlbumRepository> logger)
    : IAlbumRepository
{
    private readonly AlbumRouletteDbContext _context =
        context ?? throw new ArgumentNullException(nameof(context));
    private readonly ILogger<AlbumRepository> _logger =
        logger ?? throw new ArgumentNullException(nameof(logger));

    public async Task<Album?> GetByIdAsync(int id)
    {
        try
        {
            return await _context.Albums.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving album by id {Id}", id);
            return null;
        }
    }

    public async Task<Album?> GetByRankAsync(int rank)
    {
        try
        {
            return await _context.Albums.AsNoTracking().FirstOrDefaultAsync(a => a.Rank == rank);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving album by rank {Rank}", rank);
            return null;
        }
    }

    public async Task<List<Album>> GetAllAsync()
    {
        try
        {
            return await _context.Albums.AsNoTracking().OrderBy(a => a.Rank).ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving all albums");
            return [];
        }
    }

    public async Task<List<Album>> GetByDecadeAsync(int decade)
    {
        try
        {
            var decadeStart = decade;
            var decadeEnd = decade + 9;
            return await _context
                .Albums.AsNoTracking()
                .Where(a => a.Year >= decadeStart && a.Year <= decadeEnd)
                .OrderBy(a => a.Rank)
                .ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving albums from decade {Decade}", decade);
            return [];
        }
    }

    public async Task<Album?> GetRandomAsync()
    {
        try
        {
            var count = await _context.Albums.CountAsync();
            if (count == 0)
                return null;

            var randomIndex = Random.Shared.Next(count);
            return await _context.Albums.AsNoTracking().Skip(randomIndex).FirstOrDefaultAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving random album");
            return null;
        }
    }

    public async Task<Album?> GetRandomAsync(IEnumerable<int> excludeRanks)
    {
        try
        {
            var excludeSet = excludeRanks.ToHashSet();
            var availableAlbums = await _context
                .Albums.AsNoTracking()
                .Where(a => !excludeSet.Contains(a.Rank))
                .ToListAsync();

            if (availableAlbums.Count == 0)
                return null;

            var randomIndex = Random.Shared.Next(availableAlbums.Count);
            return availableAlbums[randomIndex];
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Error retrieving random album excluding {Count} ranks",
                excludeRanks.Count()
            );
            return null;
        }
    }

    public async Task AddAsync(Album album)
    {
        try
        {
            if (album == null)
                throw new ArgumentNullException(nameof(album));

            await _context.Albums.AddAsync(album);
            await _context.SaveChangesAsync();
            _logger.LogInformation(
                "Album {Title} added with rank {Rank}",
                album.AlbumTitle,
                album.Rank
            );
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error adding album {Title}", album?.AlbumTitle);
            throw;
        }
    }

    public async Task UpdateAsync(Album album)
    {
        try
        {
            if (album == null)
                throw new ArgumentNullException(nameof(album));

            _context.Albums.Update(album);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Album {Title} updated", album.AlbumTitle);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error updating album {Title}", album?.AlbumTitle);
            throw;
        }
    }

    public async Task DeleteAsync(int id)
    {
        try
        {
            var album = await _context.Albums.FindAsync(id);
            if (album == null)
                return;

            _context.Albums.Remove(album);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Album {Title} deleted", album.AlbumTitle);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error deleting album with id {Id}", id);
            throw;
        }
    }

    public async Task<List<int>> GetDecadesAsync()
    {
        try
        {
            return await _context
                .Albums.AsNoTracking()
                .Select(a => a.Year / 10 * 10)
                .Distinct()
                .OrderBy(d => d)
                .ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving decades");
            return [];
        }
    }

    public async Task<bool> ExistsByRankAsync(int rank)
    {
        try
        {
            return await _context.Albums.AnyAsync(a => a.Rank == rank);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error checking if album exists with rank {Rank}", rank);
            return false;
        }
    }

    public async Task<int> CountAsync()
    {
        try
        {
            return await _context.Albums.CountAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error counting albums");
            return 0;
        }
    }

    public async Task<List<Album>> SearchAsync(string query)
    {
        try
        {
            var lowerQuery = query.ToLower();
            return await _context
                .Albums.AsNoTracking()
                .Where(a =>
                    a.AlbumTitle.ToLower().Contains(lowerQuery)
                    || a.Artist.ToLower().Contains(lowerQuery)
                )
                .OrderBy(a => a.Rank)
                .ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error searching albums with query {Query}", query);
            return [];
        }
    }
}
