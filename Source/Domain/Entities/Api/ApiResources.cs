namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing ApiResources table.
/// </summary>
public class ApiResources : BaseEntity
{
    /// <summary>
    /// Gets or sets the Name for API resource.
    /// </summary>
    public virtual string Name { get; set; }

    /// <summary>
    /// Gets or sets the Display Name for API resource.
    /// </summary>
    public virtual string DisplayName { get; set; }

    /// <summary>
    /// Gets or sets the Description for API resource.
    /// </summary>
    public virtual string Description { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the API Resource is Enabled. Defaults to true.
    /// </summary>
    public virtual bool Enabled { get; set; }

    /// <summary>
    /// Gets or sets the list of ApiResourceClaims.
    /// </summary>
    public virtual List<ApiResourceClaims> ApiResourceClaims { get; set; }

    /// <summary>
    /// Gets or sets the list of ApiScopes.
    /// </summary>
    public virtual List<ApiScopes> ApiScopes { get; set; }
}