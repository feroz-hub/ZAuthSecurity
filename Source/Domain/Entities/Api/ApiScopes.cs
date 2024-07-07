namespace Domain.Entities.Api;
/// <summary>
/// DB Entity representing ApiScopes table.
/// </summary>
public class ApiScopes : BaseEntity
{
    /// <summary>
    /// Gets or sets the Id.
    /// </summary>
    public virtual Guid ApiResourceId { get; set; }

    /// <summary>
    /// Gets or sets the Name for Api Scope.
    /// </summary>
    public virtual string Name { get; set; }

    /// <summary>
    /// Gets or sets the DisplayName for Api Scope.
    /// </summary>
    public virtual string DisplayName { get; set; }

    /// <summary>
    /// Gets or sets the Description for Api Scope.
    /// </summary>
    public virtual string Description { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the API Scope is Required.
    /// Actually specifies whether the user can de-select the scope on the consent screen(V2 release). Defaults to false.
    /// </summary>
    public virtual bool Required { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the consent screen(V2 release) will emphasize this scope.
    /// This setting is used for sensitive or important scopes. Defaults to false.
    /// </summary>
    public virtual bool Emphasize { get; set; }

    /// <summary>
    /// Gets or sets the ApiResource associated with this Api Scope.
    /// </summary>
    public virtual ApiResources ApiResource { get; set; }

    /// <summary>
    /// Gets or sets the list of ApiScopeClaims associated with this Api Scope.
    /// </summary>
    public virtual List<ApiScopeClaims> ApiScopeClaims { get; set; }
}