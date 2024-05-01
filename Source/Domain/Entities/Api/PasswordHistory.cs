namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing PasswordHistory table.
/// </summary>
public class PasswordHistory : BaseEntity
{
    /// <summary>
    /// Gets or sets the User Id.
    /// </summary>
    public virtual Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets ChangedOn.
    /// </summary>
    public virtual DateTime ChangedOn { get; set; }

    /// <summary>
    /// Gets or sets the PasswordHash.
    /// </summary>
    public virtual string PasswordHash { get; set; }

    /// <summary>
    /// Gets or sets the User.
    /// </summary>
    public virtual Users User { get; set; }
}