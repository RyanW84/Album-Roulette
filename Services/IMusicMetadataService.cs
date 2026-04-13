using AlbumRoulette.Models;

namespace AlbumRoulette.Services;

/// <summary>
/// Interface for external music metadata service.
/// Abstracts the implementation details following the Dependency Inversion principle.
/// </summary>
public interface IMusicMetadataService
{
    /// <summary>
    /// Enriches an album with metadata from external services (MusicBrainz, Cover Art Archive).
    /// </summary>
    /// <param name="album">The album to enrich</param>
    /// <returns>Task with no return value; album is updated in-place</returns>
    Task EnrichAlbumAsync(Album album);

    /// <summary>
    /// Checks if album enrichment has been cached.
    /// </summary>
    Task<bool> IsEnrichedAsync(Album album);
}
