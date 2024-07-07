namespace Domain.Models.Api;

public class AuditTrailModel
{
    /// <summary>
    /// Gets or sets the Unique Identifier for a model.
    /// </summary>
    public virtual Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the ActionType [Create, Update, Delete].
    /// </summary>
    public AuditType ActionType { get; set; } = AuditType.None;

    /// <summary>
    /// Gets or sets the affected table name.
    /// </summary>
    public string TableName { get; set; }

    /// <summary>
    /// Gets or sets old value of the current audit record as a JSON serializable object.
    /// </summary>
    public string OldValue { get; set; }

    /// <summary>
    /// Gets or sets new value of the current audit record as a JSON serializable object.
    /// </summary>
    public string NewValue { get; set; }

    /// <summary>
    /// Gets or sets the affected column of the object as a JSON serializable object.
    /// </summary>
    public string AffectedColumn { get; set; }

    /// <summary>
    /// Gets or sets the action name.
    /// </summary>
    public string ActionName { get; set; }

    /// <summary>
    /// Gets or sets audit action user name as created by.
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets the audit record created date time in UTC.
    /// </summary>
    public DateTime CreatedOn { get; } = DateTime.UtcNow;
}
