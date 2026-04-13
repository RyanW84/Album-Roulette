using AlbumRoulette.Data.Repositories;
using AlbumRoulette.Models;

namespace AlbumRoulette.Services;

/// <summary>
/// Service for album data operations.
/// Follows the Single Responsibility Principle by delegating data access to the repository.
/// Provides a business logic layer between controllers and the data access layer.
/// </summary>
public class AlbumService(IAlbumRepository repository, IMusicMetadataService metadataService, ILogger<AlbumService> logger)
{
    private readonly IAlbumRepository _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    private readonly IMusicMetadataService _metadataService = metadataService ?? throw new ArgumentNullException(nameof(metadataService));
    private readonly ILogger<AlbumService> _logger = logger ?? throw new ArgumentNullException(nameof(logger));

    /// <summary>
    /// Gets a random album, optionally excluding specified album ranks.
    /// </summary>
    public async Task<Album?> GetRandomAlbumAsync(IEnumerable<int>? excludeRanks = null)
    {
        try
        {
            Album? album;

            if (excludeRanks?.Any() ?? false)
            {
                album = await _repository.GetRandomAsync(excludeRanks);
                if (album == null)
                {
                    _logger.LogWarning("No albums available; {Count} were excluded", excludeRanks.Count());
                    return null;
                }
            }
            else
            {
                album = await _repository.GetRandomAsync();
            }

            if (album != null)
            {
                // Enrich the album with metadata if not already done
                await _metadataService.EnrichAlbumAsync(album);
            }

            return album;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting random album");
            return null;
        }
    }

    /// <summary>
    /// Gets all albums.
    /// </summary>
    public async Task<List<Album>> GetAllAlbumsAsync()
    {
        try
        {
            return await _repository.GetAllAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting all albums");
            return [];
        }
    }

    /// <summary>
    /// Gets an album by its rank.
    /// </summary>
    public async Task<Album?> GetAlbumByRankAsync(int rank)
    {
        try
        {
            var album = await _repository.GetByRankAsync(rank);
            if (album != null)
            {
                // Enrich with metadata if needed
                await _metadataService.EnrichAlbumAsync(album);
            }
            return album;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting album by rank {Rank}", rank);
            return null;
        }
    }

    /// <summary>
    /// Gets albums from a specific decade.
    /// </summary>
    public async Task<List<Album>> GetAlbumsByDecadeAsync(int decade)
    {
        try
        {
            return await _repository.GetByDecadeAsync(decade);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting albums from decade {Decade}", decade);
            return [];
        }
    }

    /// <summary>
    /// Gets all distinct decades.
    /// </summary>
    public async Task<List<int>> GetDecadesAsync()
    {
        try
        {
            return await _repository.GetDecadesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting decades");
            return [];
        }
    }

    /// <summary>
    /// Gets the total count of albums.
    /// </summary>
    public async Task<int> GetAlbumCountAsync()
    {
        try
        {
            return await _repository.CountAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting album count");
            return 0;
        }
    }

    /// <summary>
    /// Searches albums by query string.
    /// </summary>
    public async Task<List<Album>> SearchAlbumsAsync(string query)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(query))
                return await _repository.GetAllAsync();

            return await _repository.SearchAsync(query);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error searching albums with query {Query}", query);
            return [];
        }
    }
}
