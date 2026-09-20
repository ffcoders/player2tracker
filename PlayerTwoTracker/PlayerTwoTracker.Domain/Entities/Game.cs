namespace PlayerTwoTracker.Domain;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

/// <summary>
/// Represents a game in the PlayerTwoTracker application.
/// </summary>
public class Game : BaseEntity
{
    /// <summary>
    /// Gets or sets the title of the game.
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the description of the game.
    /// </summary>
    public string Description { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the slug of the game.
    /// </summary>
    [MaxLength(100)]
    public string Slug { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the released year of the game.
    /// </summary>
    public int ReleasedYear { get; set; } = DateTime.Now.Year;
    /// <summary>
    /// Gets or sets the estimated gameplay duration (hours) of the game.
    /// </summary>
    [Range(0, double.MaxValue, ErrorMessage = "Estimated gameplay duration must be a non-negative value.")]
    public double EstimatedGamePlay { get; set; } = 0.0;
    /// <summary>
    /// Gets or sets the collection of genres associated with the game.
    /// </summary>
    public ICollection<Genre> Genres { get; set; } = new List<Genre>();
    /// <summary>
    /// Gets or sets the collection of platforms associated with the game.
    /// </summary>
    public ICollection<Platform> Platforms { get; set; } = new List<Platform>();
    /// <summary>
    /// Gets or sets the collection of player-game relationships associated with the game.
    /// </summary>
    public ICollection<PlayerGame> PlayerGames { get; set; } = new List<PlayerGame>();
}
