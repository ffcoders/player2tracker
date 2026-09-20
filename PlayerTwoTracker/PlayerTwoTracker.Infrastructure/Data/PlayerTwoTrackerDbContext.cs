namespace PlayerTwoTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using PlayerTwoTracker.Domain;

public class PlayerTwoTrackerDbContext : DbContext
{
    public PlayerTwoTrackerDbContext(DbContextOptions<PlayerTwoTrackerDbContext> options) : base(options)
    {
    }

    public DbSet<Game> Games { get; set; } = null!;
    public DbSet<Platform> Platforms { get; set; } = null!;
    public DbSet<Genre> Genres { get; set; } = null!;
    public DbSet<Player> Players { get; set; } = null!;
    public DbSet<PlayerGame> PlayerGames { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Game>()
            .HasMany(g => g.Platforms)
            .WithMany();

        modelBuilder.Entity<PlayerGame>()
            .HasKey(pg => new { pg.PlayerId, pg.GameId, pg.PlatformId });

        modelBuilder.Entity<PlayerGame>()
            .Property(pg => pg.Status)
            .HasConversion<string>();

        modelBuilder.Entity<PlayerGame>()
            .HasOne(pg => pg.Game)
            .WithMany(g => g.PlayerGames)
            .HasForeignKey(pg => pg.GameId);

        modelBuilder.Entity<PlayerGame>()
            .HasOne(pg => pg.Player)
            .WithMany(p => p.PlayerGames)
            .HasForeignKey(pg => pg.PlayerId);

    }
}
