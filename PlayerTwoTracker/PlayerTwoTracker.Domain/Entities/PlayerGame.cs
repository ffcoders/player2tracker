namespace PlayerTwoTracker.Domain;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// Represents the association between a player and a game in the PlayerTwoTracker application.
/// </summary>
public class PlayerGame 
{
    /// <summary>
    /// Gets or sets the unique identifier for the player associated with the game.
    /// </summary>
    public Guid PlayerId { get; set; }
    /// <summary>
    /// Gets or sets the player associated with the game.
    /// </summary>
    public Player Player { get; set; } = null!;
    /// <summary>
    /// Gets or sets the unique identifier for the game associated with the player.
    /// </summary>
    public Guid GameId { get; set; }
    /// <summary>
    /// Gets or sets the game associated with the player.
    /// </summary>
    public Game Game { get; set; } = null!;
    /// <summary>
    /// Gets or sets the unique identifier for the platform on which the game is played.
    /// </summary>
    public Guid PlatformId { get; set; }
    /// <summary>
    /// Gets or sets the platform on which the game is played.
    /// </summary>
    public Platform Platform { get; set; } = null!;
    /// <summary>
    /// Gets or sets the progress of the player in the game, represented as a percentage (0-100).
    /// </summary>
    [Range(0, 100, ErrorMessage = "Progress must be between 0 and 100.")]
    public int Progress { get; set; } = 0;
    /// <summary>
    /// Gets or sets the status of the game for the player.
    /// </summary>
    public GameStatus Status { get; set; } = GameStatus.None;
}
