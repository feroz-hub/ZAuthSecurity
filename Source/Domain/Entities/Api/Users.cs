using Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing Users table.
/// </summary>
public class Users : IdentityUser<Guid>
{
    /// <summary>
    /// Gets or sets the FirstName.
    /// </summary>
    public virtual string FirstName { get; set; }

    /// <summary>
    /// Gets or sets the LastName.
    /// </summary>
    public virtual string LastName { get; set; }

    /// <summary>
    /// Gets or sets the FirstName.
    /// </summary>
    public virtual DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the TwoFactorTypeId.
    /// </summary>
    public virtual TwoFactorType TwoFactorType { get; set; }

    /// <summary>
    /// Gets or sets the LastPasswordChangedDate.
    /// </summary>
    public virtual DateTime LastPasswordChangedDate { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether default password change is required.
    /// </summary>
    public virtual bool RequiresDefaultPasswordChange { get; set; }

    /// <summary>
    /// Gets or sets the DateTime at which user logs in.
    /// </summary>
    public virtual DateTime LastLoginDateTime { get; set; }

    /// <summary>
    /// Gets or sets the DateTime at which user logs out.
    /// </summary>
    public virtual DateTime LastLogoutDateTime { get; set; }

    /// <summary>
    /// Gets or sets the type of IdentityProvider i.e. Local user or LDAP user.
    /// </summary>
    public virtual IdentityProvider IdentityProviderType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the user record is marked as soft deleted.
    /// </summary>
    public virtual bool IsDeleted { get; set; }

    /// <summary>
    /// Gets or sets the datetime at which the user record is created.
    /// </summary>
    public virtual DateTime CreatedOn { get; set; }

    /// <summary>
    /// Gets or sets the datetime at which the user record is modified.
    /// </summary>
    public virtual DateTime ModifiedOn { get; set; }

    /// <summary>
    /// Gets or sets the CreatedBy name by whom the user record is created.
    /// </summary>
    public virtual string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the ModifiedBy name by whom the user record is modified.
    /// </summary>
    public virtual string ModifiedBy { get; set; }
}