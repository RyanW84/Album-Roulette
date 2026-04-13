using AlbumRoulette.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumRoulette.Data;

public class AlbumRouletteDbContext(DbContextOptions<AlbumRouletteDbContext> options) : DbContext(options)
{
    public DbSet<Album> Albums => Set<Album>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Album>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Rank).IsRequired();

            entity.Property(e => e.AlbumTitle).IsRequired().HasMaxLength(255);

            entity.Property(e => e.Artist).IsRequired().HasMaxLength(255);

            entity.Property(e => e.Label).HasMaxLength(255);

            entity.Property(e => e.Year).IsRequired();

            entity.Property(e => e.CoverArtUrl).HasMaxLength(500);

            entity.Property(e => e.MusicBrainzId).HasMaxLength(100);

            entity.Property(e => e.Genre).HasMaxLength(255);

            entity.Property(e => e.LastEnrichedAt).HasDefaultValue(DateTime.MinValue);

            entity.Property(e => e.IsEnriched).HasDefaultValue(false);

            // Create index on Rank for quick lookups
            entity.HasIndex(e => e.Rank).IsUnique();

            // Create index on Year for filtering
            entity.HasIndex(e => e.Year);
        });
    }
}
