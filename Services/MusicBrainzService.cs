using System.Text.Json;
using AlbumRoulette.Data.Repositories;
using AlbumRoulette.Models;

namespace AlbumRoulette.Services;

/// <summary>
/// Service for enriching albums with metadata from MusicBrainz and Cover Art Archive.
/// Implements IMusicMetadataService for dependency injection compatibility.
/// Includes caching of enriched data in the database.
/// </summary>
public class MusicBrainzService : IMusicMetadataService
{
    private readonly HttpClient _http;
    private readonly IAlbumRepository _repository;
    private readonly ILogger<MusicBrainzService> _logger;
    private const int EnrichmentCacheDays = 30; // Refresh enrichment every 30 days

    public MusicBrainzService(
        HttpClient http,
        IAlbumRepository repository,
        ILogger<MusicBrainzService> logger
    )
    {
        _http = http ?? throw new ArgumentNullException(nameof(http));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _http.DefaultRequestHeaders.UserAgent.ParseAdd("AlbumRoulette/1.0 (learning-project)");
    }

    /// <summary>
    /// Enriches an album with metadata, checking cache first before calling external APIs.
    /// </summary>
    public async Task EnrichAlbumAsync(Album album)
    {
        if (album == null)
            throw new ArgumentNullException(nameof(album));

        // Check if we have recent enrichment data in cache
        if (IsEnrichedInCache(album))
        {
            _logger.LogDebug("Album {Title} already enriched and cached", album.AlbumTitle);
            return;
        }

        try
        {
            _logger.LogInformation(
                "Enriching album {Title} from external sources",
                album.AlbumTitle
            );

            // Search MusicBrainz for the release
            var mbid = await GetMusicBrainzIdAsync(album);
            if (mbid != null)
            {
                album.MusicBrainzId = mbid;

                // Get cover art from Cover Art Archive
                album.CoverArtUrl = await GetCoverArtAsync(mbid);
            }

            // Mark as enriched
            album.IsEnriched = true;
            album.LastEnrichedAt = DateTime.UtcNow;

            // Cache the enriched data in database
            await _repository.UpdateAsync(album);
            _logger.LogInformation("Album {Title} enriched and cached", album.AlbumTitle);
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Failed to enrich album {Album}", album.AlbumTitle);
            // Don't throw - let the application continue with partial data
        }
    }

    /// <summary>
    /// Checks if an album has been recently enriched.
    /// </summary>
    public async Task<bool> IsEnrichedAsync(Album album)
    {
        if (album == null)
            return false;

        // If album has no ID yet, it's not enriched
        if (album.Id == 0)
            return false;

        var storedAlbum = await _repository.GetByIdAsync(album.Id);
        return storedAlbum?.IsEnriched ?? false && IsEnrichedInCache(storedAlbum!);
    }

    /// <summary>
    /// Checks if enrichment cache is still valid (not expired).
    /// </summary>
    private static bool IsEnrichedInCache(Album album)
    {
        if (!album.IsEnriched)
            return false;

        var cacheAge = DateTime.UtcNow - album.LastEnrichedAt;
        return cacheAge.TotalDays < EnrichmentCacheDays;
    }

    /// <summary>
    /// Gets the MusicBrainz ID for an album using the MusicBrainz API.
    /// </summary>
    private async Task<string?> GetMusicBrainzIdAsync(Album album)
    {
        try
        {
            var query = Uri.EscapeDataString(
                $"release:\"{album.AlbumTitle}\" AND artist:\"{album.Artist}\""
            );
            var url = $"https://musicbrainz.org/ws/2/release/?query={query}&fmt=json&limit=3";

            var response = await _http.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                _logger.LogWarning(
                    "MusicBrainz API returned {StatusCode} for {Album}",
                    response.StatusCode,
                    album.AlbumTitle
                );
                return null;
            }

            var json = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(json);

            var releases = doc.RootElement.GetProperty("releases");
            if (releases.GetArrayLength() == 0)
            {
                _logger.LogDebug("No MusicBrainz releases found for {Album}", album.AlbumTitle);
                return null;
            }

            // Pick the first release
            foreach (var release in releases.EnumerateArray())
            {
                var mbid = release.GetProperty("id").GetString();
                if (mbid != null)
                {
                    _logger.LogDebug(
                        "Found MusicBrainz ID {Id} for {Album}",
                        mbid,
                        album.AlbumTitle
                    );
                    return mbid;
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error querying MusicBrainz for {Album}", album.AlbumTitle);
            return null;
        }
    }

    /// <summary>
    /// Gets cover art URL from Cover Art Archive using a MusicBrainz ID.
    /// </summary>
    private async Task<string?> GetCoverArtAsync(string mbid)
    {
        try
        {
            if (string.IsNullOrEmpty(mbid))
                return null;

            // Be nice to the API - add delay
            await Task.Delay(300);

            var url = $"https://coverartarchive.org/release/{mbid}";
            var response = await _http.GetAsync(url);
            if (!response.IsSuccessStatusCode)
            {
                _logger.LogDebug(
                    "Cover Art Archive returned {StatusCode} for {Id}",
                    response.StatusCode,
                    mbid
                );
                return null;
            }

            var json = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(json);

            var images = doc.RootElement.GetProperty("images");
            foreach (var image in images.EnumerateArray())
            {
                if (image.TryGetProperty("front", out var front) && front.GetBoolean())
                {
                    // Prefer 500px thumbnail
                    if (image.TryGetProperty("thumbnails", out var thumbs))
                    {
                        if (thumbs.TryGetProperty("500", out var thumb500))
                        {
                            var url500 = thumb500.GetString();
                            if (url500 != null)
                            {
                                _logger.LogDebug("Found 500px cover art for {Id}", mbid);
                                return url500;
                            }
                        }
                        if (thumbs.TryGetProperty("large", out var large))
                        {
                            var urlLarge = large.GetString();
                            if (urlLarge != null)
                            {
                                _logger.LogDebug("Found large cover art for {Id}", mbid);
                                return urlLarge;
                            }
                        }
                    }

                    var imageUrl = image.GetProperty("image").GetString();
                    if (imageUrl != null)
                    {
                        _logger.LogDebug("Found full cover art for {Id}", mbid);
                        return imageUrl;
                    }
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting cover art for {MusicBrainzId}", mbid);
            return null;
        }
    }
}
