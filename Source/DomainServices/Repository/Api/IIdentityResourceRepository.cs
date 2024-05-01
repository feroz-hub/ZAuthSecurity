using Domain.Entities.Api;
using Domain.Models.Api;

namespace DomainServices.Repository.Api;
/// <summary>
/// Interface for accessing identity resources.
/// </summary>
public interface IIdentityResourceRepository
{
    /// <summary>
    /// Retrieves an identity resource asynchronously based on the provided API resource ID or name.
    /// </summary>
    /// <param name="apiResourceId">Optional API resource ID to filter the identity resource.</param>
    /// <param name="apiResourceName">Optional API resource name to filter the identity resource.</param>
    /// <returns>The identity resource corresponding to the provided parameters.</returns>
    Task<IdentityResources> GetIdentityResourceAsync(Guid? apiResourceId = null, string apiResourceName = null);

    /// <summary>
    /// Retrieves all identity resources by scopes asynchronously based on the provided request scopes.
    /// </summary>
    /// <param name="requestScopes">The scopes for which to retrieve identity resources.</param>
    /// <returns>A read-only list of IdentityResourcesByScopesModel objects corresponding to the provided scopes.</returns>
    Task<IReadOnlyList<IdentityResourcesByScopesModel>> GetAllIdentityResourcesByScopesAsync(
        IEnumerable<string> requestScopes);
}
