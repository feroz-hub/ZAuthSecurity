namespace Domain.Models.Api;

///<summary>
/// Model representing API resources.
///</summary>
public class ApiResourcesModel : BaseModel
{
    ///<summary>
    /// Gets or sets the unique name of the API resource.
    ///</summary>
    public virtual string Name { get; set; }

    ///<summary>
    /// Gets or sets the display name of the API resource.
    ///</summary>
    public virtual string DisplayName { get; set; }

    ///<summary>
    /// Gets or sets the description of the API resource.
    ///</summary>
    public virtual string Description { get; set; }

    ///<summary>
    /// Gets or sets a value indicating whether the API resource is enabled.
    ///</summary>
    public virtual bool Enabled { get; set; } = true;


    /// <summary>
    /// Gets or sets the list of ApiResourceClaims using ApiResourceClaimsModel.
    /// </summary>
    public virtual List<ApiResourceClaimsModel> ApiResourceClaims { get; set; }
    
    /// <summary>
    /// Gets or sets the list of ApiScopes using ApiScopesModel.
    /// </summary>
    public virtual List<ApiScopesModel> ApiScopes { get; set; }
}
