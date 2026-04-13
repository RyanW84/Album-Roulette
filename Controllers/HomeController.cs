using AlbumRoulette.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlbumRoulette.Controllers;

/// <summary>
/// Main controller for the Album Roulette application.
/// Handles HTTP requests and delegates business logic to services.
/// Follows the Single Responsibility Principle by focusing only on request handling.
/// </summary>
public class HomeController : Controller
{
    private readonly AlbumService _albumService;
    private readonly ILogger<HomeController> _logger;

    public HomeController(AlbumService albumService, ILogger<HomeController> logger)
    {
        _albumService = albumService ?? throw new ArgumentNullException(nameof(albumService));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    /// <summary>
    /// Renders the home page.
    /// </summary>
    public IActionResult Index()
    {
        return View();
    }

    /// <summary>
    /// Renders the spin page with a random album.
    /// </summary>
    [HttpGet("/spin")]
    public async Task<IActionResult> Spin()
    {
        try
        {
            var album = await _albumService.GetRandomAlbumAsync();
            if (album == null)
            {
                _logger.LogWarning("No album available for spin");
                return RedirectToAction("Index");
            }
            return View("Album", album);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error spinning album");
            return RedirectToAction("Index");
        }
    }

    /// <summary>
    /// API endpoint to get a random album excluding specified ranks.
    /// </summary>
    [HttpPost("/api/spin")]
    [Produces("application/json")]
    public async Task<IActionResult> GetRandomAlbum([FromBody] List<int> chosenRanks)
    {
        try
        {
            if (chosenRanks == null)
                chosenRanks = new List<int>();

            var album = await _albumService.GetRandomAlbumAsync(chosenRanks);

            if (album == null)
            {
                _logger.LogInformation("All albums have been chosen");
                return BadRequest(new { message = "All albums have been chosen" });
            }

            return Ok(album);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in GetRandomAlbum API");
            return StatusCode(500, new { message = "Internal server error" });
        }
    }

    /// <summary>
    /// Renders the browse all albums page.
    /// </summary>
    [HttpGet("/browse")]
    public async Task<IActionResult> Browse()
    {
        try
        {
            var albums = await _albumService.GetAllAlbumsAsync();
            return View(albums);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error loading browse page");
            return StatusCode(500, "Error loading albums");
        }
    }
}
