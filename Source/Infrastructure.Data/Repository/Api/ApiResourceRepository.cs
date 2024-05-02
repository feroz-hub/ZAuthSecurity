using Domain.Entities.Api;
using Domain.Models.Api;
using DomainServices;
using DomainServices.Repository.Api;

namespace Infrastructure.Data.Repository.Api;

internal class ApiResourceRepository(IApplicationDbContext context) :BaseRepository<ApiResources>(context),IApiResourceRepository
{
    public async Task<ApiResources> GetApiResourceAsync(Guid? apiResourceId = null, string apiResourceName = null)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<ApiResources>> GetAllApiResourcesAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<ApiScopes>> GetAllApiScopesAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<ApiResourcesByScopesModel>> GetApiResourcesByScopesAsync(IEnumerable<string> requestedScopes)
    {
        throw new NotImplementedException();
    }
}