namespace AlbumRoulette.Models;

public class Album
{
    public int Id { get; set; }
    public int Rank { get; set; }
    public string AlbumTitle { get; set; } = "";
    public string Artist { get; set; } = "";
    public string Label { get; set; } = "";
    public int Year { get; set; }

    // Enriched from MusicBrainz / Cover Art Archive
    public string? CoverArtUrl { get; set; }
    public string? MusicBrainzId { get; set; }
    public string? Genre { get; set; }

    // Metadata
    public DateTime LastEnrichedAt { get; set; } = DateTime.MinValue;
    public bool IsEnriched { get; set; } = false;

    // Listening links (calculated properties)
    public string SpotifySearchUrl =>
        $"https://open.spotify.com/search/{Uri.EscapeDataString($"{Artist} {AlbumTitle}")}";

    public string YouTubeSearchUrl =>
        $"https://www.youtube.com/results?search_query={Uri.EscapeDataString($"{Artist} {AlbumTitle} full album HD remastered")}";

    public string AppleMusicSearchUrl =>
        $"https://music.apple.com/search?term={Uri.EscapeDataString($"{Artist} {AlbumTitle}")}";

    public string TidalSearchUrl =>
        $"https://tidal.com/search?q={Uri.EscapeDataString($"{Artist} {AlbumTitle}")}";
}
