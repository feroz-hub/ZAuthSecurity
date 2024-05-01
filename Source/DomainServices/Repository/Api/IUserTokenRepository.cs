using Domain;
using Domain.Entities.Api;

namespace DomainServices.Repository.Api;

/// <summary>
/// Interface defining operations for managing user tokens in the repository.
/// </summary>
public interface IUserTokenRepository
{
    /// <summary>
    /// Retrieves user tokens asynchronously based on user ID.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A task representing the asynchronous operation, returning a list of user tokens.</returns>
    Task<IReadOnlyList<UserTokens>> GetUserTokenAsync(Guid userId);

    /// <summary>
    /// Retrieves user tokens asynchronously based on user ID, token name, and login provider.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="name">The name of the token.</param>
    /// <param name="loginProvider">The login provider associated with the token.</param>
    /// <returns>A task representing the asynchronous operation, returning a list of user tokens.</returns>
    Task<IReadOnlyList<UserTokens>> GetUserTokenAsync(Guid userId, string name, string loginProvider);

    /// <summary>
    /// Deletes multiple user tokens asynchronously.
    /// </summary>
    /// <param name="entityList">The list of user token entities to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DeleteAsync(IEnumerable<UserTokens> entityList);

    /// <summary>
    /// Saves changes made to the repository asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning a framework result.</returns>
    Task<FrameworkResult> SaveChangesAsync();
}
