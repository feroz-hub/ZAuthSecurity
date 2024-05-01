using System.Security.Claims;
using Domain;
using Domain.Entities.Api;

namespace DomainServices.Repository.Api;

/// <summary>
/// Interface defining operations for managing user claims in the repository.
/// </summary>
public interface IUserClaimRepository
{
    /// <summary>
    /// Inserts a new user claim asynchronously.
    /// </summary>
    /// <param name="entity">The user claim entity to insert.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task InsertAsync(UserClaims entity);

    /// <summary>
    /// Updates an existing user claim asynchronously.
    /// </summary>
    /// <param name="entity">The user claim entity to update.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task UpdateAsync(UserClaims entity);

    /// <summary>
    /// Deletes a user claim by its ID asynchronously.
    /// </summary>
    /// <param name="id">The ID of the user claim to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DeleteAsync(int id);

    /// <summary>
    /// Deletes multiple user claims asynchronously.
    /// </summary>
    /// <param name="entityList">The list of user claim entities to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DeleteAsync(IEnumerable<UserClaims> entityList);

    /// <summary>
    /// Finds the ID of a user claim based on user ID and claim asynchronously.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="claim">The claim to search for.</param>
    /// <param name="isAdminClaim">Optional. Indicates whether the claim is an admin claim. Default is false.</param>
    /// <returns>A task representing the asynchronous operation, returning the user claim.</returns>
    Task<UserClaims> FindIdByClaimAsync(Guid userId, Claim claim, bool isAdminClaim = false);

    /// <summary>
    /// Finds a user claim by its ID asynchronously.
    /// </summary>
    /// <param name="userClaimId">The ID of the user claim to find.</param>
    /// <returns>A task representing the asynchronous operation, returning the user claim.</returns>
    Task<UserClaims> FindUserClaimByIdAsync(int userClaimId);

    /// <summary>
    /// Retrieves all claims associated with a specific user asynchronously.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A task representing the asynchronous operation, returning a list of user claims.</returns>
    Task<IReadOnlyList<UserClaims>> GetClaimsAsync(Guid userId);

    /// <summary>
    /// Retrieves admin claims associated with a specific user asynchronously.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="getOnlyAdminClaim">Optional. Indicates whether to retrieve only admin claims. Default is true.</param>
    /// <returns>A task representing the asynchronous operation, returning a list of user claims.</returns>
    Task<IReadOnlyList<UserClaims>> GetAdminUserClaimsAsync(Guid userId, bool getOnlyAdminClaim = true);

    /// <summary>
    /// Saves changes made to the repository asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning a framework result.</returns>
    Task<FrameworkResult> SaveChangesAsync();
}
