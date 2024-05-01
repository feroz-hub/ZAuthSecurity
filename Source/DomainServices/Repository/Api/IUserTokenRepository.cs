using Domain;
using Domain.Entities.Api;

namespace DomainServices.Repository.Api;

public interface IUserTokenRepository
{
    Task<IReadOnlyList<UserTokens>> GetUserTokenAsync(Guid userId);
    Task<IReadOnlyList<UserTokens>> GetUserTokenAsync(Guid userId, string name, string loginProvider);
    Task DeleteAsync(IEnumerable<UserTokens> entityList);
    Task<FrameworkResult> SaveChangesAsync();
}