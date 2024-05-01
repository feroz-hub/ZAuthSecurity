using Domain;
using Domain.Entities.Api;

namespace DomainServices.Repository.Api;

/// <summary>
/// Interface defining operations for managing roles in the repository.
/// </summary>
public interface IRoleRepository
{
    /// <summary>
    /// Updates an existing role asynchronously.
    /// </summary>
    /// <param name="entity">The role entity to update.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task UpdateAsync(Roles entity);

    /// <summary>
    /// Deletes a role asynchronously.
    /// </summary>
    /// <param name="entity">The role entity to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DeleteAsync(Roles entity);

    /// <summary>
    /// Retrieves all roles asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning a list of roles.</returns>
    Task<IReadOnlyList<Roles>> GetAllRolesAsync();

    /// <summary>
    /// Saves changes made to the repository asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning a framework result.</returns>
    Task<FrameworkResult> SaveChangesAsync();
}
