namespace PlayerTwoTracker.Domain;

public class BaseEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the entity.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();
    /// <summary>
    /// Gets or sets the creation date of the entity.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    /// <summary>
    /// Gets or sets the last update date of the entity.    
    /// </summary>
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    /// <summary>
    /// Gets or sets a value indicating whether the entity is deleted (soft delete).
    /// </summary>
    public bool IsDeleted { get; set; } = false;
}
