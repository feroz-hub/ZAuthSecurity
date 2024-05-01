using Domain;
using Domain.Entities.Api;
using Domain.Models.Api;

namespace DomainServices.Repository.Api;

/// <summary>
/// Interface for accessing audit trail information.
/// </summary>
public interface IAuditRepository
{
    /// <summary>
    /// Inserts an audit trail entity asynchronously.
    /// </summary>
    /// <param name="entity">The audit trail entity to insert.</param>
    Task InsertAsync(AuditTrail entity);

    /// <summary>
    /// Retrieves the total count of audit trail records asynchronously.
    /// </summary>
    /// <returns>The total count of audit trail records.</returns>
    Task<int> GetTotalCountAsync();

    /// <summary>
    /// Saves changes made to the audit repository asynchronously.
    /// </summary>
    /// <returns>A FrameworkResult indicating the outcome of the save operation.</returns>
    Task<FrameworkResult> SaveChangesAsync();

    /// <summary>
    /// Retrieves audit trail details asynchronously based on the provided search criteria.
    /// </summary>
    /// <param name="auditSearchRequestModel">The search criteria for filtering audit trail details.</param>
    /// <returns>A read-only list of AuditTrail objects matching the search criteria.</returns>
    Task<IReadOnlyList<AuditTrail>> GetAuditDetailsAsync(AuditSearchRequestModel auditSearchRequestModel);
}
