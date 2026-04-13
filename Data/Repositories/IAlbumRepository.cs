using AlbumRoulette.Models;

namespace AlbumRoulette.Data.Repositories;

/// <summary>
/// Interface for CRUD operations on Album entities.
/// Follows the Repository pattern to abstract data access logic.
/// </summary>
public interface IAlbumRepository
{
    /// <summary>Gets an album by its unique identifier.</summary>
    Task<Album?> GetByIdAsync(int id);

    /// <summary>Gets an album by its rank number.</summary>
    Task<Album?> GetByRankAsync(int rank);

    /// <summary>Gets all albums.</summary>
    Task<List<Album>> GetAllAsync();

    /// <summary>Gets albums from a specific decade.</summary>
    Task<List<Album>> GetByDecadeAsync(int decade);

    /// <summary>Gets a random album.</summary>
    Task<Album?> GetRandomAsync();

    /// <summary>Gets a random album excluding specified ranks.</summary>
    Task<Album?> GetRandomAsync(IEnumerable<int> excludeRanks);

    /// <summary>Adds a new album.</summary>
    Task AddAsync(Album album);

    /// <summary>Updates an existing album.</summary>
    Task UpdateAsync(Album album);

    /// <summary>Deletes an album.</summary>
    Task DeleteAsync(int id);

    /// <summary>Gets all distinct decades from the albums.</summary>
    Task<List<int>> GetDecadesAsync();

    /// <summary>Checks if an album exists by rank.</summary>
    Task<bool> ExistsByRankAsync(int rank);

    /// <summary>Gets the total count of albums.</summary>
    Task<int> CountAsync();

    /// <summary>Searches albums by title or artist.</summary>
    Task<List<Album>> SearchAsync(string query);
}
