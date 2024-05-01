namespace Domain.Models.Api.Response;

/// <summary>
/// Model to return audit results base on input criteria.
/// </summary>
public class AuditResponseModel
{
    /// <summary>
    /// Gets or sets list of return audit results.
    /// </summary>
    public List<AuditTrailModel> AuditList { get; set; }

    /// <summary>
    /// Gets or sets paging input to retrieve numbers of pages based on current page.
    /// </summary>
    public PagingModel PageInfo { get; set; }
}