namespace Domain.Entities.Api;
/// <summary>
/// Represents the claims associated with an API resource.
/// </summary>
public class ApiResourceClaims : BaseEntity
{
    /// <summary>
    /// Gets or sets the identifier of the API resource.
    /// </summary>
    public virtual Guid ApiResourceId { get; set; }

    /// <summary>
    /// Gets or sets the type of the claim.
    /// </summary>
    public virtual string Type { get; set; }

    /// <summary>
    /// Gets or sets the API resource associated with the claim.
    /// </summary>
    public virtual ApiResources ApiResources { get; set; }
}
