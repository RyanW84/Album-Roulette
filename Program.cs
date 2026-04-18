using AlbumRoulette.Data;
using AlbumRoulette.Data.Repositories;
using AlbumRoulette.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the dependency injection container
builder.Services.AddControllersWithViews();

// Configure database context
builder.Services.AddDbContext<AlbumRouletteDbContext>(options =>
    options.UseSqlite("Data Source=AlbumRoulette.db"));

// Register application services (following dependency injection and SOLID principles)
builder.Services.AddScoped<IAlbumRepository, AlbumRepository>();
builder.Services.AddScoped<IMusicMetadataService, MusicBrainzService>();
builder.Services.AddScoped<AlbumService>();
builder.Services.AddScoped<DbInitializerService>();

// Register HTTP client for external API calls
builder.Services.AddHttpClient<MusicBrainzService>();

var app = builder.Build();

// Initialize database on startup
using (var scope = app.Services.CreateScope())
{
    var initializer = scope.ServiceProvider.GetRequiredService<DbInitializerService>();
    await initializer.InitializeAsync();
}

app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//
//
//
//