namespace Domain.Models.Api;

/// <summary>
/// Model for storing user role information.
/// </summary>
public class UserRoleModel : BaseModel
{
    /// <summary>
    /// Gets or sets role identifier.
    /// </summary>
    public virtual Guid RoleId { get; set; }
    /// <summary>
    /// Gets or sets user identifier.<para>Indicates to whom the role assign to.</para>
    /// </summary>
    public virtual Guid UserId { get; set; }
    /// <summary>
    /// Gets or sets valid from date time.
    /// <para>It indicates when this role is applicable.</para>
    /// </summary>
    public virtual DateTime ValidFrom { get; set; }
    /// <summary>
    /// Gets or sets valid to.<para>It indicates when this role validation ends.</para>
    /// </summary>
    public virtual DateTime ValidTo { get; set; }
}