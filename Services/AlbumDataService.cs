using AlbumRoulette.Models;

namespace AlbumRoulette.Services;

public class AlbumDataService
{
    private static readonly List<Album> _albums =
    [
        new()
        {
            Rank = 1,
            AlbumTitle = "What's Going On",
            Artist = "Marvin Gaye",
            Label = "Tamla/Motown",
            Year = 1971,
        },
        new()
        {
            Rank = 2,
            AlbumTitle = "Pet Sounds",
            Artist = "The Beach Boys",
            Label = "Capitol",
            Year = 1966,
        },
        new()
        {
            Rank = 3,
            AlbumTitle = "Blue",
            Artist = "Joni Mitchell",
            Label = "Reprise",
            Year = 1971,
        },
        new()
        {
            Rank = 4,
            AlbumTitle = "Songs in the Key of Life",
            Artist = "Stevie Wonder",
            Label = "Tamla/Motown",
            Year = 1976,
        },
        new()
        {
            Rank = 5,
            AlbumTitle = "Abbey Road",
            Artist = "The Beatles",
            Label = "Apple",
            Year = 1969,
        },
        new()
        {
            Rank = 6,
            AlbumTitle = "Nevermind",
            Artist = "Nirvana",
            Label = "Geffen",
            Year = 1991,
        },
        new()
        {
            Rank = 7,
            AlbumTitle = "Rumours",
            Artist = "Fleetwood Mac",
            Label = "Warner Bros.",
            Year = 1977,
        },
        new()
        {
            Rank = 8,
            AlbumTitle = "Purple Rain",
            Artist = "Prince and the Revolution",
            Label = "Warner Bros.",
            Year = 1984,
        },
        new()
        {
            Rank = 9,
            AlbumTitle = "Blood on the Tracks",
            Artist = "Bob Dylan",
            Label = "Columbia",
            Year = 1975,
        },
        new()
        {
            Rank = 10,
            AlbumTitle = "The Miseducation of Lauryn Hill",
            Artist = "Lauryn Hill",
            Label = "Ruffhouse/Columbia",
            Year = 1998,
        },
        new()
        {
            Rank = 11,
            AlbumTitle = "Revolver",
            Artist = "The Beatles",
            Label = "Apple",
            Year = 1966,
        },
        new()
        {
            Rank = 12,
            AlbumTitle = "Thriller",
            Artist = "Michael Jackson",
            Label = "Epic",
            Year = 1982,
        },
        new()
        {
            Rank = 13,
            AlbumTitle = "I Never Loved a Man the Way I Love You",
            Artist = "Aretha Franklin",
            Label = "Atlantic",
            Year = 1967,
        },
        new()
        {
            Rank = 14,
            AlbumTitle = "Exile on Main Street",
            Artist = "The Rolling Stones",
            Label = "Rolling Stones Records",
            Year = 1972,
        },
        new()
        {
            Rank = 15,
            AlbumTitle = "It Takes a Nation of Millions to Hold Us Back",
            Artist = "Public Enemy",
            Label = "Def Jam",
            Year = 1988,
        },
        new()
        {
            Rank = 16,
            AlbumTitle = "London Calling",
            Artist = "The Clash",
            Label = "CBS",
            Year = 1979,
        },
        new()
        {
            Rank = 17,
            AlbumTitle = "My Beautiful Dark Twisted Fantasy",
            Artist = "Kanye West",
            Label = "Roc-A-Fella",
            Year = 2010,
        },
        new()
        {
            Rank = 18,
            AlbumTitle = "Highway 61 Revisited",
            Artist = "Bob Dylan",
            Label = "Columbia",
            Year = 1965,
        },
        new()
        {
            Rank = 19,
            AlbumTitle = "To Pimp a Butterfly",
            Artist = "Kendrick Lamar",
            Label = "TDE",
            Year = 2015,
        },
        new()
        {
            Rank = 20,
            AlbumTitle = "Kid A",
            Artist = "Radiohead",
            Label = "Parlophone",
            Year = 2000,
        },
        new()
        {
            Rank = 21,
            AlbumTitle = "Born to Run",
            Artist = "Bruce Springsteen",
            Label = "Columbia",
            Year = 1975,
        },
        new()
        {
            Rank = 22,
            AlbumTitle = "Ready to Die",
            Artist = "The Notorious B.I.G.",
            Label = "Bad Boy",
            Year = 1994,
        },
        new()
        {
            Rank = 23,
            AlbumTitle = "The Velvet Underground and Nico",
            Artist = "The Velvet Underground",
            Label = "Verve",
            Year = 1967,
        },
        new()
        {
            Rank = 24,
            AlbumTitle = "Sgt. Pepper's Lonely Hearts Club Band",
            Artist = "The Beatles",
            Label = "Capitol",
            Year = 1967,
        },
        new()
        {
            Rank = 25,
            AlbumTitle = "Tapestry",
            Artist = "Carole King",
            Label = "Sony",
            Year = 1971,
        },
        new()
        {
            Rank = 26,
            AlbumTitle = "Horses",
            Artist = "Patti Smith",
            Label = "Arista",
            Year = 1975,
        },
        new()
        {
            Rank = 27,
            AlbumTitle = "Enter the Wu-Tang (36 Chambers)",
            Artist = "Wu-Tang Clan",
            Label = "Loud",
            Year = 1993,
        },
        new()
        {
            Rank = 28,
            AlbumTitle = "Voodoo",
            Artist = "D'Angelo",
            Label = "EMI",
            Year = 2000,
        },
        new()
        {
            Rank = 29,
            AlbumTitle = "White Album",
            Artist = "The Beatles",
            Label = "Apple",
            Year = 1968,
        },
        new()
        {
            Rank = 30,
            AlbumTitle = "Are You Experienced",
            Artist = "Jimi Hendrix",
            Label = "Track",
            Year = 1967,
        },
        new()
        {
            Rank = 31,
            AlbumTitle = "Kind of Blue",
            Artist = "Miles Davis",
            Label = "Columbia",
            Year = 1959,
        },
        new()
        {
            Rank = 32,
            AlbumTitle = "Lemonade",
            Artist = "Beyonce",
            Label = "Parkwood/Columbia",
            Year = 2016,
        },
        new()
        {
            Rank = 33,
            AlbumTitle = "Back to Black",
            Artist = "Amy Winehouse",
            Label = "Island",
            Year = 2006,
        },
        new()
        {
            Rank = 34,
            AlbumTitle = "Innervisions",
            Artist = "Stevie Wonder",
            Label = "Tamla/Motown",
            Year = 1973,
        },
        new()
        {
            Rank = 35,
            AlbumTitle = "Rubber Soul",
            Artist = "The Beatles",
            Label = "Parlophone",
            Year = 1965,
        },
        new()
        {
            Rank = 36,
            AlbumTitle = "Off the Wall",
            Artist = "Michael Jackson",
            Label = "Epic",
            Year = 1979,
        },
        new()
        {
            Rank = 37,
            AlbumTitle = "The Chronic",
            Artist = "Dr. Dre",
            Label = "Deathrow",
            Year = 1992,
        },
        new()
        {
            Rank = 38,
            AlbumTitle = "Blonde on Blonde",
            Artist = "Bob Dylan",
            Label = "Columbia",
            Year = 1966,
        },
        new()
        {
            Rank = 39,
            AlbumTitle = "Remain in Light",
            Artist = "Talking Heads",
            Label = "Sire",
            Year = 1980,
        },
        new()
        {
            Rank = 40,
            AlbumTitle = "The Rise and Fall of Ziggy Stardust",
            Artist = "David Bowie",
            Label = "RCA",
            Year = 1972,
        },
        new()
        {
            Rank = 41,
            AlbumTitle = "Let It Bleed",
            Artist = "The Rolling Stones",
            Label = "ABKCO",
            Year = 1969,
        },
        new()
        {
            Rank = 42,
            AlbumTitle = "OK Computer",
            Artist = "Radiohead",
            Label = "Capitol",
            Year = 1997,
        },
        new()
        {
            Rank = 43,
            AlbumTitle = "The Low End Theory",
            Artist = "A Tribe Called Quest",
            Label = "Jive",
            Year = 1991,
        },
        new()
        {
            Rank = 44,
            AlbumTitle = "Illmatic",
            Artist = "Nas",
            Label = "Columbia",
            Year = 1994,
        },
        new()
        {
            Rank = 45,
            AlbumTitle = "Sign O the Times",
            Artist = "Prince",
            Label = "Paisley Park",
            Year = 1987,
        },
        new()
        {
            Rank = 46,
            AlbumTitle = "Graceland",
            Artist = "Paul Simon",
            Label = "Columbia",
            Year = 1986,
        },
        new()
        {
            Rank = 47,
            AlbumTitle = "Ramones",
            Artist = "Ramones",
            Label = "Sire",
            Year = 1976,
        },
        new()
        {
            Rank = 48,
            AlbumTitle = "Legend",
            Artist = "Bob Marley and the Wailers",
            Label = "Island",
            Year = 1984,
        },
        new()
        {
            Rank = 49,
            AlbumTitle = "Aquemini",
            Artist = "OutKast",
            Label = "LaFace",
            Year = 1998,
        },
        new()
        {
            Rank = 50,
            AlbumTitle = "The Blueprint",
            Artist = "Jay-Z",
            Label = "Roc-A-Fella",
            Year = 2001,
        },
        new()
        {
            Rank = 51,
            AlbumTitle = "The Great Twenty-Eight",
            Artist = "Chuck Berry",
            Label = "Chess",
            Year = 1982,
        },
        new()
        {
            Rank = 52,
            AlbumTitle = "Station to Station",
            Artist = "David Bowie",
            Label = "RCA",
            Year = 1976,
        },
        new()
        {
            Rank = 53,
            AlbumTitle = "Electric Ladyland",
            Artist = "Jimi Hendrix",
            Label = "Reprise",
            Year = 1968,
        },
        new()
        {
            Rank = 54,
            AlbumTitle = "Star Time",
            Artist = "James Brown",
            Label = "Polydor",
            Year = 1991,
        },
        new()
        {
            Rank = 55,
            AlbumTitle = "The Dark Side of the Moon",
            Artist = "Pink Floyd",
            Label = "EMI",
            Year = 1973,
        },
        new()
        {
            Rank = 56,
            AlbumTitle = "Exile in Guyville",
            Artist = "Liz Phair",
            Label = "Matador",
            Year = 1993,
        },
        new()
        {
            Rank = 57,
            AlbumTitle = "The Band",
            Artist = "The Band",
            Label = "Capitol",
            Year = 1969,
        },
        new()
        {
            Rank = 58,
            AlbumTitle = "Led Zeppelin IV",
            Artist = "Led Zeppelin",
            Label = "Atlantic",
            Year = 1971,
        },
        new()
        {
            Rank = 59,
            AlbumTitle = "Talking Book",
            Artist = "Stevie Wonder",
            Label = "Tamla/Motown",
            Year = 1972,
        },
        new()
        {
            Rank = 60,
            AlbumTitle = "Astral Weeks",
            Artist = "Van Morrison",
            Label = "Warner Bros.",
            Year = 1968,
        },
        new()
        {
            Rank = 61,
            AlbumTitle = "Paid in Full",
            Artist = "Eric B. and Rakim",
            Label = "4th and Broadway",
            Year = 1987,
        },
        new()
        {
            Rank = 62,
            AlbumTitle = "Appetite for Destruction",
            Artist = "Guns N Roses",
            Label = "Geffen",
            Year = 1987,
        },
        new()
        {
            Rank = 63,
            AlbumTitle = "Aja",
            Artist = "Steely Dan",
            Label = "ABC",
            Year = 1977,
        },
        new()
        {
            Rank = 64,
            AlbumTitle = "Stankonia",
            Artist = "OutKast",
            Label = "LaFace",
            Year = 2000,
        },
        new()
        {
            Rank = 65,
            AlbumTitle = "Live at the Apollo",
            Artist = "James Brown",
            Label = "King",
            Year = 1963,
        },
        new()
        {
            Rank = 66,
            AlbumTitle = "A Love Supreme",
            Artist = "John Coltrane",
            Label = "Impulse!",
            Year = 1965,
        },
        new()
        {
            Rank = 67,
            AlbumTitle = "Reasonable Doubt",
            Artist = "Jay-Z",
            Label = "Roc-A-Fella",
            Year = 1996,
        },
        new()
        {
            Rank = 68,
            AlbumTitle = "Hounds of Love",
            Artist = "Kate Bush",
            Label = "EMI",
            Year = 1985,
        },
        new()
        {
            Rank = 69,
            AlbumTitle = "Jagged Little Pill",
            Artist = "Alanis Morissette",
            Label = "Maverick",
            Year = 1995,
        },
        new()
        {
            Rank = 70,
            AlbumTitle = "Straight Outta Compton",
            Artist = "N.W.A",
            Label = "Ruthless",
            Year = 1988,
        },
        new()
        {
            Rank = 71,
            AlbumTitle = "Exodus",
            Artist = "Bob Marley and the Wailers",
            Label = "Island",
            Year = 1977,
        },
        new()
        {
            Rank = 72,
            AlbumTitle = "Harvest",
            Artist = "Neil Young",
            Label = "Reprise",
            Year = 1972,
        },
        new()
        {
            Rank = 73,
            AlbumTitle = "Loveless",
            Artist = "My Bloody Valentine",
            Label = "Sire",
            Year = 1991,
        },
        new()
        {
            Rank = 74,
            AlbumTitle = "The College Dropout",
            Artist = "Kanye West",
            Label = "Roc-A-Fella",
            Year = 2004,
        },
        new()
        {
            Rank = 75,
            AlbumTitle = "Lady Soul",
            Artist = "Aretha Franklin",
            Label = "Atlantic",
            Year = 1968,
        },
        new()
        {
            Rank = 76,
            AlbumTitle = "Superfly",
            Artist = "Curtis Mayfield",
            Label = "Curtom",
            Year = 1972,
        },
        new()
        {
            Rank = 77,
            AlbumTitle = "Whos Next",
            Artist = "The Who",
            Label = "Decca",
            Year = 1971,
        },
        new()
        {
            Rank = 78,
            AlbumTitle = "The Sun Sessions",
            Artist = "Elvis Presley",
            Label = "RCA",
            Year = 1976,
        },
        new()
        {
            Rank = 79,
            AlbumTitle = "Blond",
            Artist = "Frank Ocean",
            Label = "Boys Dont Cry",
            Year = 2016,
        },
        new()
        {
            Rank = 80,
            AlbumTitle = "Never Mind the Bollocks",
            Artist = "The Sex Pistols",
            Label = "Warner Bros.",
            Year = 1977,
        },
        new()
        {
            Rank = 81,
            AlbumTitle = "Beyonce",
            Artist = "Beyonce",
            Label = "Parkwood/Columbia",
            Year = 2013,
        },
        new()
        {
            Rank = 82,
            AlbumTitle = "Theres a Riot Goin On",
            Artist = "Sly and the Family Stone",
            Label = "Epic",
            Year = 1971,
        },
        new()
        {
            Rank = 83,
            AlbumTitle = "Dusty in Memphis",
            Artist = "Dusty Springfield",
            Label = "Atlantic",
            Year = 1969,
        },
        new()
        {
            Rank = 84,
            AlbumTitle = "Back in Black",
            Artist = "AC/DC",
            Label = "Atlantic",
            Year = 1980,
        },
        new()
        {
            Rank = 85,
            AlbumTitle = "Plastic Ono Band",
            Artist = "John Lennon",
            Label = "Apple",
            Year = 1970,
        },
        new()
        {
            Rank = 86,
            AlbumTitle = "The Doors",
            Artist = "The Doors",
            Label = "Elektra",
            Year = 1967,
        },
        new()
        {
            Rank = 87,
            AlbumTitle = "Bitches Brew",
            Artist = "Miles Davis",
            Label = "Columbia",
            Year = 1970,
        },
        new()
        {
            Rank = 88,
            AlbumTitle = "Hunky Dory",
            Artist = "David Bowie",
            Label = "RCA",
            Year = 1971,
        },
        new()
        {
            Rank = 89,
            AlbumTitle = "Baduizm",
            Artist = "Erykah Badu",
            Label = "Kedar",
            Year = 1997,
        },
        new()
        {
            Rank = 90,
            AlbumTitle = "After the Gold Rush",
            Artist = "Neil Young",
            Label = "Reprise",
            Year = 1970,
        },
        new()
        {
            Rank = 91,
            AlbumTitle = "Darkness on the Edge of Town",
            Artist = "Bruce Springsteen",
            Label = "Columbia",
            Year = 1978,
        },
        new()
        {
            Rank = 92,
            AlbumTitle = "Axis Bold as Love",
            Artist = "The Jimi Hendrix Experience",
            Label = "Track",
            Year = 1967,
        },
        new()
        {
            Rank = 93,
            AlbumTitle = "Supa Dupa Fly",
            Artist = "Missy Elliott",
            Label = "Goldmind",
            Year = 1997,
        },
        new()
        {
            Rank = 94,
            AlbumTitle = "Fun House",
            Artist = "The Stooges",
            Label = "Elektra",
            Year = 1970,
        },
        new()
        {
            Rank = 95,
            AlbumTitle = "Take Care",
            Artist = "Drake",
            Label = "Cash Money",
            Year = 2011,
        },
        new()
        {
            Rank = 96,
            AlbumTitle = "Automatic for the People",
            Artist = "R.E.M.",
            Label = "Warner Bros.",
            Year = 1992,
        },
        new()
        {
            Rank = 97,
            AlbumTitle = "Master of Puppets",
            Artist = "Metallica",
            Label = "Elektra",
            Year = 1986,
        },
        new()
        {
            Rank = 98,
            AlbumTitle = "Car Wheels on a Gravel Road",
            Artist = "Lucinda Williams",
            Label = "Mercury",
            Year = 1998,
        },
        new()
        {
            Rank = 99,
            AlbumTitle = "Red",
            Artist = "Taylor Swift",
            Label = "Big Machine",
            Year = 2012,
        },
        new()
        {
            Rank = 100,
            AlbumTitle = "Music From Big Pink",
            Artist = "The Band",
            Label = "Capitol",
            Year = 1968,
        },
        new()
        {
            Rank = 101,
            AlbumTitle = "Led Zeppelin",
            Artist = "Led Zeppelin",
            Label = "Atlantic",
            Year = 1969,
        },
        new()
        {
            Rank = 102,
            AlbumTitle = "The Clash",
            Artist = "The Clash",
            Label = "CBS",
            Year = 1977,
        },
        new()
        {
            Rank = 103,
            AlbumTitle = "Three Feet High and Rising",
            Artist = "De La Soul",
            Label = "Tommy Boy",
            Year = 1989,
        },
        new()
        {
            Rank = 104,
            AlbumTitle = "Sticky Fingers",
            Artist = "The Rolling Stones",
            Label = "Rolling Stones",
            Year = 1971,
        },
        new()
        {
            Rank = 105,
            AlbumTitle = "At Fillmore East",
            Artist = "The Allman Brothers",
            Label = "Capricorn",
            Year = 1971,
        },
        new()
        {
            Rank = 106,
            AlbumTitle = "Live Through This",
            Artist = "Hole",
            Label = "Geffen",
            Year = 1994,
        },
        new()
        {
            Rank = 107,
            AlbumTitle = "Marquee Moon",
            Artist = "Television",
            Label = "Elektra",
            Year = 1977,
        },
        new()
        {
            Rank = 108,
            AlbumTitle = "When the Pawn",
            Artist = "Fiona Apple",
            Label = "Epic",
            Year = 1999,
        },
        new()
        {
            Rank = 109,
            AlbumTitle = "Transformer",
            Artist = "Lou Reed",
            Label = "RCA",
            Year = 1972,
        },
        new()
        {
            Rank = 110,
            AlbumTitle = "Court and Spark",
            Artist = "Joni Mitchell",
            Label = "Asylum",
            Year = 1974,
        },
        new()
        {
            Rank = 111,
            AlbumTitle = "Control",
            Artist = "Janet Jackson",
            Label = "A and M",
            Year = 1986,
        },
        new()
        {
            Rank = 112,
            AlbumTitle = "Goodbye Yellow Brick Road",
            Artist = "Elton John",
            Label = "MCA",
            Year = 1973,
        },
        new()
        {
            Rank = 113,
            AlbumTitle = "The Queen Is Dead",
            Artist = "The Smiths",
            Label = "Sire",
            Year = 1986,
        },
        new()
        {
            Rank = 114,
            AlbumTitle = "Is This It",
            Artist = "The Strokes",
            Label = "RCA",
            Year = 2001,
        },
        new()
        {
            Rank = 115,
            AlbumTitle = "good kid m.A.A.d city",
            Artist = "Kendrick Lamar",
            Label = "TDE",
            Year = 2012,
        },
        new()
        {
            Rank = 116,
            AlbumTitle = "Disintegration",
            Artist = "The Cure",
            Label = "Fiction",
            Year = 1989,
        },
        new()
        {
            Rank = 117,
            AlbumTitle = "Late Registration",
            Artist = "Kanye West",
            Label = "Roc-A-Fella",
            Year = 2005,
        },
        new()
        {
            Rank = 118,
            AlbumTitle = "Hotel California",
            Artist = "The Eagles",
            Label = "Asylum",
            Year = 1976,
        },
        new()
        {
            Rank = 119,
            AlbumTitle = "Stand!",
            Artist = "Sly and the Family Stone",
            Label = "Epic",
            Year = 1969,
        },
        new()
        {
            Rank = 120,
            AlbumTitle = "Moondance",
            Artist = "Van Morrison",
            Label = "Warner Bros.",
            Year = 1970,
        },
        new()
        {
            Rank = 121,
            AlbumTitle = "This Years Model",
            Artist = "Elvis Costello",
            Label = "Columbia",
            Year = 1978,
        },
        new()
        {
            Rank = 122,
            AlbumTitle = "The Downward Spiral",
            Artist = "Nine Inch Nails",
            Label = "Nothing/Interscope",
            Year = 1994,
        },
        new()
        {
            Rank = 123,
            AlbumTitle = "Led Zeppelin II",
            Artist = "Led Zeppelin",
            Label = "Atlantic",
            Year = 1969,
        },
        new()
        {
            Rank = 124,
            AlbumTitle = "Achtung Baby",
            Artist = "U2",
            Label = "Island",
            Year = 1991,
        },
        new()
        {
            Rank = 125,
            AlbumTitle = "Pauls Boutique",
            Artist = "Beastie Boys",
            Label = "Capitol",
            Year = 1989,
        },
        new()
        {
            Rank = 126,
            AlbumTitle = "My Life",
            Artist = "Mary J. Blige",
            Label = "Uptown",
            Year = 1994,
        },
        new()
        {
            Rank = 127,
            AlbumTitle = "Modern Sounds in Country and Western Music",
            Artist = "Ray Charles",
            Label = "ABC-Paramount",
            Year = 1962,
        },
        new()
        {
            Rank = 128,
            AlbumTitle = "A Night at the Opera",
            Artist = "Queen",
            Label = "Elektra",
            Year = 1975,
        },
        new()
        {
            Rank = 129,
            AlbumTitle = "The Wall",
            Artist = "Pink Floyd",
            Label = "Columbia",
            Year = 1979,
        },
        new()
        {
            Rank = 130,
            AlbumTitle = "1999",
            Artist = "Prince",
            Label = "Warner Bros.",
            Year = 1982,
        },
        new()
        {
            Rank = 131,
            AlbumTitle = "Dummy",
            Artist = "Portishead",
            Label = "Go! Beat",
            Year = 1994,
        },
        new()
        {
            Rank = 132,
            AlbumTitle = "40 Greatest Hits",
            Artist = "Hank Williams",
            Label = "Polydor",
            Year = 1978,
        },
        new()
        {
            Rank = 133,
            AlbumTitle = "Hejira",
            Artist = "Joni Mitchell",
            Label = "Asylum",
            Year = 1976,
        },
        new()
        {
            Rank = 134,
            AlbumTitle = "The Score",
            Artist = "Fugees",
            Label = "Columbia",
            Year = 1996,
        },
        new()
        {
            Rank = 135,
            AlbumTitle = "The Joshua Tree",
            Artist = "U2",
            Label = "Island",
            Year = 1987,
        },
        new()
        {
            Rank = 136,
            AlbumTitle = "Maggot Brain",
            Artist = "Funkadelic",
            Label = "Westbound",
            Year = 1971,
        },
        new()
        {
            Rank = 137,
            AlbumTitle = "21",
            Artist = "Adele",
            Label = "Columbia",
            Year = 2011,
        },
        new()
        {
            Rank = 138,
            AlbumTitle = "The Immaculate Collection",
            Artist = "Madonna",
            Label = "Sire",
            Year = 1990,
        },
        new()
        {
            Rank = 139,
            AlbumTitle = "Paranoid",
            Artist = "Black Sabbath",
            Label = "Vertigo",
            Year = 1970,
        },
        new()
        {
            Rank = 140,
            AlbumTitle = "Catch a Fire",
            Artist = "Bob Marley and the Wailers",
            Label = "Island",
            Year = 1973,
        },
        new()
        {
            Rank = 141,
            AlbumTitle = "Doolittle",
            Artist = "Pixies",
            Label = "4AD/Elektra",
            Year = 1989,
        },
        new()
        {
            Rank = 142,
            AlbumTitle = "Born in the U.S.A.",
            Artist = "Bruce Springsteen",
            Label = "Columbia",
            Year = 1984,
        },
        new()
        {
            Rank = 143,
            AlbumTitle = "The Velvet Underground",
            Artist = "The Velvet Underground",
            Label = "MGM",
            Year = 1969,
        },
        new()
        {
            Rank = 144,
            AlbumTitle = "Physical Graffiti",
            Artist = "Led Zeppelin",
            Label = "Swan Song",
            Year = 1975,
        },
        new()
        {
            Rank = 145,
            AlbumTitle = "The Marshall Mathers LP",
            Artist = "Eminem",
            Label = "Interscope",
            Year = 2000,
        },
        new()
        {
            Rank = 146,
            AlbumTitle = "Parallel Lines",
            Artist = "Blondie",
            Label = "Chrysalis",
            Year = 1978,
        },
        new()
        {
            Rank = 147,
            AlbumTitle = "Grace",
            Artist = "Jeff Buckley",
            Label = "Columbia",
            Year = 1994,
        },
        new()
        {
            Rank = 148,
            AlbumTitle = "Channel Orange",
            Artist = "Frank Ocean",
            Label = "Def Jam",
            Year = 2012,
        },
        new()
        {
            Rank = 149,
            AlbumTitle = "John Prine",
            Artist = "John Prine",
            Label = "Atlantic",
            Year = 1971,
        },
        new()
        {
            Rank = 150,
            AlbumTitle = "Nebraska",
            Artist = "Bruce Springsteen",
            Label = "Columbia",
            Year = 1982,
        },
        new()
        {
            Rank = 151,
            AlbumTitle = "Faith",
            Artist = "George Michael",
            Label = "Columbia",
            Year = 1987,
        },
        new()
        {
            Rank = 152,
            AlbumTitle = "Pretenders",
            Artist = "The Pretenders",
            Label = "Sire",
            Year = 1980,
        },
        new()
        {
            Rank = 153,
            AlbumTitle = "Rid of Me",
            Artist = "PJ Harvey",
            Label = "Island",
            Year = 1993,
        },
        new()
        {
            Rank = 154,
            AlbumTitle = "Amazing Grace",
            Artist = "Aretha Franklin",
            Label = "Atlantic",
            Year = 1972,
        },
        new()
        {
            Rank = 155,
            AlbumTitle = "The Black Album",
            Artist = "Jay-Z",
            Label = "Roc-A-Fella",
            Year = 2003,
        },
        new()
        {
            Rank = 156,
            AlbumTitle = "Let It Be",
            Artist = "The Replacements",
            Label = "Twin/Tone",
            Year = 1984,
        },
        new()
        {
            Rank = 157,
            AlbumTitle = "Whats the Story Morning Glory",
            Artist = "Oasis",
            Label = "Epic",
            Year = 1995,
        },
        new()
        {
            Rank = 158,
            AlbumTitle = "Mamas Gun",
            Artist = "Erykah Badu",
            Label = "Motown",
            Year = 2000,
        },
        new()
        {
            Rank = 159,
            AlbumTitle = "Synchronicity",
            Artist = "The Police",
            Label = "A and M",
            Year = 1983,
        },
        new()
        {
            Rank = 160,
            AlbumTitle = "Ten",
            Artist = "Pearl Jam",
            Label = "Epic",
            Year = 1991,
        },
        new()
        {
            Rank = 161,
            AlbumTitle = "Crosby Stills and Nash",
            Artist = "Crosby Stills and Nash",
            Label = "Atlantic",
            Year = 1969,
        },
        new()
        {
            Rank = 162,
            AlbumTitle = "Different Class",
            Artist = "Pulp",
            Label = "Island",
            Year = 1995,
        },
        new()
        {
            Rank = 163,
            AlbumTitle = "Saturday Night Fever",
            Artist = "Various Artists",
            Label = "RSO",
            Year = 1977,
        },
        new()
        {
            Rank = 164,
            AlbumTitle = "At Folsom Prison",
            Artist = "Johnny Cash",
            Label = "Columbia",
            Year = 1968,
        },
        new()
        {
            Rank = 165,
            AlbumTitle = "Murmur",
            Artist = "R.E.M.",
            Label = "I.R.S.",
            Year = 1983,
        },
        new()
        {
            Rank = 166,
            AlbumTitle = "20 Golden Greats",
            Artist = "Buddy Holly",
            Label = "MCA",
            Year = 1978,
        },
        new()
        {
            Rank = 167,
            AlbumTitle = "Violator",
            Artist = "Depeche Mode",
            Label = "Sire",
            Year = 1990,
        },
        new()
        {
            Rank = 168,
            AlbumTitle = "Cant Buy a Thrill",
            Artist = "Steely Dan",
            Label = "ABC",
            Year = 1972,
        },
        new()
        {
            Rank = 169,
            AlbumTitle = "The Stranger",
            Artist = "Billy Joel",
            Label = "Columbia",
            Year = 1977,
        },
        new()
        {
            Rank = 170,
            AlbumTitle = "Disraeli Gears",
            Artist = "Cream",
            Label = "Reaction",
            Year = 1967,
        },
        new()
        {
            Rank = 171,
            AlbumTitle = "Daydream Nation",
            Artist = "Sonic Youth",
            Label = "Enigma",
            Year = 1988,
        },
        new()
        {
            Rank = 172,
            AlbumTitle = "Bridge Over Troubled Water",
            Artist = "Simon and Garfunkel",
            Label = "Columbia",
            Year = 1970,
        },
        new()
        {
            Rank = 173,
            AlbumTitle = "In Utero",
            Artist = "Nirvana",
            Label = "Geffen",
            Year = 1993,
        },
        new()
        {
            Rank = 174,
            AlbumTitle = "The Harder They Come",
            Artist = "Jimmy Cliff and Various Artists",
            Label = "Mango",
            Year = 1972,
        },
        new()
        {
            Rank = 175,
            AlbumTitle = "DAMN.",
            Artist = "Kendrick Lamar",
            Label = "TDE",
            Year = 2017,
        },
        new()
        {
            Rank = 176,
            AlbumTitle = "Fear of a Black Planet",
            Artist = "Public Enemy",
            Label = "Def Jam/Columbia",
            Year = 1990,
        },
        new()
        {
            Rank = 177,
            AlbumTitle = "Every Picture Tells a Story",
            Artist = "Rod Stewart",
            Label = "Mercury",
            Year = 1971,
        },
        new()
        {
            Rank = 178,
            AlbumTitle = "Otis Blue",
            Artist = "Otis Redding",
            Label = "Volt",
            Year = 1965,
        },
        new()
        {
            Rank = 179,
            AlbumTitle = "Life After Death",
            Artist = "Notorious B.I.G.",
            Label = "Bad Boy",
            Year = 1997,
        },
        new()
        {
            Rank = 180,
            AlbumTitle = "Forever Changes",
            Artist = "Love",
            Label = "Elektra",
            Year = 1967,
        },
        new()
        {
            Rank = 181,
            AlbumTitle = "Bringing It All Back Home",
            Artist = "Bob Dylan",
            Label = "Columbia",
            Year = 1965,
        },
        new()
        {
            Rank = 182,
            AlbumTitle = "Sweet Baby James",
            Artist = "James Taylor",
            Label = "Warner Bros.",
            Year = 1970,
        },
        new()
        {
            Rank = 183,
            AlbumTitle = "Brown Sugar",
            Artist = "DAngelo",
            Label = "EMI",
            Year = 1995,
        },
        new()
        {
            Rank = 184,
            AlbumTitle = "Shes So Unusual",
            Artist = "Cyndi Lauper",
            Label = "Portrait",
            Year = 1983,
        },
        new()
        {
            Rank = 185,
            AlbumTitle = "Beggars Banquet",
            Artist = "The Rolling Stones",
            Label = "Decca",
            Year = 1968,
        },
        new()
        {
            Rank = 186,
            AlbumTitle = "Blood Sugar Sex Magik",
            Artist = "Red Hot Chili Peppers",
            Label = "Warner Bros.",
            Year = 1991,
        },
        new()
        {
            Rank = 187,
            AlbumTitle = "AmeriKKKas Most Wanted",
            Artist = "Ice Cube",
            Label = "Priority",
            Year = 1990,
        },
        new()
        {
            Rank = 188,
            AlbumTitle = "Electric Warrior",
            Artist = "T. Rex",
            Label = "Reprise",
            Year = 1971,
        },
        new()
        {
            Rank = 189,
            AlbumTitle = "Dig Me Out",
            Artist = "Sleater-Kinney",
            Label = "Kill Rock Stars",
            Year = 1997,
        },
        new()
        {
            Rank = 190,
            AlbumTitle = "Tommy",
            Artist = "The Who",
            Label = "Decca",
            Year = 1969,
        },
        new()
        {
            Rank = 191,
            AlbumTitle = "At Last!",
            Artist = "Etta James",
            Label = "Argo",
            Year = 1961,
        },
        new()
        {
            Rank = 192,
            AlbumTitle = "Licensed to Ill",
            Artist = "Beastie Boys",
            Label = "Def Jam/Columbia",
            Year = 1986,
        },
        new()
        {
            Rank = 193,
            AlbumTitle = "Willy and the Poor Boys",
            Artist = "Creedence Clearwater Revival",
            Label = "Fantasy",
            Year = 1969,
        },
        new()
        {
            Rank = 194,
            AlbumTitle = "Bad",
            Artist = "Michael Jackson",
            Label = "Epic",
            Year = 1987,
        },
        new()
        {
            Rank = 195,
            AlbumTitle = "Songs of Leonard Cohen",
            Artist = "Leonard Cohen",
            Label = "Columbia",
            Year = 1967,
        },
        new()
        {
            Rank = 196,
            AlbumTitle = "Body Talk",
            Artist = "Robyn",
            Label = "Konichiwa",
            Year = 2010,
        },
        new()
        {
            Rank = 197,
            AlbumTitle = "Meet the Beatles!",
            Artist = "The Beatles",
            Label = "Capitol",
            Year = 1964,
        },
        new()
        {
            Rank = 198,
            AlbumTitle = "The B-52s",
            Artist = "The B-52s",
            Label = "Warner Bros.",
            Year = 1979,
        },
        new()
        {
            Rank = 199,
            AlbumTitle = "Slanted and Enchanted",
            Artist = "Pavement",
            Label = "Matador",
            Year = 1993,
        },
        new()
        {
            Rank = 200,
            AlbumTitle = "Diamond Life",
            Artist = "Sade",
            Label = "Epic",
            Year = 1984,
        },
        new()
        {
            Rank = 201,
            AlbumTitle = "Midnight Marauders",
            Artist = "A Tribe Called Quest",
            Label = "Jive",
            Year = 1993,
        },
        new()
        {
            Rank = 202,
            AlbumTitle = "Homogenic",
            Artist = "Bjork",
            Label = "Elektra",
            Year = 1997,
        },
        new()
        {
            Rank = 203,
            AlbumTitle = "Pink Moon",
            Artist = "Nick Drake",
            Label = "Island",
            Year = 1972,
        },
        new()
        {
            Rank = 204,
            AlbumTitle = "Graduation",
            Artist = "Kanye West",
            Label = "Roc-A-Fella",
            Year = 2007,
        },
        new()
        {
            Rank = 205,
            AlbumTitle = "Tea for the Tillerman",
            Artist = "Cat Stevens",
            Label = "A and M",
            Year = 1970,
        },
        new()
        {
            Rank = 206,
            AlbumTitle = "Low",
            Artist = "David Bowie",
            Label = "RCA",
            Year = 1977,
        },
        new()
        {
            Rank = 207,
            AlbumTitle = "Eagles",
            Artist = "Eagles",
            Label = "Asylum",
            Year = 1972,
        },
        new()
        {
            Rank = 208,
            AlbumTitle = "Tha Carter III",
            Artist = "Lil Wayne",
            Label = "Cash Money",
            Year = 2008,
        },
        new()
        {
            Rank = 209,
            AlbumTitle = "Raising Hell",
            Artist = "Run-DMC",
            Label = "Profile",
            Year = 1986,
        },
        new()
        {
            Rank = 210,
            AlbumTitle = "The Birth of Soul",
            Artist = "Ray Charles",
            Label = "Atlantic",
            Year = 1991,
        },
        new()
        {
            Rank = 211,
            AlbumTitle = "Unknown Pleasures",
            Artist = "Joy Division",
            Label = "Factory",
            Year = 1979,
        },
        new()
        {
            Rank = 212,
            AlbumTitle = "Wild Is the Wind",
            Artist = "Nina Simone",
            Label = "Philips",
            Year = 1966,
        },
        new()
        {
            Rank = 213,
            AlbumTitle = "The Idler Wheel",
            Artist = "Fiona Apple",
            Label = "Epic",
            Year = 2012,
        },
        new()
        {
            Rank = 214,
            AlbumTitle = "Wildflowers",
            Artist = "Tom Petty",
            Label = "Warner Bros.",
            Year = 1994,
        },
        new()
        {
            Rank = 215,
            AlbumTitle = "American Beauty",
            Artist = "Grateful Dead",
            Label = "Warner Bros.",
            Year = 1970,
        },
        new()
        {
            Rank = 216,
            AlbumTitle = "Either/Or",
            Artist = "Elliott Smith",
            Label = "Kill Rock Stars",
            Year = 1997,
        },
        new()
        {
            Rank = 217,
            AlbumTitle = "Definitely Maybe",
            Artist = "Oasis",
            Label = "Epic",
            Year = 1994,
        },
        new()
        {
            Rank = 218,
            AlbumTitle = "CrazySexyCool",
            Artist = "TLC",
            Label = "LaFace",
            Year = 1994,
        },
        new()
        {
            Rank = 219,
            AlbumTitle = "Only Built 4 Cuban Linx",
            Artist = "Raekwon",
            Label = "Loud/RCA",
            Year = 1995,
        },
        new()
        {
            Rank = 220,
            AlbumTitle = "Stephen Stills",
            Artist = "Stephen Stills",
            Label = "Epic",
            Year = 1970,
        },
        new()
        {
            Rank = 221,
            AlbumTitle = "Rage Against the Machine",
            Artist = "Rage Against the Machine",
            Label = "Epic",
            Year = 1992,
        },
        new()
        {
            Rank = 222,
            AlbumTitle = "Ray of Light",
            Artist = "Madonna",
            Label = "Maverick",
            Year = 1998,
        },
        new()
        {
            Rank = 223,
            AlbumTitle = "Imagine",
            Artist = "John Lennon",
            Label = "Apple",
            Year = 1971,
        },
        new()
        {
            Rank = 224,
            AlbumTitle = "Fly",
            Artist = "Dixie Chicks",
            Label = "Monument",
            Year = 1999,
        },
        new()
        {
            Rank = 225,
            AlbumTitle = "Yankee Hotel Foxtrot",
            Artist = "Wilco",
            Label = "Nonesuch",
            Year = 2001,
        },
        new()
        {
            Rank = 226,
            AlbumTitle = "Layla and Other Assorted Love Songs",
            Artist = "Derek and the Dominos",
            Label = "Atco",
            Year = 1970,
        },
        new()
        {
            Rank = 227,
            AlbumTitle = "Heres Little Richard",
            Artist = "Little Richard",
            Label = "Specialty",
            Year = 1957,
        },
        new()
        {
            Rank = 228,
            AlbumTitle = "De La Soul Is Dead",
            Artist = "De La Soul",
            Label = "Tommy Boy",
            Year = 1991,
        },
        new()
        {
            Rank = 229,
            AlbumTitle = "The Ultimate Collection",
            Artist = "Patsy Cline",
            Label = "Universal",
            Year = 2000,
        },
        new()
        {
            Rank = 230,
            AlbumTitle = "Anti",
            Artist = "Rihanna",
            Label = "Roc Nation",
            Year = 2016,
        },
        new()
        {
            Rank = 231,
            AlbumTitle = "Damn the Torpedoes",
            Artist = "Tom Petty and the Heartbreakers",
            Label = "Backstreet",
            Year = 1979,
        },
        new()
        {
            Rank = 232,
            AlbumTitle = "Giant Steps",
            Artist = "John Coltrane",
            Label = "Atlantic",
            Year = 1960,
        },
        new()
        {
            Rank = 233,
            AlbumTitle = "Little Earthquakes",
            Artist = "Tori Amos",
            Label = "Atlantic",
            Year = 1992,
        },
        new()
        {
            Rank = 234,
            AlbumTitle = "Master of Reality",
            Artist = "Black Sabbath",
            Label = "Vertigo",
            Year = 1971,
        },
        new()
        {
            Rank = 235,
            AlbumTitle = "Metallica The Black Album",
            Artist = "Metallica",
            Label = "Elektra",
            Year = 1991,
        },
        new()
        {
            Rank = 236,
            AlbumTitle = "Discovery",
            Artist = "Daft Punk",
            Label = "Virgin",
            Year = 2001,
        },
        new()
        {
            Rank = 237,
            AlbumTitle = "Red Headed Stranger",
            Artist = "Willie Nelson",
            Label = "Columbia",
            Year = 1975,
        },
        new()
        {
            Rank = 238,
            AlbumTitle = "Trans Europe Express",
            Artist = "Kraftwerk",
            Label = "Kling Klang",
            Year = 1977,
        },
        new()
        {
            Rank = 239,
            AlbumTitle = "Criminal Minded",
            Artist = "Boogie Down Productions",
            Label = "B-Boy",
            Year = 1987,
        },
        new()
        {
            Rank = 240,
            AlbumTitle = "Live at the Harlem Square Club",
            Artist = "Sam Cooke",
            Label = "RCA",
            Year = 1985,
        },
        new()
        {
            Rank = 241,
            AlbumTitle = "Blue Lines",
            Artist = "Massive Attack",
            Label = "Wildbunch/Virgin",
            Year = 1991,
        },
        new()
        {
            Rank = 242,
            AlbumTitle = "Loaded",
            Artist = "The Velvet Underground",
            Label = "Cotillion",
            Year = 1970,
        },
        new()
        {
            Rank = 243,
            AlbumTitle = "Odessey and Oracle",
            Artist = "The Zombies",
            Label = "Date",
            Year = 1968,
        },
        new()
        {
            Rank = 244,
            AlbumTitle = "808s and Heartbreak",
            Artist = "Kanye West",
            Label = "Roc-A-Fella",
            Year = 2008,
        },
        new()
        {
            Rank = 245,
            AlbumTitle = "Heaven or Las Vegas",
            Artist = "Cocteau Twins",
            Label = "4AD",
            Year = 1990,
        },
        new()
        {
            Rank = 246,
            AlbumTitle = "Mama Said Knock You Out",
            Artist = "LL Cool J",
            Label = "Def Jam/Columbia",
            Year = 1991,
        },
        new()
        {
            Rank = 247,
            AlbumTitle = "Love Deluxe",
            Artist = "Sade",
            Label = "Epic",
            Year = 1992,
        },
        new()
        {
            Rank = 248,
            AlbumTitle = "American Idiot",
            Artist = "Green Day",
            Label = "Reprise",
            Year = 2004,
        },
        new()
        {
            Rank = 249,
            AlbumTitle = "Whitney Houston",
            Artist = "Whitney Houston",
            Label = "Arista",
            Year = 1985,
        },
        new()
        {
            Rank = 250,
            AlbumTitle = "Singles Going Steady",
            Artist = "Buzzcocks",
            Label = "I.R.S.",
            Year = 1979,
        },
        new()
        {
            Rank = 251,
            AlbumTitle = "Honky Chateau",
            Artist = "Elton John",
            Label = "Uni",
            Year = 1972,
        },
        new()
        {
            Rank = 252,
            AlbumTitle = "Q Are We Not Men A We Are Devo",
            Artist = "Devo",
            Label = "Warner Bros.",
            Year = 1978,
        },
        new()
        {
            Rank = 253,
            AlbumTitle = "The Piper at the Gates of Dawn",
            Artist = "Pink Floyd",
            Label = "EMI/Columbia",
            Year = 1967,
        },
        new()
        {
            Rank = 254,
            AlbumTitle = "Head Hunters",
            Artist = "Herbie Hancock",
            Label = "Columbia",
            Year = 1973,
        },
        new()
        {
            Rank = 255,
            AlbumTitle = "The Freewheelin Bob Dylan",
            Artist = "Bob Dylan",
            Label = "Columbia",
            Year = 1963,
        },
        new()
        {
            Rank = 256,
            AlbumTitle = "Tracy Chapman",
            Artist = "Tracy Chapman",
            Label = "Elektra",
            Year = 1988,
        },
        new()
        {
            Rank = 257,
            AlbumTitle = "Coat of Many Colors",
            Artist = "Dolly Parton",
            Label = "RCA",
            Year = 1971,
        },
        new()
        {
            Rank = 258,
            AlbumTitle = "The Hissing of Summer Lawns",
            Artist = "Joni Mitchell",
            Label = "Asylum",
            Year = 1975,
        },
        new()
        {
            Rank = 259,
            AlbumTitle = "Pearl",
            Artist = "Janis Joplin",
            Label = "Columbia",
            Year = 1971,
        },
        new()
        {
            Rank = 260,
            AlbumTitle = "Cut",
            Artist = "The Slits",
            Label = "Antilles",
            Year = 1979,
        },
        new()
        {
            Rank = 261,
            AlbumTitle = "Check Your Head",
            Artist = "Beastie Boys",
            Label = "Capitol",
            Year = 1992,
        },
        new()
        {
            Rank = 262,
            AlbumTitle = "Power Corruption and Lies",
            Artist = "New Order",
            Label = "Factory",
            Year = 1983,
        },
        new()
        {
            Rank = 263,
            AlbumTitle = "A Hard Days Night",
            Artist = "The Beatles",
            Label = "United Artists",
            Year = 1964,
        },
        new()
        {
            Rank = 264,
            AlbumTitle = "Wish You Were Here",
            Artist = "Pink Floyd",
            Label = "Columbia",
            Year = 1975,
        },
        new()
        {
            Rank = 265,
            AlbumTitle = "Wowee Zowee",
            Artist = "Pavement",
            Label = "Matador",
            Year = 1995,
        },
        new()
        {
            Rank = 266,
            AlbumTitle = "Help!",
            Artist = "The Beatles",
            Label = "Capitol",
            Year = 1965,
        },
        new()
        {
            Rank = 267,
            AlbumTitle = "Double Nickels on the Dime",
            Artist = "Minutemen",
            Label = "SST",
            Year = 1984,
        },
        new()
        {
            Rank = 268,
            AlbumTitle = "Sail Away",
            Artist = "Randy Newman",
            Label = "Reprise",
            Year = 1972,
        },
        new()
        {
            Rank = 269,
            AlbumTitle = "Yeezus",
            Artist = "Kanye West",
            Label = "Roc-A-Fella",
            Year = 2013,
        },
        new()
        {
            Rank = 270,
            AlbumTitle = "Golden Hour",
            Artist = "Kacey Musgraves",
            Label = "MCA Nashville",
            Year = 2018,
        },
        new()
        {
            Rank = 271,
            AlbumTitle = "Whats the 411",
            Artist = "Mary J. Blige",
            Label = "Uptown/MCA",
            Year = 1992,
        },
        new()
        {
            Rank = 272,
            AlbumTitle = "White Light White Heat",
            Artist = "The Velvet Underground",
            Label = "Verve",
            Year = 1968,
        },
        new()
        {
            Rank = 273,
            AlbumTitle = "Entertainment!",
            Artist = "Gang of Four",
            Label = "Warner Bros.",
            Year = 1979,
        },
        new()
        {
            Rank = 274,
            AlbumTitle = "Sweetheart of the Rodeo",
            Artist = "The Byrds",
            Label = "Columbia",
            Year = 1968,
        },
        new()
        {
            Rank = 275,
            AlbumTitle = "Curtis",
            Artist = "Curtis Mayfield",
            Label = "Curtom",
            Year = 1970,
        },
        new()
        {
            Rank = 276,
            AlbumTitle = "The Bends",
            Artist = "Radiohead",
            Label = "Capitol",
            Year = 1995,
        },
        new()
        {
            Rank = 277,
            AlbumTitle = "The Diary of Alicia Keys",
            Artist = "Alicia Keys",
            Label = "J Records",
            Year = 2003,
        },
        new()
        {
            Rank = 278,
            AlbumTitle = "Houses of the Holy",
            Artist = "Led Zeppelin",
            Label = "Atlantic",
            Year = 1973,
        },
        new()
        {
            Rank = 279,
            AlbumTitle = "MTV Unplugged in New York",
            Artist = "Nirvana",
            Label = "Geffen",
            Year = 1994,
        },
        new()
        {
            Rank = 280,
            AlbumTitle = "Get Rich or Die Tryin",
            Artist = "50 Cent",
            Label = "Interscope",
            Year = 2002,
        },
        new()
        {
            Rank = 281,
            AlbumTitle = "Nilsson Schmilsson",
            Artist = "Harry Nilsson",
            Label = "RCA",
            Year = 1971,
        },
        new()
        {
            Rank = 282,
            AlbumTitle = "In the Wee Small Hours",
            Artist = "Frank Sinatra",
            Label = "Capitol",
            Year = 1955,
        },
        new()
        {
            Rank = 283,
            AlbumTitle = "Bad Girls",
            Artist = "Donna Summer",
            Label = "Casablanca",
            Year = 1979,
        },
        new()
        {
            Rank = 284,
            AlbumTitle = "Down Every Road 1962-1994",
            Artist = "Merle Haggard",
            Label = "Capitol",
            Year = 1996,
        },
        new()
        {
            Rank = 285,
            AlbumTitle = "Third/Sister Lovers",
            Artist = "Big Star",
            Label = "PVC",
            Year = 1978,
        },
        new()
        {
            Rank = 286,
            AlbumTitle = "Californication",
            Artist = "Red Hot Chili Peppers",
            Label = "Warner Bros.",
            Year = 1999,
        },
        new()
        {
            Rank = 287,
            AlbumTitle = "Mr. Tambourine Man",
            Artist = "The Byrds",
            Label = "Columbia",
            Year = 1965,
        },
        new()
        {
            Rank = 288,
            AlbumTitle = "The Modern Lovers",
            Artist = "The Modern Lovers",
            Label = "Beserkley",
            Year = 1976,
        },
        new()
        {
            Rank = 289,
            AlbumTitle = "Post",
            Artist = "Bjork",
            Label = "Elektra",
            Year = 1995,
        },
        new()
        {
            Rank = 290,
            AlbumTitle = "Speakerboxxx The Love Below",
            Artist = "OutKast",
            Label = "LaFace",
            Year = 2003,
        },
        new()
        {
            Rank = 291,
            AlbumTitle = "The Writings on the Wall",
            Artist = "Destinys Child",
            Label = "Columbia",
            Year = 1999,
        },
        new()
        {
            Rank = 292,
            AlbumTitle = "Van Halen",
            Artist = "Van Halen",
            Label = "Warner Bros.",
            Year = 1978,
        },
        new()
        {
            Rank = 293,
            AlbumTitle = "Last Splash",
            Artist = "The Breeders",
            Label = "Elektra",
            Year = 1993,
        },
        new()
        {
            Rank = 294,
            AlbumTitle = "Weezer The Blue Album",
            Artist = "Weezer",
            Label = "Geffen",
            Year = 1994,
        },
        new()
        {
            Rank = 295,
            AlbumTitle = "Random Access Memories",
            Artist = "Daft Punk",
            Label = "Columbia",
            Year = 2013,
        },
        new()
        {
            Rank = 296,
            AlbumTitle = "Rust Never Sleeps",
            Artist = "Neil Young",
            Label = "Reprise",
            Year = 1979,
        },
        new()
        {
            Rank = 297,
            AlbumTitle = "So",
            Artist = "Peter Gabriel",
            Label = "Geffen",
            Year = 1986,
        },
        new()
        {
            Rank = 298,
            AlbumTitle = "Full Moon Fever",
            Artist = "Tom Petty",
            Label = "MCA",
            Year = 1989,
        },
        new()
        {
            Rank = 299,
            AlbumTitle = "Live at the Regal",
            Artist = "B.B. King",
            Label = "ABC-Paramount",
            Year = 1965,
        },
        new()
        {
            Rank = 300,
            AlbumTitle = "Come on Over",
            Artist = "Shania Twain",
            Label = "Mercury",
            Year = 1997,
        },
        new()
        {
            Rank = 301,
            AlbumTitle = "New York Dolls",
            Artist = "New York Dolls",
            Label = "Mercury",
            Year = 1973,
        },
        new()
        {
            Rank = 302,
            AlbumTitle = "Tonights the Night",
            Artist = "Neil Young",
            Label = "Reprise",
            Year = 1975,
        },
        new()
        {
            Rank = 303,
            AlbumTitle = "The Definitive Collection",
            Artist = "ABBA",
            Label = "Universal",
            Year = 2001,
        },
        new()
        {
            Rank = 304,
            AlbumTitle = "Just As I Am",
            Artist = "Bill Withers",
            Label = "Sussex",
            Year = 1971,
        },
        new()
        {
            Rank = 305,
            AlbumTitle = "Alive!",
            Artist = "Kiss",
            Label = "Casablanca",
            Year = 1975,
        },
        new()
        {
            Rank = 306,
            AlbumTitle = "Im Still in Love with You",
            Artist = "Al Green",
            Label = "Hi",
            Year = 1972,
        },
        new()
        {
            Rank = 307,
            AlbumTitle = "Portrait of a Legend",
            Artist = "Sam Cooke",
            Label = "ABKCO",
            Year = 2003,
        },
        new()
        {
            Rank = 308,
            AlbumTitle = "Here Come the Warm Jets",
            Artist = "Brian Eno",
            Label = "Island",
            Year = 1974,
        },
        new()
        {
            Rank = 309,
            AlbumTitle = "Closer",
            Artist = "Joy Division",
            Label = "Factory",
            Year = 1980,
        },
        new()
        {
            Rank = 310,
            AlbumTitle = "Pink Flag",
            Artist = "Wire",
            Label = "Harvest",
            Year = 1977,
        },
        new()
        {
            Rank = 311,
            AlbumTitle = "On the Beach",
            Artist = "Neil Young",
            Label = "Reprise",
            Year = 1974,
        },
        new()
        {
            Rank = 312,
            AlbumTitle = "A Seat at the Table",
            Artist = "Solange",
            Label = "Saint/Columbia",
            Year = 2016,
        },
        new()
        {
            Rank = 313,
            AlbumTitle = "Stories From the City Stories From the Sea",
            Artist = "PJ Harvey",
            Label = "Island",
            Year = 2000,
        },
        new()
        {
            Rank = 314,
            AlbumTitle = "One in a Million",
            Artist = "Aaliyah",
            Label = "Blackground/Atlantic",
            Year = 1996,
        },
        new()
        {
            Rank = 315,
            AlbumTitle = "El Mal Querer",
            Artist = "Rosalia",
            Label = "Sony",
            Year = 2018,
        },
        new()
        {
            Rank = 316,
            AlbumTitle = "The Who Sell Out",
            Artist = "The Who",
            Label = "Decca",
            Year = 1967,
        },
        new()
        {
            Rank = 317,
            AlbumTitle = "Lady in Satin",
            Artist = "Billie Holiday",
            Label = "Columbia",
            Year = 1958,
        },
        new()
        {
            Rank = 318,
            AlbumTitle = "The Velvet Rope",
            Artist = "Janet Jackson",
            Label = "Virgin",
            Year = 1997,
        },
        new()
        {
            Rank = 319,
            AlbumTitle = "The Stone Roses",
            Artist = "The Stone Roses",
            Label = "Silvertone",
            Year = 1989,
        },
        new()
        {
            Rank = 320,
            AlbumTitle = "Los Angeles",
            Artist = "X",
            Label = "Slash",
            Year = 1980,
        },
        new()
        {
            Rank = 321,
            AlbumTitle = "Norman Fucking Rockwell!",
            Artist = "Lana Del Rey",
            Label = "Polydor/Interscope",
            Year = 2019,
        },
        new()
        {
            Rank = 322,
            AlbumTitle = "From Elvis in Memphis",
            Artist = "Elvis Presley",
            Label = "RCA",
            Year = 1969,
        },
        new()
        {
            Rank = 323,
            AlbumTitle = "Sandinista!",
            Artist = "The Clash",
            Label = "Epic",
            Year = 1980,
        },
        new()
        {
            Rank = 324,
            AlbumTitle = "A Rush of Blood to the Head",
            Artist = "Coldplay",
            Label = "Capitol",
            Year = 2002,
        },
        new()
        {
            Rank = 325,
            AlbumTitle = "All Killer No Filler",
            Artist = "Jerry Lee Lewis",
            Label = "Rhino",
            Year = 1993,
        },
        new()
        {
            Rank = 326,
            AlbumTitle = "Dirty Mind",
            Artist = "Prince",
            Label = "Warner Bros.",
            Year = 1980,
        },
        new()
        {
            Rank = 327,
            AlbumTitle = "Live at Leeds",
            Artist = "The Who",
            Label = "Decca",
            Year = 1970,
        },
        new()
        {
            Rank = 328,
            AlbumTitle = "Modern Vampires of the City",
            Artist = "Vampire Weekend",
            Label = "XL",
            Year = 2013,
        },
        new()
        {
            Rank = 329,
            AlbumTitle = "Endtroducing.....",
            Artist = "DJ Shadow",
            Label = "Mo Wax",
            Year = 1996,
        },
        new()
        {
            Rank = 330,
            AlbumTitle = "Aftermath",
            Artist = "The Rolling Stones",
            Label = "London",
            Year = 1966,
        },
        new()
        {
            Rank = 331,
            AlbumTitle = "Like a Prayer",
            Artist = "Madonna",
            Label = "Sire",
            Year = 1989,
        },
        new()
        {
            Rank = 332,
            AlbumTitle = "Elvis Presley",
            Artist = "Elvis Presley",
            Label = "RCA",
            Year = 1956,
        },
        new()
        {
            Rank = 333,
            AlbumTitle = "Still Bill",
            Artist = "Bill Withers",
            Label = "Sussex",
            Year = 1972,
        },
        new()
        {
            Rank = 334,
            AlbumTitle = "Abraxas",
            Artist = "Santana",
            Label = "Columbia",
            Year = 1970,
        },
        new()
        {
            Rank = 335,
            AlbumTitle = "The Basement Tapes",
            Artist = "Bob Dylan and the Band",
            Label = "Columbia",
            Year = 1975,
        },
        new()
        {
            Rank = 336,
            AlbumTitle = "Avalon",
            Artist = "Roxy Music",
            Label = "E.G./Warner Bros.",
            Year = 1982,
        },
        new()
        {
            Rank = 337,
            AlbumTitle = "John Wesley Harding",
            Artist = "Bob Dylan",
            Label = "Columbia",
            Year = 1967,
        },
        new()
        {
            Rank = 338,
            AlbumTitle = "Another Green World",
            Artist = "Brian Eno",
            Label = "Island",
            Year = 1975,
        },
        new()
        {
            Rank = 339,
            AlbumTitle = "Rhythm Nation 1814",
            Artist = "Janet Jackson",
            Label = "A and M",
            Year = 1989,
        },
        new()
        {
            Rank = 340,
            AlbumTitle = "Doggystyle",
            Artist = "Snoop Doggy Dogg",
            Label = "Death Row/Interscope",
            Year = 1993,
        },
        new()
        {
            Rank = 341,
            AlbumTitle = "Siamese Dream",
            Artist = "The Smashing Pumpkins",
            Label = "Virgin",
            Year = 1993,
        },
        new()
        {
            Rank = 342,
            AlbumTitle = "Let It Be",
            Artist = "The Beatles",
            Label = "Apple",
            Year = 1970,
        },
        new()
        {
            Rank = 343,
            AlbumTitle = "Greatest Hits",
            Artist = "Sly and the Family Stone",
            Label = "Epic",
            Year = 1970,
        },
        new()
        {
            Rank = 344,
            AlbumTitle = "Funky Kingston",
            Artist = "Toots and the Maytals",
            Label = "Island",
            Year = 1973,
        },
        new()
        {
            Rank = 345,
            AlbumTitle = "The Wild the Innocent and the E Street Shuffle",
            Artist = "Bruce Springsteen",
            Label = "Columbia",
            Year = 1973,
        },
        new()
        {
            Rank = 346,
            AlbumTitle = "AM",
            Artist = "Arctic Monkeys",
            Label = "Domino",
            Year = 2013,
        },
        new()
        {
            Rank = 347,
            AlbumTitle = "Liquid Swords",
            Artist = "GZA",
            Label = "Geffen",
            Year = 1995,
        },
        new()
        {
            Rank = 348,
            AlbumTitle = "Time The Revelator",
            Artist = "Gillian Welch",
            Label = "Acony",
            Year = 2001,
        },
        new()
        {
            Rank = 349,
            AlbumTitle = "Kick Out the Jams",
            Artist = "MC5",
            Label = "Elektra",
            Year = 1969,
        },
        new()
        {
            Rank = 350,
            AlbumTitle = "Music of My Mind",
            Artist = "Stevie Wonder",
            Label = "Tamla/Motown",
            Year = 1972,
        },
        new()
        {
            Rank = 351,
            AlbumTitle = "For Your Pleasure",
            Artist = "Roxy Music",
            Label = "Warner Bros.",
            Year = 1973,
        },
        new()
        {
            Rank = 352,
            AlbumTitle = "The Slim Shady LP",
            Artist = "Eminem",
            Label = "Interscope",
            Year = 1999,
        },
        new()
        {
            Rank = 353,
            AlbumTitle = "The Cars",
            Artist = "The Cars",
            Label = "Elektra",
            Year = 1978,
        },
        new()
        {
            Rank = 354,
            AlbumTitle = "Germfree Adolescents",
            Artist = "X-Ray Spex",
            Label = "EMI",
            Year = 1978,
        },
        new()
        {
            Rank = 355,
            AlbumTitle = "Black Sabbath",
            Artist = "Black Sabbath",
            Label = "Warner Bros.",
            Year = 1970,
        },
        new()
        {
            Rank = 356,
            AlbumTitle = "Gris-Gris",
            Artist = "Dr. John",
            Label = "Atco",
            Year = 1968,
        },
        new()
        {
            Rank = 357,
            AlbumTitle = "Rain Dogs",
            Artist = "Tom Waits",
            Label = "Island",
            Year = 1985,
        },
        new()
        {
            Rank = 358,
            AlbumTitle = "Goo",
            Artist = "Sonic Youth",
            Label = "Geffen",
            Year = 1990,
        },
        new()
        {
            Rank = 359,
            AlbumTitle = "Radio City",
            Artist = "Big Star",
            Label = "Ardent",
            Year = 1974,
        },
        new()
        {
            Rank = 360,
            AlbumTitle = "One Nation Under a Groove",
            Artist = "Funkadelic",
            Label = "Warner Bros.",
            Year = 1978,
        },
        new()
        {
            Rank = 361,
            AlbumTitle = "The Black Parade",
            Artist = "My Chemical Romance",
            Label = "Reprise",
            Year = 2006,
        },
        new()
        {
            Rank = 362,
            AlbumTitle = "Never Too Much",
            Artist = "Luther Vandross",
            Label = "Epic",
            Year = 1981,
        },
        new()
        {
            Rank = 363,
            AlbumTitle = "The Mothership Connection",
            Artist = "Parliament",
            Label = "Casablanca",
            Year = 1975,
        },
        new()
        {
            Rank = 364,
            AlbumTitle = "More Songs About Buildings and Food",
            Artist = "Talking Heads",
            Label = "Sire",
            Year = 1978,
        },
        new()
        {
            Rank = 365,
            AlbumTitle = "Madvillainy",
            Artist = "Madvillain",
            Label = "Stones Throw",
            Year = 2004,
        },
        new()
        {
            Rank = 366,
            AlbumTitle = "Rocks",
            Artist = "Aerosmith",
            Label = "Columbia",
            Year = 1976,
        },
        new()
        {
            Rank = 367,
            AlbumTitle = "If Youre Reading This Its Too Late",
            Artist = "Drake",
            Label = "Cash Money",
            Year = 2015,
        },
        new()
        {
            Rank = 368,
            AlbumTitle = "All Things Must Pass",
            Artist = "George Harrison",
            Label = "Apple",
            Year = 1970,
        },
        new()
        {
            Rank = 369,
            AlbumTitle = "The Infamous",
            Artist = "Mobb Deep",
            Label = "Loud",
            Year = 1995,
        },
        new()
        {
            Rank = 370,
            AlbumTitle = "Tha Carter II",
            Artist = "Lil Wayne",
            Label = "Cash Money/Universal",
            Year = 2005,
        },
        new()
        {
            Rank = 371,
            AlbumTitle = "Anthology",
            Artist = "The Temptations",
            Label = "Tamla/Motown",
            Year = 1973,
        },
        new()
        {
            Rank = 372,
            AlbumTitle = "Cheap Thrills",
            Artist = "Big Brother and the Holding Company",
            Label = "Columbia",
            Year = 1968,
        },
        new()
        {
            Rank = 373,
            AlbumTitle = "Hot Buttered Soul",
            Artist = "Isaac Hayes",
            Label = "Enterprise",
            Year = 1969,
        },
        new()
        {
            Rank = 374,
            AlbumTitle = "King of the Delta Blues Singers",
            Artist = "Robert Johnson",
            Label = "Columbia",
            Year = 1961,
        },
        new()
        {
            Rank = 375,
            AlbumTitle = "Dookie",
            Artist = "Green Day",
            Label = "Reprise",
            Year = 1994,
        },
        new()
        {
            Rank = 376,
            AlbumTitle = "Talking Heads 77",
            Artist = "Talking Heads",
            Label = "Sire",
            Year = 1977,
        },
        new()
        {
            Rank = 377,
            AlbumTitle = "Tres Hombres",
            Artist = "ZZ Top",
            Label = "London",
            Year = 1973,
        },
        new()
        {
            Rank = 378,
            AlbumTitle = "Mule Variations",
            Artist = "Tom Waits",
            Label = "Anti-",
            Year = 1999,
        },
        new()
        {
            Rank = 379,
            AlbumTitle = "Surrealistic Pillow",
            Artist = "Jefferson Airplane",
            Label = "RCA",
            Year = 1967,
        },
        new()
        {
            Rank = 380,
            AlbumTitle = "Odelay",
            Artist = "Beck",
            Label = "DGC",
            Year = 1996,
        },
        new()
        {
            Rank = 381,
            AlbumTitle = "Lift Your Skinny Fists Like Antennas to Heaven",
            Artist = "Godspeed You! Black Emperor",
            Label = "Constellation",
            Year = 2000,
        },
        new()
        {
            Rank = 382,
            AlbumTitle = "Aqualung",
            Artist = "Jethro Tull",
            Label = "Chrysalis",
            Year = 1971,
        },
        new()
        {
            Rank = 383,
            AlbumTitle = "The Koln Concert",
            Artist = "Keith Jarrett",
            Label = "ECM",
            Year = 1975,
        },
        new()
        {
            Rank = 384,
            AlbumTitle = "I Do Not Want What I Havent Got",
            Artist = "Sinead OConnor",
            Label = "Ensign/Chrysalis",
            Year = 1990,
        },
        new()
        {
            Rank = 385,
            AlbumTitle = "In the Court of the Crimson King",
            Artist = "King Crimson",
            Label = "Atlantic",
            Year = 1969,
        },
        new()
        {
            Rank = 386,
            AlbumTitle = "My Aim Is True",
            Artist = "Elvis Costello",
            Label = "Stiff",
            Year = 1977,
        },
        new()
        {
            Rank = 387,
            AlbumTitle = "Ladies of the Canyon",
            Artist = "Joni Mitchell",
            Label = "Reprise",
            Year = 1970,
        },
        new()
        {
            Rank = 388,
            AlbumTitle = "Hatful of Hollow",
            Artist = "The Smiths",
            Label = "Rough Trade",
            Year = 1984,
        },
        new()
        {
            Rank = 389,
            AlbumTitle = "I Am a Bird Now",
            Artist = "Antony and the Johnsons",
            Label = "Secretly Canadian",
            Year = 2005,
        },
        new()
        {
            Rank = 390,
            AlbumTitle = "Screamadelica",
            Artist = "Primal Scream",
            Label = "Creation",
            Year = 1991,
        },
        new()
        {
            Rank = 391,
            AlbumTitle = "Songs in A Minor",
            Artist = "Alicia Keys",
            Label = "J Records",
            Year = 2001,
        },
        new()
        {
            Rank = 392,
            AlbumTitle = "Funeral",
            Artist = "Arcade Fire",
            Label = "Merge",
            Year = 2004,
        },
        new()
        {
            Rank = 393,
            AlbumTitle = "Tago Mago",
            Artist = "Can",
            Label = "United Artists",
            Year = 1971,
        },
        new()
        {
            Rank = 394,
            AlbumTitle = "Superunknown",
            Artist = "Soundgarden",
            Label = "A and M",
            Year = 1994,
        },
        new()
        {
            Rank = 395,
            AlbumTitle = "Village Green Preservation Society",
            Artist = "The Kinks",
            Label = "Reprise",
            Year = 1968,
        },
        new()
        {
            Rank = 396,
            AlbumTitle = "For Emma Forever Ago",
            Artist = "Bon Iver",
            Label = "Jagjaguwar",
            Year = 2008,
        },
        new()
        {
            Rank = 397,
            AlbumTitle = "We're Only in It for the Money",
            Artist = "Frank Zappa",
            Label = "Verve",
            Year = 1968,
        },
        new()
        {
            Rank = 398,
            AlbumTitle = "Elephant",
            Artist = "The White Stripes",
            Label = "Third Man/V2",
            Year = 2003,
        },
        new()
        {
            Rank = 399,
            AlbumTitle = "White Blood Cells",
            Artist = "The White Stripes",
            Label = "Sympathy for the Record Industry",
            Year = 2001,
        },
        new()
        {
            Rank = 400,
            AlbumTitle = "Merriweather Post Pavilion",
            Artist = "Animal Collective",
            Label = "Domino",
            Year = 2009,
        },
        new()
        {
            Rank = 401,
            AlbumTitle = "In Rainbows",
            Artist = "Radiohead",
            Label = "Self-released",
            Year = 2007,
        },
        new()
        {
            Rank = 402,
            AlbumTitle = "Moon Safari",
            Artist = "Air",
            Label = "Source",
            Year = 1998,
        },
        new()
        {
            Rank = 403,
            AlbumTitle = "Vespertine",
            Artist = "Bjork",
            Label = "Elektra",
            Year = 2001,
        },
        new()
        {
            Rank = 404,
            AlbumTitle = "Debut",
            Artist = "Bjork",
            Label = "One Little Indian",
            Year = 1993,
        },
        new()
        {
            Rank = 405,
            AlbumTitle = "Cross",
            Artist = "Justice",
            Label = "Ed Banger/Because",
            Year = 2007,
        },
        new()
        {
            Rank = 406,
            AlbumTitle = "Since I Left You",
            Artist = "The Avalanches",
            Label = "Modular",
            Year = 2000,
        },
        new()
        {
            Rank = 407,
            AlbumTitle = "Turn on the Bright Lights",
            Artist = "Interpol",
            Label = "Matador",
            Year = 2002,
        },
        new()
        {
            Rank = 408,
            AlbumTitle = "Franz Ferdinand",
            Artist = "Franz Ferdinand",
            Label = "Domino",
            Year = 2004,
        },
        new()
        {
            Rank = 409,
            AlbumTitle = "Hot Fuss",
            Artist = "The Killers",
            Label = "Island",
            Year = 2004,
        },
        new()
        {
            Rank = 410,
            AlbumTitle = "Neon Bible",
            Artist = "Arcade Fire",
            Label = "Merge",
            Year = 2007,
        },
        new()
        {
            Rank = 411,
            AlbumTitle = "The Suburbs",
            Artist = "Arcade Fire",
            Label = "Merge",
            Year = 2010,
        },
        new()
        {
            Rank = 412,
            AlbumTitle = "Whatever People Say I Am Thats What Im Not",
            Artist = "Arctic Monkeys",
            Label = "Domino",
            Year = 2006,
        },
        new()
        {
            Rank = 413,
            AlbumTitle = "Favourite Worst Nightmare",
            Artist = "Arctic Monkeys",
            Label = "Domino",
            Year = 2007,
        },
        new()
        {
            Rank = 414,
            AlbumTitle = "Humbug",
            Artist = "Arctic Monkeys",
            Label = "Domino",
            Year = 2009,
        },
        new()
        {
            Rank = 415,
            AlbumTitle = "22 A Million",
            Artist = "Bon Iver",
            Label = "Jagjaguwar",
            Year = 2016,
        },
        new()
        {
            Rank = 416,
            AlbumTitle = "Bon Iver Bon Iver",
            Artist = "Bon Iver",
            Label = "Jagjaguwar",
            Year = 2011,
        },
        new()
        {
            Rank = 417,
            AlbumTitle = "Ctrl",
            Artist = "SZA",
            Label = "TDE/RCA",
            Year = 2017,
        },
        new()
        {
            Rank = 418,
            AlbumTitle = "SOS",
            Artist = "SZA",
            Label = "TDE/RCA",
            Year = 2022,
        },
        new()
        {
            Rank = 419,
            AlbumTitle = "When We All Fall Asleep Where Do We Go",
            Artist = "Billie Eilish",
            Label = "Interscope",
            Year = 2019,
        },
        new()
        {
            Rank = 420,
            AlbumTitle = "Happier Than Ever",
            Artist = "Billie Eilish",
            Label = "Interscope",
            Year = 2021,
        },
        new()
        {
            Rank = 421,
            AlbumTitle = "Mr. Morale and the Big Steppers",
            Artist = "Kendrick Lamar",
            Label = "TDE/Aftermath",
            Year = 2022,
        },
        new()
        {
            Rank = 422,
            AlbumTitle = "GNX",
            Artist = "Kendrick Lamar",
            Label = "pgLang/Interscope",
            Year = 2024,
        },
        new()
        {
            Rank = 423,
            AlbumTitle = "folklore",
            Artist = "Taylor Swift",
            Label = "Republic",
            Year = 2020,
        },
        new()
        {
            Rank = 424,
            AlbumTitle = "evermore",
            Artist = "Taylor Swift",
            Label = "Republic",
            Year = 2020,
        },
        new()
        {
            Rank = 425,
            AlbumTitle = "Midnights",
            Artist = "Taylor Swift",
            Label = "Republic",
            Year = 2022,
        },
        new()
        {
            Rank = 426,
            AlbumTitle = "1989",
            Artist = "Taylor Swift",
            Label = "Big Machine",
            Year = 2014,
        },
        new()
        {
            Rank = 427,
            AlbumTitle = "reputation",
            Artist = "Taylor Swift",
            Label = "Big Machine",
            Year = 2017,
        },
        new()
        {
            Rank = 428,
            AlbumTitle = "After Hours",
            Artist = "The Weeknd",
            Label = "XO/Republic",
            Year = 2020,
        },
        new()
        {
            Rank = 429,
            AlbumTitle = "Starboy",
            Artist = "The Weeknd",
            Label = "XO/Republic",
            Year = 2016,
        },
        new()
        {
            Rank = 430,
            AlbumTitle = "Beauty Behind the Madness",
            Artist = "The Weeknd",
            Label = "XO/Republic",
            Year = 2015,
        },
        new()
        {
            Rank = 431,
            AlbumTitle = "Renaissance",
            Artist = "Beyonce",
            Label = "Parkwood/Columbia",
            Year = 2022,
        },
        new()
        {
            Rank = 432,
            AlbumTitle = "Cowboy Carter",
            Artist = "Beyonce",
            Label = "Parkwood/Columbia",
            Year = 2024,
        },
        new()
        {
            Rank = 433,
            AlbumTitle = "30",
            Artist = "Adele",
            Label = "Columbia",
            Year = 2021,
        },
        new()
        {
            Rank = 434,
            AlbumTitle = "Fine Line",
            Artist = "Harry Styles",
            Label = "Columbia",
            Year = 2019,
        },
        new()
        {
            Rank = 435,
            AlbumTitle = "Harrys House",
            Artist = "Harry Styles",
            Label = "Columbia",
            Year = 2022,
        },
        new()
        {
            Rank = 436,
            AlbumTitle = "Punisher",
            Artist = "Phoebe Bridgers",
            Label = "Dead Oceans",
            Year = 2020,
        },
        new()
        {
            Rank = 437,
            AlbumTitle = "Fetch the Bolt Cutters",
            Artist = "Fiona Apple",
            Label = "Epic",
            Year = 2020,
        },
        new()
        {
            Rank = 438,
            AlbumTitle = "A Charlie Brown Christmas",
            Artist = "Vince Guaraldi Trio",
            Label = "Fantasy",
            Year = 1965,
        },
        new()
        {
            Rank = 439,
            AlbumTitle = "Tago Mago",
            Artist = "Can",
            Label = "United Artists",
            Year = 1971,
        },
        new()
        {
            Rank = 440,
            AlbumTitle = "The Koln Concert",
            Artist = "Keith Jarrett",
            Label = "ECM",
            Year = 1975,
        },
        new()
        {
            Rank = 441,
            AlbumTitle = "Fresh",
            Artist = "Sly and the Family Stone",
            Label = "Epic",
            Year = 1973,
        },
        new()
        {
            Rank = 442,
            AlbumTitle = "De-loused in the Comatorium",
            Artist = "The Mars Volta",
            Label = "Gold Standard Laboratories",
            Year = 2003,
        },
        new()
        {
            Rank = 443,
            AlbumTitle = "Person Pitch",
            Artist = "Panda Bear",
            Label = "Paw Tracks",
            Year = 2007,
        },
        new()
        {
            Rank = 444,
            AlbumTitle = "Hail to the Thief",
            Artist = "Radiohead",
            Label = "Parlophone",
            Year = 2003,
        },
        new()
        {
            Rank = 445,
            AlbumTitle = "Room on Fire",
            Artist = "The Strokes",
            Label = "RCA",
            Year = 2003,
        },
        new()
        {
            Rank = 446,
            AlbumTitle = "Sam's Town",
            Artist = "The Killers",
            Label = "Island",
            Year = 2006,
        },
        new()
        {
            Rank = 447,
            AlbumTitle = "Suck It and See",
            Artist = "Arctic Monkeys",
            Label = "Domino",
            Year = 2011,
        },
        new()
        {
            Rank = 448,
            AlbumTitle = "Tranquility Base Hotel and Casino",
            Artist = "Arctic Monkeys",
            Label = "Domino",
            Year = 2018,
        },
        new()
        {
            Rank = 449,
            AlbumTitle = "i i",
            Artist = "Bon Iver",
            Label = "Jagjaguwar",
            Year = 2019,
        },
        new()
        {
            Rank = 450,
            AlbumTitle = "thank u next",
            Artist = "Ariana Grande",
            Label = "Republic",
            Year = 2019,
        },
        new()
        {
            Rank = 451,
            AlbumTitle = "Positions",
            Artist = "Ariana Grande",
            Label = "Republic",
            Year = 2020,
        },
        new()
        {
            Rank = 452,
            AlbumTitle = "Sweetener",
            Artist = "Ariana Grande",
            Label = "Republic",
            Year = 2018,
        },
        new()
        {
            Rank = 453,
            AlbumTitle = "Certified Lover Boy",
            Artist = "Drake",
            Label = "Young Money/Cash Money",
            Year = 2021,
        },
        new()
        {
            Rank = 454,
            AlbumTitle = "Scorpion",
            Artist = "Drake",
            Label = "Young Money/Cash Money",
            Year = 2018,
        },
        new()
        {
            Rank = 455,
            AlbumTitle = "25",
            Artist = "Adele",
            Label = "Columbia",
            Year = 2015,
        },
        new()
        {
            Rank = 456,
            AlbumTitle = "Divide",
            Artist = "Ed Sheeran",
            Label = "Asylum/Atlantic",
            Year = 2017,
        },
        new()
        {
            Rank = 457,
            AlbumTitle = "Multiply",
            Artist = "Ed Sheeran",
            Label = "Asylum/Atlantic",
            Year = 2014,
        },
        new()
        {
            Rank = 458,
            AlbumTitle = "Stranger in the Alps",
            Artist = "Phoebe Bridgers",
            Label = "Dead Oceans",
            Year = 2017,
        },
        new()
        {
            Rank = 459,
            AlbumTitle = "Sometimes I Sit and Think and Sometimes I Just Sit",
            Artist = "Courtney Barnett",
            Label = "Mom and Pop",
            Year = 2015,
        },
        new()
        {
            Rank = 460,
            AlbumTitle = "Tell Me How You Really Feel",
            Artist = "Courtney Barnett",
            Label = "Mom and Pop",
            Year = 2018,
        },
        new()
        {
            Rank = 461,
            AlbumTitle = "A Seat at the Table",
            Artist = "Solange",
            Label = "Saint/Columbia",
            Year = 2016,
        },
        new()
        {
            Rank = 462,
            AlbumTitle = "When the Pawn",
            Artist = "Fiona Apple",
            Label = "Epic",
            Year = 1999,
        },
        new()
        {
            Rank = 463,
            AlbumTitle = "Surfer Rosa",
            Artist = "Pixies",
            Label = "4AD",
            Year = 1988,
        },
        new()
        {
            Rank = 464,
            AlbumTitle = "Bossanova",
            Artist = "Pixies",
            Label = "4AD",
            Year = 1990,
        },
        new()
        {
            Rank = 465,
            AlbumTitle = "Trompe le Monde",
            Artist = "Pixies",
            Label = "4AD",
            Year = 1991,
        },
        new()
        {
            Rank = 466,
            AlbumTitle = "Debut",
            Artist = "Bjork",
            Label = "One Little Indian",
            Year = 1993,
        },
        new()
        {
            Rank = 467,
            AlbumTitle = "Medulla",
            Artist = "Bjork",
            Label = "Elektra",
            Year = 2004,
        },
        new()
        {
            Rank = 468,
            AlbumTitle = "Since I Left You",
            Artist = "The Avalanches",
            Label = "Modular",
            Year = 2000,
        },
        new()
        {
            Rank = 469,
            AlbumTitle = "Let England Shake",
            Artist = "PJ Harvey",
            Label = "Island",
            Year = 2011,
        },
        new()
        {
            Rank = 470,
            AlbumTitle = "To Bring You My Love",
            Artist = "PJ Harvey",
            Label = "Island",
            Year = 1995,
        },
        new()
        {
            Rank = 471,
            AlbumTitle = "The Boatman's Call",
            Artist = "Nick Cave and the Bad Seeds",
            Label = "Mute",
            Year = 1997,
        },
        new()
        {
            Rank = 472,
            AlbumTitle = "Murder Ballads",
            Artist = "Nick Cave and the Bad Seeds",
            Label = "Mute",
            Year = 1996,
        },
        new()
        {
            Rank = 473,
            AlbumTitle = "Push the Sky Away",
            Artist = "Nick Cave and the Bad Seeds",
            Label = "Bad Seed Ltd",
            Year = 2013,
        },
        new()
        {
            Rank = 474,
            AlbumTitle = "Skeleton Tree",
            Artist = "Nick Cave and the Bad Seeds",
            Label = "Bad Seed Ltd",
            Year = 2016,
        },
        new()
        {
            Rank = 475,
            AlbumTitle = "Ghosteen",
            Artist = "Nick Cave and the Bad Seeds",
            Label = "Bad Seed Ltd",
            Year = 2019,
        },
        new()
        {
            Rank = 476,
            AlbumTitle = "Carrie and Lowell",
            Artist = "Sufjan Stevens",
            Label = "Asthmatic Kitty",
            Year = 2015,
        },
        new()
        {
            Rank = 477,
            AlbumTitle = "Illinois",
            Artist = "Sufjan Stevens",
            Label = "Asthmatic Kitty",
            Year = 2005,
        },
        new()
        {
            Rank = 478,
            AlbumTitle = "Michigan",
            Artist = "Sufjan Stevens",
            Label = "Asthmatic Kitty",
            Year = 2003,
        },
        new()
        {
            Rank = 479,
            AlbumTitle = "Helplessness Blues",
            Artist = "Fleet Foxes",
            Label = "Sub Pop",
            Year = 2011,
        },
        new()
        {
            Rank = 480,
            AlbumTitle = "Fleet Foxes",
            Artist = "Fleet Foxes",
            Label = "Sub Pop",
            Year = 2008,
        },
        new()
        {
            Rank = 481,
            AlbumTitle = "Illinois",
            Artist = "Sufjan Stevens",
            Label = "Asthmatic Kitty",
            Year = 2005,
        },
        new()
        {
            Rank = 482,
            AlbumTitle = "Come Away with Me",
            Artist = "Norah Jones",
            Label = "Blue Note",
            Year = 2002,
        },
        new()
        {
            Rank = 483,
            AlbumTitle = "Feels Like Home",
            Artist = "Norah Jones",
            Label = "Blue Note",
            Year = 2004,
        },
        new()
        {
            Rank = 484,
            AlbumTitle = "Back to Bedlam",
            Artist = "James Blunt",
            Label = "Atlantic",
            Year = 2004,
        },
        new()
        {
            Rank = 485,
            AlbumTitle = "Crazy in Love",
            Artist = "Beyonce",
            Label = "Columbia",
            Year = 2003,
        },
        new()
        {
            Rank = 486,
            AlbumTitle = "Dangerously in Love",
            Artist = "Beyonce",
            Label = "Columbia",
            Year = 2003,
        },
        new()
        {
            Rank = 487,
            AlbumTitle = "B Day",
            Artist = "Beyonce",
            Label = "Columbia",
            Year = 2006,
        },
        new()
        {
            Rank = 488,
            AlbumTitle = "I Am Sasha Fierce",
            Artist = "Beyonce",
            Label = "Columbia",
            Year = 2008,
        },
        new()
        {
            Rank = 489,
            AlbumTitle = "4",
            Artist = "Beyonce",
            Label = "Columbia",
            Year = 2011,
        },
        new()
        {
            Rank = 490,
            AlbumTitle = "Rated R",
            Artist = "Rihanna",
            Label = "Def Jam",
            Year = 2009,
        },
        new()
        {
            Rank = 491,
            AlbumTitle = "Loud",
            Artist = "Rihanna",
            Label = "Def Jam",
            Year = 2010,
        },
        new()
        {
            Rank = 492,
            AlbumTitle = "Talk That Talk",
            Artist = "Rihanna",
            Label = "Def Jam",
            Year = 2011,
        },
        new()
        {
            Rank = 493,
            AlbumTitle = "Unapologetic",
            Artist = "Rihanna",
            Label = "Def Jam",
            Year = 2012,
        },
        new()
        {
            Rank = 494,
            AlbumTitle = "Views",
            Artist = "Drake",
            Label = "Young Money/Cash Money",
            Year = 2016,
        },
        new()
        {
            Rank = 495,
            AlbumTitle = "Nothing Was the Same",
            Artist = "Drake",
            Label = "Young Money/Cash Money",
            Year = 2013,
        },
        new()
        {
            Rank = 496,
            AlbumTitle = "Thank Me Later",
            Artist = "Drake",
            Label = "Young Money/Cash Money",
            Year = 2010,
        },
        new()
        {
            Rank = 497,
            AlbumTitle = "So Far Gone",
            Artist = "Drake",
            Label = "Young Money/Cash Money",
            Year = 2009,
        },
        new()
        {
            Rank = 498,
            AlbumTitle = "Blonde on Blonde",
            Artist = "Bob Dylan",
            Label = "Columbia",
            Year = 1966,
        },
        new()
        {
            Rank = 499,
            AlbumTitle = "Music Has the Right to Children",
            Artist = "Boards of Canada",
            Label = "Warp",
            Year = 1998,
        },
        new()
        {
            Rank = 500,
            AlbumTitle = "Geogaddi",
            Artist = "Boards of Canada",
            Label = "Warp",
            Year = 2002,
        },
    ];

    public Album GetRandom()
    {
        var idx = Random.Shared.Next(_albums.Count);
        return _albums[idx];
    }

    public List<Album> GetAll() => _albums;

    public List<int> GetDecades() =>
        _albums.Select(a => a.Year / 10 * 10).Distinct().OrderBy(d => d).ToList();

    public List<Album> GetByDecade(int decade) =>
        _albums.Where(a => a.Year / 10 * 10 == decade).ToList();
}
