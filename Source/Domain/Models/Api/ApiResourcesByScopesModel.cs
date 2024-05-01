namespace Domain.Models.Api;
/// <summary>
/// Represents a mapping between an API resource and a scope, along with their corresponding claim types.
/// </summary>
public class ApiResourcesByScopesModel : BaseModel
{
    /// <summary>
    /// Gets or sets the unique identifier of the API resource.
    /// </summary>
    public virtual Guid ApiResourceId { get; set; }

    /// <summary>
    /// Gets or sets the name of the API resource.
    /// </summary>
    public virtual string ApiResourceName { get; set; }

    /// <summary>
    /// Gets or sets the claim type associated with the API resource.
    /// </summary>
    public virtual string ApiResourceClaimType { get; set; }

    /// <summary>
    /// Gets or sets the name of the API scope.
    /// </summary>
    public virtual string ApiScopeName { get; set; }

    /// <summary>
    /// Gets or sets the claim type associated with the API scope.
    /// </summary>
    public virtual string ApiScopeClaimType { get; set; }
}

