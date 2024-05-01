using Domain;
using Domain.Entities.Endpoint;

namespace DomainServices.UnitOfWork.Endpoint;

public interface IClientUnitOfWork
{
    IRepository<Clients> ClientRepository { get; }
    IRepository<ClientPostLogoutRedirectUris> PostLogoutRedirectUrisRepository { get; }
    IRepository<ClientRedirectUris> RedirectUrisRepository { get; }
    IRepository<SecurityTokens> SecurityTokenRepository { get; }
    Task<FrameworkResult> SaveChangesAsync();
    Task<FrameworkResult> SaveChangesWithHardDeleteAsync();
}