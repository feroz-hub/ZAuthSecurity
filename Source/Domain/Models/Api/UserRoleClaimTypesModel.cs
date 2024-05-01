namespace Domain.Models.Api;

/// <summary>
/// Model for storing user role claims.
/// </summary>
public class UserRoleClaimTypesModel
{
    /// <summary>
    /// Gets or sets user unique identifier.
    /// </summary>
    public virtual Guid UserId { get; set; }
    /// <summary>
    /// Gets or sets user name.
    /// </summary>
    public virtual string UserName { get; set; }
    /// <summary>
    /// Gets or sets Role name.
    /// </summary>
    public virtual string RoleName { get; set; }
    /// <summary>
    /// Gets or sets user role claim name.
    /// </summary>
    public virtual string RoleClaimType { get; set; }
    /// <summary>
    /// Gets or sets user role claim value.
    /// </summary>
    public virtual string RoleClaimValue { get; set; }
}
