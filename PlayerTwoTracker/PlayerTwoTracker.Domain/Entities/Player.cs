namespace PlayerTwoTracker.Domain;

public class Player : BaseEntity
{
    /// <summary>
    /// Gets or sets the username of the player.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the name of the player.
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the email of the player.
    /// </summary>
    public string Email { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the collection of player-game relationships associated with the player.
    /// </summary>
    public ICollection<PlayerGame> PlayerGames { get; set; } = new List<PlayerGame>();
}
