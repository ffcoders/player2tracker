namespace PlayerTwoTracker.Domain.Entities;

/// <summary>
/// Represents a gaming platform in the PlayerTwoTracker application.
/// </summary>
public class Platform
{
    /// <summary>
    /// Gets or sets the unique identifier for the platform.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();
    /// <summary>
    /// Gets or sets the name of the platform.
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the code of the platform.
    /// </summary>
    public string Code { get; set; } = string.Empty; 
    /// <summary>
    /// Gets or sets the slug of the platform.
    /// </summary>
    public string Slug { get; set; } = string.Empty;

}
