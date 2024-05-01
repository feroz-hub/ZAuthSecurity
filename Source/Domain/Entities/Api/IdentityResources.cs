namespace Domain.Entities.Api;
/// <summary>
/// DB Entity representing IdentityResources table.
/// </summary>
public class IdentityResources : BaseEntity
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
    /// Gets or sets a value indicating whether the Identity Resource is Enabled. Defaults to true.
    /// </summary>
    public virtual bool Enabled { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the Identity Resource [Scope] is Required.
    /// Actually specifies whether the user can de-select the scope on the consent screen. Defaults to false.
    /// </summary>
    public virtual bool Required { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the consent screen will emphasize this Identity Resource [scope].
    /// This setting is used for sensitive or important scopes. Defaults to false.
    /// </summary>
    public virtual bool Emphasize { get; set; }

    /// <summary>
    /// Gets or sets the list of IdentityClaims.
    /// </summary>
    public virtual List<IdentityClaims> IdentityClaims { get; set; }
}