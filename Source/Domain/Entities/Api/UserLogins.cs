using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing UserLogins table.
/// </summary>
public class UserLogins : IdentityUserLogin<Guid>
{
    /// <summary>
    /// Gets or sets user unique auto generated id.
    /// </summary>
    public virtual Guid Id { get; set; }

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
    public virtual DateTime ModifiedOn { get; set; }

    /// <summary>
    /// Gets or sets user claim created by (user name).
    /// </summary>
    public virtual string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets user claim last modified by (user name).
    /// </summary>
    public virtual string ModifiedBy { get; set; }
}