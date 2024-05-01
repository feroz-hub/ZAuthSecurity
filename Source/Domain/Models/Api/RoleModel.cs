namespace Domain.Models.Api;

/// <summary>
/// Model for storing role information.
/// </summary>
public class RoleModel : BaseModel
{
    /// <summary>
    /// Gets or sets role name.
    /// </summary>
    public virtual string Name { get; set; }

    /// <summary>
    /// Gets or sets role description.
    /// </summary>
    public virtual string Description { get; set; }

    /// <summary>
    /// Gets or sets a list of role claim model.
    /// <para>Role claim model is used for storing role specific permissions.</para>
    /// </summary>
    public virtual List<RoleClaimModel> RoleClaims { get; set; }
}