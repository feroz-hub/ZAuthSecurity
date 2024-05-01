using System.Security.Claims;
using Domain;
using Domain.Entities.Api;
using Domain.Models.Api;

namespace DomainServices.Repository.Api;

/// <summary>
/// Interface defining operations for managing role claims in the repository.
/// </summary>
public interface IRoleClaimsRepository
{
    /// <summary>
    /// Inserts a new role claim asynchronously.
    /// </summary>
    /// <param name="entity">The role claim entity to insert.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task InsertAsync(RoleClaims entity);

    /// <summary>
    /// Updates an existing role claim asynchronously.
    /// </summary>
    /// <param name="entity">The role claim entity to update.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task UpdateAsync(RoleClaims entity);

    /// <summary>
    /// Deletes a role claim by its ID asynchronously.
    /// </summary>
    /// <param name="roleClaimId">The ID of the role claim to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DeleteAsync(int roleClaimId);

    /// <summary>
    /// Deletes role claims associated with a specific role ID asynchronously.
    /// </summary>
    /// <param name="roleId">The ID of the role whose claims are to be deleted.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DeleteAsync(Guid roleId);

    /// <summary>
    /// Deletes a role claim asynchronously.
    /// </summary>
    /// <param name="entity">The role claim entity to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DeleteAsync(RoleClaims entity);

    /// <summary>
    /// Retrieves claims associated with a specific role asynchronously.
    /// </summary>
    /// <param name="roleId">The ID of the role whose claims are to be retrieved.</param>
    /// <returns>A task representing the asynchronous operation, returning a list of role claims.</returns>
    Task<IReadOnlyList<RoleClaims>> GetClaimsAsync(Guid roleId);

    /// <summary>
    /// Finds the ID of a role claim based on role ID and claim asynchronously.
    /// </summary>
    /// <param name="roleId">The ID of the role.</param>
    /// <param name="claim">The claim to search for.</param>
    /// <returns>A task representing the asynchronous operation, returning the ID of the role claim.</returns>
    Task<int> FindIdByClaimAsync(Guid roleId, Claim claim);

    /// <summary>
    /// Finds a role claim based on role ID and claim asynchronously.
    /// </summary>
    /// <param name="roleId">The ID of the role.</param>
    /// <param name="claim">The claim to search for.</param>
    /// <returns>A task representing the asynchronous operation, returning the role claim.</returns>
    Task<RoleClaims> FindRoleByClaimAsync(Guid roleId, Claim claim);

    /// <summary>
    /// Finds a role claim by its ID asynchronously.
    /// </summary>
    /// <param name="roleClaimId">The ID of the role claim to find.</param>
    /// <returns>A task representing the asynchronous operation, returning the role claim.</returns>
    Task<RoleClaims> FindRoleClaimByIdAsync(int roleClaimId);

    /// <summary>
    /// Retrieves roles and associated claims for a specific user asynchronously.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A task representing the asynchronous operation, returning a list of user role claim types.</returns>
    Task<IReadOnlyList<UserRoleClaimTypesModel>> GetRolesAndClaimsForUser(Guid userId);

    /// <summary>
    /// Saves changes made to the repository asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning a framework result.</returns>
    Task<FrameworkResult> SaveChangesAsync();
}
