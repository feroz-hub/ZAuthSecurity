using Domain;
using Domain.Entities.Api;
using DomainServices.Repository.Api;

namespace DomainServices.UnitOfWork.Api;

public interface IResourceUnitOfWork
{
    IApiResourceRepository BaseApiResourceRepository { get; }
        
    IIdentityResourceRepository BaseIdentityResourceRepository { get; }
    IRepository<ApiResources> ApiResourcesRepository { get; }
    IRepository<ApiResourceClaims> ApiResourceClaimsRepository { get; }
    IRepository<ApiScopes> ApiScopesRepository { get; }
    IRepository<ApiScopeClaims> ApiScopeClaimsRepository { get; }
    IRepository<IdentityResources> IdentityResourcesRepository { get; }
    IRepository<IdentityClaims> IdentityClaimsRepository { get; }
    Task<FrameworkResult> SaveChangesAsync();
    Task<FrameworkResult> SaveChangesWithHardDeleteAsync();
}