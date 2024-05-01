namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing ApiScopeClaims table.
/// </summary>
public class ApiScopeClaims : BaseEntity
{
    /// <summary>
    /// Gets or sets the API Scope Id.
    /// </summary>
    public virtual Guid ApiScopeId { get; set; }

    /// <summary>
    /// Gets or sets the Type.
    /// </summary>
    public virtual string Type { get; set; }

    /// <summary>
    /// Gets or sets the API Scopes.
    /// </summary>
    public virtual ApiScopes ApiScope { get; set; }
}