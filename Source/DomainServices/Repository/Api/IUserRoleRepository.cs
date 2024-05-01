using Domain;
using Domain.Entities.Api;

namespace DomainServices.Repository.Api;

public interface IUserRoleRepository
{
    Task InsertAsync(UserRoles entity);
    Task UpdateAsync(UserRoles entity);
    Task DeleteAsync(UserRoles entity);
    Task DeleteAsync(IEnumerable<UserRoles> entityList);
    Task<UserRoles> GetUserRoleAsync(Guid userId, Guid roleId);
    Task<IReadOnlyList<UserRoles>> GetUserRoleAsync(Guid userId);
    Task<FrameworkResult> SaveChangesAsync();
}