namespace Domain.Models.Api;
/// <summary>
/// Model for storing role specific permission/claims.
/// </summary>
public class RoleClaimModel : BaseTrailModel
{
    /// <summary>
    /// Gets or sets the Unique Identifier for an model.
    /// </summary>
    public virtual int Id { get; set; }

    /// <summary>
    /// Gets or sets role vs claim mapping based on role identifier.
    /// </summary>
    public virtual Guid RoleId { get; set; }

    /// <summary>
    /// Gets or sets type of claim or permission name.
    /// </summary>
    public virtual string ClaimType { get; set; }

    /// <summary>
    /// Gets or sets type of claim or permission value.
    /// </summary>
    public virtual string ClaimValue { get; set; }
}