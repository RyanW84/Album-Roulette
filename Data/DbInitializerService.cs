using AlbumRoulette.Models;

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

    private async Task SeedAlbumsAsync()
    {
        var albums = GetInitialAlbumData();
        await _context.Albums.AddRangeAsync(albums);
        await _context.SaveChangesAsync();
        _logger.LogInformation("Database seeded with {Count} albums", albums.Count);
    }

    /// <summary>
    /// Gets the initial album data - extracted to a separate method for clarity (DRY principle).
    /// </summary>
    private static List<Album> GetInitialAlbumData()
    {
        return new List<Album>
        {
            Create(1, "What's Going On", "Marvin Gaye", "Tamla/Motown", 1971),
            Create(2, "Pet Sounds", "The Beach Boys", "Capitol", 1966),
            Create(3, "Blue", "Joni Mitchell", "Reprise", 1971),
            Create(4, "Songs in the Key of Life", "Stevie Wonder", "Tamla/Motown", 1976),
            Create(5, "Abbey Road", "The Beatles", "Apple", 1969),
            Create(6, "Nevermind", "Nirvana", "Geffen", 1991),
            Create(7, "Rumours", "Fleetwood Mac", "Warner Bros.", 1977),
            Create(8, "Purple Rain", "Prince and the Revolution", "Warner Bros.", 1984),
            Create(9, "Blood on the Tracks", "Bob Dylan", "Columbia", 1975),
            Create(
                10,
                "The Miseducation of Lauryn Hill",
                "Lauryn Hill",
                "Ruffhouse/Columbia",
                1998
            ),
            Create(11, "Revolver", "The Beatles", "Apple", 1966),
            Create(12, "Thriller", "Michael Jackson", "Epic", 1982),
            Create(
                13,
                "I Never Loved a Man the Way I Love You",
                "Aretha Franklin",
                "Atlantic",
                1967
            ),
            Create(
                14,
                "Exile on Main Street",
                "The Rolling Stones",
                "Rolling Stones Records",
                1972
            ),
            Create(
                15,
                "It Takes a Nation of Millions to Hold Us Back",
                "Public Enemy",
                "Def Jam",
                1988
            ),
            Create(16, "London Calling", "The Clash", "CBS", 1979),
            Create(17, "My Beautiful Dark Twisted Fantasy", "Kanye West", "Roc-A-Fella", 2010),
            Create(18, "Highway 61 Revisited", "Bob Dylan", "Columbia", 1965),
            Create(19, "To Pimp a Butterfly", "Kendrick Lamar", "TDE", 2015),
            Create(20, "Kid A", "Radiohead", "Parlophone", 2000),
            Create(21, "Born to Run", "Bruce Springsteen", "Columbia", 1975),
            Create(22, "Ready to Die", "The Notorious B.I.G.", "Bad Boy", 1994),
            Create(23, "The Velvet Underground and Nico", "The Velvet Underground", "Verve", 1967),
            Create(24, "Sgt. Pepper's Lonely Hearts Club Band", "The Beatles", "Capitol", 1967),
            Create(25, "Tapestry", "Carole King", "Sony", 1971),
            Create(26, "Horses", "Patti Smith", "Arista", 1975),
            Create(27, "Enter the Wu-Tang (36 Chambers)", "Wu-Tang Clan", "Loud", 1993),
            Create(28, "Voodoo", "D'Angelo", "EMI", 2000),
            Create(29, "White Album", "The Beatles", "Apple", 1968),
            Create(30, "Are You Experienced", "Jimi Hendrix", "Track", 1967),
            Create(31, "Kind of Blue", "Miles Davis", "Columbia", 1959),
            Create(32, "Lemonade", "Beyonce", "Parkwood/Columbia", 2016),
            Create(33, "Back to Black", "Amy Winehouse", "Island", 2006),
            Create(34, "Innervisions", "Stevie Wonder", "Tamla/Motown", 1973),
            Create(35, "Rubber Soul", "The Beatles", "Parlophone", 1965),
            Create(36, "Off the Wall", "Michael Jackson", "Epic", 1979),
            Create(37, "The Chronic", "Dr. Dre", "Deathrow", 1992),
            Create(38, "Blonde on Blonde", "Bob Dylan", "Columbia", 1966),
            Create(39, "Remain in Light", "Talking Heads", "Sire", 1980),
            Create(40, "The Rise and Fall of Ziggy Stardust", "David Bowie", "RCA", 1972),
            Create(41, "Let It Bleed", "The Rolling Stones", "ABKCO", 1969),
            Create(42, "OK Computer", "Radiohead", "Capitol", 1997),
            Create(43, "The Low End Theory", "A Tribe Called Quest", "Jive", 1991),
            Create(44, "Illmatic", "Nas", "Columbia", 1994),
            Create(45, "Sign O the Times", "Prince", "Paisley Park", 1987),
            Create(46, "Graceland", "Paul Simon", "Columbia", 1986),
            Create(47, "Ramones", "Ramones", "Sire", 1976),
            Create(48, "Legend", "Bob Marley and the Wailers", "Island", 1984),
            Create(49, "Aquemini", "OutKast", "LaFace", 1998),
            Create(50, "The Blueprint", "Jay-Z", "Roc-A-Fella", 2001),
            Create(51, "The Great Twenty-Eight", "Chuck Berry", "Chess", 1982),
            Create(52, "Station to Station", "David Bowie", "RCA", 1976),
            Create(53, "Electric Ladyland", "Jimi Hendrix", "Reprise", 1968),
            Create(54, "Star Time", "James Brown", "Polydor", 1991),
            Create(55, "The Dark Side of the Moon", "Pink Floyd", "EMI", 1973),
            Create(56, "Exile in Guyville", "Liz Phair", "Matador", 1993),
            Create(57, "The Band", "The Band", "Capitol", 1969),
            Create(58, "Led Zeppelin IV", "Led Zeppelin", "Atlantic", 1971),
            Create(59, "Talking Book", "Stevie Wonder", "Tamla/Motown", 1972),
            Create(60, "Astral Weeks", "Van Morrison", "Warner Bros.", 1968),
            Create(61, "Paid in Full", "Eric B. and Rakim", "4th and Broadway", 1987),
            Create(62, "Appetite for Destruction", "Guns N Roses", "Geffen", 1987),
            Create(63, "Aja", "Steely Dan", "ABC", 1977),
            Create(64, "Stankonia", "OutKast", "LaFace", 2000),
            Create(65, "Live at the Apollo", "James Brown", "King", 1963),
            Create(66, "A Love Supreme", "John Coltrane", "Impulse!", 1965),
            Create(67, "Reasonable Doubt", "Jay-Z", "Roc-A-Fella", 1996),
            Create(68, "Hounds of Love", "Kate Bush", "EMI", 1985),
            Create(69, "Jagged Little Pill", "Alanis Morissette", "Maverick", 1995),
            Create(70, "Straight Outta Compton", "N.W.A", "Ruthless", 1988),
            Create(71, "Exodus", "Bob Marley and the Wailers", "Island", 1977),
            Create(72, "Harvest", "Neil Young", "Reprise", 1972),
            Create(73, "Loveless", "My Bloody Valentine", "Sire", 1991),
            Create(74, "The College Dropout", "Kanye West", "Roc-A-Fella", 2004),
            Create(75, "Lady Soul", "Aretha Franklin", "Atlantic", 1968),
            Create(76, "Superfly", "Curtis Mayfield", "Curtom", 1972),
            Create(77, "Whos Next", "The Who", "Decca", 1971),
            Create(78, "The Sun Sessions", "Elvis Presley", "RCA", 1976),
            Create(79, "Blond", "Frank Ocean", "Boys Dont Cry", 2016),
            Create(80, "Never Mind the Bollocks", "The Sex Pistols", "Warner Bros.", 1977),
            Create(81, "Beyonce", "Beyonce", "Parkwood/Columbia", 2013),
            Create(82, "Theres a Riot Goin On", "Sly and the Family Stone", "Epic", 1971),
            Create(83, "Dusty in Memphis", "Dusty Springfield", "Atlantic", 1969),
            Create(84, "Back in Black", "AC/DC", "Atlantic", 1980),
            Create(85, "Plastic Ono Band", "John Lennon", "Apple", 1970),
            Create(86, "The Doors", "The Doors", "Elektra", 1967),
            Create(87, "Bitches Brew", "Miles Davis", "Columbia", 1970),
            Create(88, "Hunky Dory", "David Bowie", "RCA", 1971),
            Create(89, "Baduizm", "Erykah Badu", "Kedar", 1997),
            Create(90, "After the Gold Rush", "Neil Young", "Reprise", 1970),
            Create(91, "Darkness on the Edge of Town", "Bruce Springsteen", "Columbia", 1978),
            Create(92, "Axis Bold as Love", "The Jimi Hendrix Experience", "Track", 1967),
            Create(93, "Supa Dupa Fly", "Missy Elliott", "Goldmind", 1997),
            Create(94, "Fun House", "The Stooges", "Elektra", 1970),
            Create(95, "Take Care", "Drake", "Cash Money", 2011),
            Create(96, "Automatic for the People", "R.E.M.", "Warner Bros.", 1992),
            Create(97, "Master of Puppets", "Metallica", "Elektra", 1986),
            Create(98, "Car Wheels on a Gravel Road", "Lucinda Williams", "Mercury", 1998),
            Create(99, "Red", "Taylor Swift", "Big Machine", 2012),
            Create(100, "OK Computer", "Radiohead", "Parlophone", 1997),
        };
    }

    /// <summary>
    /// Helper method to create an album (DRY principle).
    /// </summary>
    private static Album Create(int rank, string title, string artist, string label, int year) =>
        new()
        {
            Rank = rank,
            AlbumTitle = title,
            Artist = artist,
            Label = label,
            Year = year,
            IsEnriched = false,
            LastEnrichedAt = DateTime.MinValue,
        };
}
