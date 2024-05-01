using Domain;
using DomainServices.Repository.Api;

namespace DomainServices.UnitOfWork.Api;

/// <summary>
/// Represents a unit of work interface for role management.
/// </summary>
public interface IRoleManagementUnitOfWork
{
    /// <summary>
    /// Gets the repository for managing roles.
    /// </summary>
    IRoleRepository RoleRepository { get; }
        
    /// <summary>
    /// Gets the repository for managing role claims.
    /// </summary>
    IRoleClaimsRepository RoleClaimsRepository { get; }
        
    /// <summary>
    /// Asynchronously sets the added status for the specified entity.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    /// <param name="entity">The entity for which to set the added status.</param>
    Task SetAddedStatusAsync<T>(T entity);
        
    /// <summary>
    /// Asynchronously sets the modified status for the specified entity with concurrency stamp.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    /// <param name="entity">The entity for which to set the modified status.</param>
    /// <param name="concurrencyStamp">The concurrency stamp for optimistic concurrency.</param>
    Task SetModifiedStatusAsync<T>(T entity, string concurrencyStamp);
        
    /// <summary>
    /// Asynchronously saves changes to the underlying data store.
    /// </summary>
    /// <returns>A task representing the asynchronous operation with a FrameworkResult indicating the outcome.</returns>
    Task<FrameworkResult> SaveChangesAsync();
}