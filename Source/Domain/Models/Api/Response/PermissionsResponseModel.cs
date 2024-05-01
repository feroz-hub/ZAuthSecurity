namespace Domain.Models.Api.Response;

/// <summary>
/// Model for returning user permissions.
/// </summary>
public class UserPermissionsResponseModel
{
    /// <summary>
    /// Gets or sets user unique identifier.
    /// </summary>
    public virtual Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets list of role permissions using \class UserRoleClaimsModel.
    /// </summary>
    public virtual IList<UserRoleClaimsModel> RolePermissions { get; set; }
}

/// <summary>
/// Model for returning role permissions.
/// </summary>
public class UserRoleClaimsModel
{
    /// <summary>
    /// Gets or sets role identifier.
    /// </summary>
    public virtual Guid RoleId { get; set; }

    /// <summary>
    /// Gets or sets role name.
    /// </summary>
    public virtual string RoleName { get; set; }

    /// <summary>
    /// Gets or sets list of claims.
    /// </summary>
    public virtual IList<RoleClaimModel> Claims { get; set; }
}