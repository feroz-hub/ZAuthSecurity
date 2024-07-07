namespace Domain.Entities.Api;
/// <summary>
/// DB Entity representing UserClaims table.
/// </summary>
public class UserClaims : IdentityUserClaim<Guid>
{
    /// <summary>
    /// Gets or sets a value indicating whether the claim added is an admin claim.
    /// </summary>
    public virtual bool IsAdminClaim { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether user claim is deleted or not.
    /// </summary>
    public virtual bool IsDeleted { get; set; }

    /// <summary>
    /// Gets or sets claim created date.
    /// </summary>
    public virtual DateTime CreatedOn { get; set; }

    /// <summary>
    /// Gets or sets user claim modified on.
    /// </summary>
    public virtual DateTime? ModifiedOn { get; set; }

    /// <summary>
    /// Gets or sets user claim created by (user name).
    /// </summary>
    public virtual string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets user claim last modified by (user name).
    /// </summary>
    public virtual string ModifiedBy { get; set; }

    /// <summary>
    /// Gets or sets for handling concurrency.
    /// </summary>
    [Timestamp]
    public byte[] RowVersion { get; set; }
}