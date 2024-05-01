namespace Domain.Models.Api;
/// <summary>
/// Model for storing ApiScope claims information.
/// </summary>
public class ApiScopeClaimsModel : BaseModel
{
    /// <summary>
    /// Gets or sets the API Scope Identifier.
    /// </summary>
    public virtual Guid ApiScopeId { get; set; }
    /// <summary>
    /// Gets or sets the Type.
    /// </summary>
    public virtual string Type { get; set; }
}
