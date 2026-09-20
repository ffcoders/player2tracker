namespace PlayerTwoTracker.Domain;

public class Genre : BaseEntity
{
    /// <summary>
    /// Gets or sets the name of the genre.
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the slug of the genre.
    /// </summary>
    public string Slug { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the collection of games associated with the genre.
    /// </summary>
    public ICollection<Game> Games { get; set; } = new List<Game>();
}
