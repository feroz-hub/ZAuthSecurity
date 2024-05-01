namespace Domain.Models.Api;

/// <summary>
/// Model for storing Identity Resource information.
/// </summary>
public class IdentityResourcesModel : BaseModel
{
    /// <summary>
    /// Gets or sets the Name for Identity Resource.
    /// </summary>
    public virtual string Name { get; set; }

    /// <summary>
    /// Gets or sets the DisplayName for Identity Resource.
    /// </summary>
    public virtual string DisplayName { get; set; }

    /// <summary>
    /// Gets or sets the Description for Identity Resource.
    /// </summary>
    public virtual string Description { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the Identity Resource is Enabled.
    /// <para>Default value set as True.</para>
    /// </summary>
    public virtual bool Enabled { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether the Identity Resource [Scope] is Required.
    /// <para>Actually specifies whether the user can de-select the scope on the consent screen.</para>
    /// <para>Defaults value set as False.</para>.
    /// </summary>
    public virtual bool Required { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether the consent screen will emphasize this Identity Resource [scope].
    /// <para>This setting is used for sensitive or important scopes.</para>
    /// <para>Defaults value set as False.</para>.
    /// </summary>
    public virtual bool Emphasize { get; set; } = false;

    /// <summary>
    /// Gets or sets the list of IdentityClaims.
    /// </summary>
    public virtual List<IdentityClaimsModel> IdentityClaims { get; set; }
}