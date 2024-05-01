using Domain;
using Domain.Entities.Api;

namespace DomainServices.Repository.Api;

/// <summary>
/// Interface defining operations for managing user roles in the repository.
/// </summary>
public interface IUserRoleRepository
{
    /// <summary>
    /// Inserts a new user role asynchronously.
    /// </summary>
    /// <param name="entity">The user role entity to insert.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task InsertAsync(UserRoles entity);

    /// <summary>
    /// Updates an existing user role asynchronously.
    /// </summary>
    /// <param name="entity">The user role entity to update.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task UpdateAsync(UserRoles entity);

    /// <summary>
    /// Deletes a user role asynchronously.
    /// </summary>
    /// <param name="entity">The user role entity to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DeleteAsync(UserRoles entity);

    /// <summary>
    /// Deletes multiple user roles asynchronously.
    /// </summary>
    /// <param name="entityList">The list of user role entities to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DeleteAsync(IEnumerable<UserRoles> entityList);

    /// <summary>
    /// Retrieves a user role asynchronously based on user ID and role ID.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="roleId">The ID of the role.</param>
    /// <returns>A task representing the asynchronous operation, returning the user role.</returns>
    Task<UserRoles> GetUserRoleAsync(Guid userId, Guid roleId);

    /// <summary>
    /// Retrieves all roles associated with a specific user asynchronously.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A task representing the asynchronous operation, returning a list of user roles.</returns>
    Task<IReadOnlyList<UserRoles>> GetUserRoleAsync(Guid userId);

    /// <summary>
    /// Saves changes made to the repository asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning a framework result.</returns>
    Task<FrameworkResult> SaveChangesAsync();
}
