using Domain.Enums;

namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing AuditTrail table.
/// </summary>
public class AuditTrail : BaseEntity
{
    /// <summary>
    /// Gets or sets the ActionType [Create, Update, Delete].
    /// </summary>
    public AuditType ActionType { get; set; }

    /// <summary>
    /// Gets or sets the Table Name.
    /// </summary>
    public string TableName { get; set; }

    /// <summary>
    /// Gets or sets the OldValue of current audit record as json serializable object.
    /// </summary>
    public string OldValue { get; set; }

    /// <summary>
    /// Gets or sets the NewValue of current audit record as json serializable object.
    /// </summary>
    public string NewValue { get; set; }

    /// <summary>
    /// Gets or sets the AffectedColumn of current audit record as json serializable object.
    /// </summary>
    public string AffectedColumn { get; set; }

    /// <summary>
    /// Gets or sets the Action Name.
    /// </summary>
    public string ActionName { get; set; }
}