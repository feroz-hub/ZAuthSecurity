using Domain;
using Domain.Entities.Endpoint;

namespace DomainServices.UnitOfWork.Endpoint;

/// <summary>
/// Represents a unit of work interface for client management.
/// </summary>
public interface IClientUnitOfWork
{
    /// <summary>
    /// Gets the repository for managing clients.
    /// </summary>
    IRepository<Clients> ClientRepository { get; }
        
    /// <summary>
    /// Gets the repository for managing client post logout redirect URIs.
    /// </summary>
    IRepository<ClientPostLogoutRedirectUris> PostLogoutRedirectUrisRepository { get; }
        
    /// <summary>
    /// Gets the repository for managing client redirect URIs.
    /// </summary>
    IRepository<ClientRedirectUris> RedirectUrisRepository { get; }
        
    /// <summary>
    /// Gets the repository for managing security tokens.
    /// </summary>
    IRepository<SecurityTokens> SecurityTokenRepository { get; }
        
    /// <summary>
    /// Asynchronously saves changes to the underlying data store.
    /// </summary>
    /// <returns>A task representing the asynchronous operation with a FrameworkResult indicating the outcome.</returns>
    Task<FrameworkResult> SaveChangesAsync();
        
    /// <summary>
    /// Asynchronously saves changes to the underlying data store with hard delete.
    /// </summary>
    /// <returns>A task representing the asynchronous operation with a FrameworkResult indicating the outcome.</returns>
    Task<FrameworkResult> SaveChangesWithHardDeleteAsync();
}