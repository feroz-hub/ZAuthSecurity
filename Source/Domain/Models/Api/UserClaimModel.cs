namespace Domain.Models.Api;

/// <summary>
/// Model for storing user claims.
/// </summary>
public class UserClaimModel : BaseTrailModel
{
    /// <summary>
    /// Gets or sets the Unique Identifier for an model.
    /// </summary>
    public virtual int Id { get; set; }

    /// <summary>
    /// Gets or sets user unique identifier.
    /// </summary>
    public virtual Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets user claim name.
    /// </summary>
    public virtual string ClaimType { get; set; }

    /// <summary>
    /// Gets or sets user claim value.
    /// </summary>
    public virtual string ClaimValue { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the claim added is an admin claim.
    /// <para>Default value set as false.</para>
    /// </summary>
    public virtual bool IsAdminClaim { get; set; } = false;

}