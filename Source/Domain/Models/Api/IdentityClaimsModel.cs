namespace Domain.Models.Api;

public class IdentityClaimsModel : BaseModel
{
    /// <summary>
    /// Gets or sets the unique identifier of Identity Resource.
    /// </summary>
    public virtual Guid IdentityResourceId { get; set; }

    /// <summary>
    /// Gets or sets the Type for Identity Claims.
    /// </summary>
    public virtual string Type { get; set; }

    /// <summary>
    /// Gets or sets the AliasType for Identity Resource.
    /// <para>Each claim type has a custom alias type to match the user model defined by the security framework.</para>
    /// </summary>
    public virtual string AliasType { get; set; }
}