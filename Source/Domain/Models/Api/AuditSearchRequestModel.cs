using Domain.Enums;

namespace Domain.Models.Api;

/// <summary>
/// Audit search model for searching and retrieving audit records.
/// </summary>
public class AuditSearchRequestModel
{
    /// <summary>
    /// Gets or sets the ActionType [Create, Update, Delete].
    /// </summary>
    public AuditType ActionType { get; set; } = AuditType.None;

    /// <summary>
    /// Gets or sets audit action user name as created by.
    /// </summary>
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets start date for the audit records search.
    /// </summary>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// Gets or sets end date for the audit records search.
    /// </summary>
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// Gets or sets model for storing and configuring page information.
    /// </summary>
    public PagingModel Page { get; set; }

    /// <summary>
    /// Gets or sets created on date for audit records search.
    /// </summary>
    public DateTime? CreatedOn { get; set; }

    /// <summary>
    /// Gets or sets search value in the retrieved old or new values. 
    /// </summary>
    public string SearchValue { get; set; }
}