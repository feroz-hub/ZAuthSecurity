using Domain;
using Domain.Entities.Api;

namespace DomainServices.Repository.Api;

/// <summary>
/// Interface defining operations for managing users in the repository.
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Deletes a user asynchronously.
    /// </summary>
    /// <param name="entity">The user entity to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DeleteAsync(Users entity);

    /// <summary>
    /// Updates a user asynchronously, specifying affected properties.
    /// </summary>
    /// <param name="entity">The user entity to update.</param>
    /// <param name="affectedProperties">The properties affected by the update.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task UpdateAsync(Users entity, string[] affectedProperties);

    /// <summary>
    /// Retrieves users in a specific role asynchronously.
    /// </summary>
    /// <param name="roleName">The name of the role.</param>
    /// <returns>A task representing the asynchronous operation, returning a list of users.</returns>
    Task<IReadOnlyList<Users>> GetUsersInRoleAsync(string roleName);

    /// <summary>
    /// Sets the added status of an entity asynchronously.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    /// <param name="entity">The entity to set the status for.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task SetAddedStatusAsync<T>(T entity);

    /// <summary>
    /// Sets the modified status of an entity asynchronously.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    /// <param name="entity">The entity to set the status for.</param>
    /// <param name="concurrencyStamp">The concurrency stamp for optimistic concurrency.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task SetModifiedStatusAsync<T>(T entity, string concurrencyStamp);

    /// <summary>
    /// Saves changes made to the repository asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning a framework result.</returns>
    Task<FrameworkResult> SaveChangesAsync();

    /// <summary>
    /// Enables automatic saving of changes made to identity objects.
    /// </summary>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task EnableIdentityAutoSaveChanges();

    /// <summary>
    /// Disables automatic saving of changes made to identity objects.
    /// </summary>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DisableIdentityAutoSaveChanges();

    /// <summary>
    /// Retrieves all users asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning a list of users.</returns>
    Task<IReadOnlyList<Users>> GetAllUsersAsync();
}
