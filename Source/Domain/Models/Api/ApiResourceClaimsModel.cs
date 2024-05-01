namespace Domain.Models.Api;
///<summary>
/// Model representing the claims associated with an API resource.
///</summary>
public class ApiResourceClaimsModel : BaseModel
{
    ///<summary>
    /// Gets or Sets the unique identifier of the API resource.
    ///</summary>
    public virtual Guid ApiResourceId { get; set; }

    ///<summary>
    /// Gets or Sets type of claim associated with the API resource.
    ///</summary>
    public virtual string Type { get; set; }
}
