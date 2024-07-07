namespace Infrastructure.Data.Repository.Api;

internal class IdentityResourceRepository(IApplicationDbContext context) :BaseRepository<IdentityResources>(context),IIdentityResourceRepository
{
    public async Task<IdentityResources> GetIdentityResourceAsync(Guid? apiResourceId = null, string apiResourceName = null)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<IdentityResourcesByScopesModel>> GetAllIdentityResourcesByScopesAsync(IEnumerable<string> requestScopes)
    {
        throw new NotImplementedException();
    }
}