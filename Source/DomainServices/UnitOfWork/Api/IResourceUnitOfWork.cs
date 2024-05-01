using Domain;
using Domain.Entities.Api;
using DomainServices.Repository.Api;

namespace DomainServices.UnitOfWork.Api;

 /// <summary>
    /// Represents a unit of work interface for managing resources.
    /// </summary>
    public interface IResourceUnitOfWork
    {
        /// <summary>
        /// Gets the repository for managing base API resources.
        /// </summary>
        IApiResourceRepository BaseApiResourceRepository { get; }
        
        /// <summary>
        /// Gets the repository for managing base identity resources.
        /// </summary>
        IIdentityResourceRepository BaseIdentityResourceRepository { get; }
        
        /// <summary>
        /// Gets the repository for managing API resources.
        /// </summary>
        IRepository<ApiResources> ApiResourcesRepository { get; }
        
        /// <summary>
        /// Gets the repository for managing API resource claims.
        /// </summary>
        IRepository<ApiResourceClaims> ApiResourceClaimsRepository { get; }
        
        /// <summary>
        /// Gets the repository for managing API scopes.
        /// </summary>
        IRepository<ApiScopes> ApiScopesRepository { get; }
        
        /// <summary>
        /// Gets the repository for managing API scope claims.
        /// </summary>
        IRepository<ApiScopeClaims> ApiScopeClaimsRepository { get; }
        
        /// <summary>
        /// Gets the repository for managing identity resources.
        /// </summary>
        IRepository<IdentityResources> IdentityResourcesRepository { get; }
        
        /// <summary>
        /// Gets the repository for managing identity claims.
        /// </summary>
        IRepository<IdentityClaims> IdentityClaimsRepository { get; }
        
        /// <summary>
        /// Asynchronously saves changes to the underlying data store.
        /// </summary>
        /// <returns>A task representing the asynchronous operation with a FrameworkResult indicating the outcome.</returns>
        Task<FrameworkResult> SaveChangesAsync();
        
        /// <summary>
        /// Asynchronously saves changes with hard delete to the underlying data store.
        /// </summary>
        /// <returns>A task representing the asynchronous operation with a FrameworkResult indicating the outcome.</returns>
        Task<FrameworkResult> SaveChangesWithHardDeleteAsync();
    }