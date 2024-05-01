using Domain;
using Domain.Entities.Api;

namespace DomainServices.Repository.Api;

public interface IUserRepository
{
    Task DeleteAsync(Users entity);
    Task UpdateAsync(Users entity, string[] affectedProperties);
    Task<IReadOnlyList<Users>> GetUsersInRoleAsync(string roleName);
    Task SetAddedStatusAsync<T>(T entity);
    Task SetModifiedStatusAsync<T>(T entity, string concurrencyStamp);
    Task<FrameworkResult> SaveChangesAsync();
    Task EnableIdentityAutoSaveChanges();
    Task DisableIdentityAutoSaveChanges();
    Task<IReadOnlyList<Users>> GetAllUsersAsync();
}