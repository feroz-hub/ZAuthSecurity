namespace Domain.Models.Api;

/// <summary>
/// Domain Model representing Identity Resources.
/// </summary>
public class IdentityResourcesByScopesModel
{
    /// <summary>
    /// Gets or sets the Id for Identity Resource.
    /// </summary>
    public virtual Guid IdentityResourceId { get; set; }

    /// <summary>
    /// Gets or sets the Name for Identity Resource.
    /// </summary>
    public virtual string IdentityResourceName { get; set; }

    /// <summary>
    /// Gets or sets the Resource Claim Type for Identity resource.
    /// </summary>
    public virtual string IdentityResourceClaimType { get; set; }

    /// <summary>
    /// Gets or sets the resource claim alias type for identity resource.
    /// </summary>
    public virtual string IdentityResourceClaimAliasType { get; set; }
}
