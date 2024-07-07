namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing Roles table.
/// </summary>
public class Roles : IdentityRole<Guid>
{
    /// <summary>
    /// Gets or sets Role Description.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether IsDeleted Flag is marked on deleted records.
    /// </summary>
    public virtual bool IsDeleted { get; set; }

    /// <summary>
    /// Gets or sets CreatedOn.
    /// </summary>
    public virtual DateTime CreatedOn { get; set; }

    /// <summary>
    /// Gets or sets CreatedOn.
    /// </summary>
    public virtual DateTime ModifiedOn { get; set; }

    /// <summary>
    /// Gets or sets CreatedBy.
    /// </summary>
    public virtual string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets ModifiedBy.
    /// </summary>
    public virtual string ModifiedBy { get; set; }
}