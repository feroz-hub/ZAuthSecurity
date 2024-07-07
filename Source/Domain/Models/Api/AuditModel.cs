using Domain.Entities.Api;
using Newtonsoft.Json;

namespace Domain.Models.Api;

public class AuditModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditModel"/> class.
    /// </summary>
    public AuditModel()
    {
    }
    /// <summary>
    /// Gets or Sets affected Audit Table Name.
    /// </summary>
    public string TableName { get; set; }
    /// <summary>
    /// Gets or Sets the Created By.
    /// </summary>
    public string CreatedBy { get; set; }
    /// <summary>
    ///  Gets the Primary Key Value for Old entry.
    /// </summary>
    public Dictionary<string, object> OldValues { get; } = new();
    /// <summary>
    ///  Gets the Primary Key Value for New Entry.
    /// </summary>
    public Dictionary<string, object> NewValues { get; } = new();
    /// <summary>
    ///  Gets or Sets the Audit Type : none, create, update and delete.
    /// </summary>
    public AuditType AuditType { get; set; }
    /// TO BE REMOVED AFTER DISCUSSION
    /// <summary>
    /// Gets or sets the Action Name.
    /// </summary>
    public string ActionName { get; set; }
    /// <summary>
    ///  Gets the List of affected columns.
    /// </summary>
    public List<string> AffectedColumns { get; } = [];
    /// <summary>
    ///  Converts audit model to audit entity.
    /// </summary>
    /// <returns>Audit trail entity.</returns>
    public AuditTrail ToAudit()
    {
        var audit = new AuditTrail();
        audit.ActionType = AuditType;
        audit.TableName = TableName;
        audit.CreatedOn = DateTime.UtcNow;
        audit.CreatedBy = CreatedBy;
        audit.OldValue = OldValues.Count == 0 ? null : JsonConvert.SerializeObject(OldValues);
        audit.NewValue = NewValues.Count == 0 ? null : JsonConvert.SerializeObject(NewValues);
        audit.AffectedColumn = AffectedColumns.Count == 0 ? null : JsonConvert.SerializeObject(AffectedColumns);
        return audit;
    }
}
