using Domain;
using DomainServices.UnitOfWork.Api;
using Infrastructure.Data.Repository.Api;

namespace Infrastructure.Data.UnitOfWork.Api;

public class ResourceUnitOfWork(IApplicationDbContext dbContext):BaseDispose,IResourceUnitOfWork
{
    public IApiResourceRepository BaseApiResourceRepository { get; } = new ApiResourceRepository(dbContext);
    public IIdentityResourceRepository BaseIdentityResourceRepository { get; }=new IdentityResourceRepository(dbContext);
    public IRepository<ApiResources> ApiResourcesRepository { get; }=new BaseRepository<ApiResources>(dbContext);
    public IRepository<ApiResourceClaims> ApiResourceClaimsRepository { get; }=new BaseRepository<ApiResourceClaims>(dbContext);
    public IRepository<ApiScopes> ApiScopesRepository { get; }=new BaseRepository<ApiScopes>(dbContext);
    public IRepository<ApiScopeClaims> ApiScopeClaimsRepository { get; }=new BaseRepository<ApiScopeClaims>(dbContext);
    public IRepository<IdentityResources> IdentityResourcesRepository { get; }=new BaseRepository<IdentityResources>(dbContext);
    public IRepository<IdentityClaims> IdentityClaimsRepository { get; } =
        new BaseRepository<IdentityClaims>(dbContext);
    public async Task<FrameworkResult> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }

    public async Task<FrameworkResult> SaveChangesWithHardDeleteAsync()
    {
        return await dbContext.SaveChangesWithHardDeleteAsync();
    }
}