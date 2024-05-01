namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing Identity Claims table.
/// </summary>
public class IdentityClaims : BaseEntity
{
    /// <summary>
    /// Gets or sets the unique id of IdentityResource.
    /// </summary>
    public virtual Guid IdentityResourceId { get; set; }

    /// <summary>
    /// Gets or sets the Type for Identity Claims.
    /// </summary>
    public virtual string Type { get; set; }

    /// <summary>
    /// Gets or sets the AliasType for Identity Resource.
    /// </summary>
    public virtual string AliasType { get; set; }

    /// <summary>
    /// Gets or sets the IdentityResource for this IdentityClaim.
    /// </summary>
    public virtual IdentityResources IdentityResource { get; set; }
}