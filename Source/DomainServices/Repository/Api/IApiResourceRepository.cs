using Domain.Entities.Api;
using Domain.Models.Api;

namespace DomainServices.Repository.Api;
/// <summary>
/// Interface for accessing API resources and scopes.
/// </summary>
public interface IApiResourceRepository : IRepository<ApiResources>
{
    /// <summary>
    /// Retrieves an API resource asynchronously based on the provided API resource ID or name.
    /// </summary>
    /// <param name="apiResourceId">Optional API resource ID to filter the API resource.</param>
    /// <param name="apiResourceName">Optional API resource name to filter the API resource.</param>
    /// <returns>The API resource corresponding to the provided parameters.</returns>
    Task<ApiResources> GetApiResourceAsync(Guid? apiResourceId = null, string apiResourceName = null);

    /// <summary>
    /// Retrieves all API resources asynchronously.
    /// </summary>
    /// <returns>A read-only list of all API resources.</returns>
    Task<IReadOnlyList<ApiResources>> GetAllApiResourcesAsync();

    /// <summary>
    /// Retrieves all API scopes asynchronously.
    /// </summary>
    /// <returns>A read-only list of all API scopes.</returns>
    Task<IReadOnlyList<ApiScopes>> GetAllApiScopesAsync();

    /// <summary>
    /// Retrieves API resources by scopes asynchronously based on the provided requested scopes.
    /// </summary>
    /// <param name="requestedScopes">The scopes for which to retrieve API resources.</param>
    /// <returns>A read-only list of ApiResourcesByScopesModel objects corresponding to the provided scopes.</returns>
    Task<IReadOnlyList<ApiResourcesByScopesModel>> GetApiResourcesByScopesAsync(IEnumerable<string> requestedScopes);
}
