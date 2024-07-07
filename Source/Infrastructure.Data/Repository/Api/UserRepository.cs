using Domain;

namespace Infrastructure.Data.Repository.Api;

internal class UserRepository:BaseDispose,IUserRepository
{
    public async Task DeleteAsync(Users entity)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(Users entity, string[] affectedProperties)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<Users>> GetUsersInRoleAsync(string roleName)
    {
        throw new NotImplementedException();
    }

    public async Task SetAddedStatusAsync<T>(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task SetModifiedStatusAsync<T>(T entity, string concurrencyStamp)
    {
        throw new NotImplementedException();
    }

    public async Task<FrameworkResult> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public async Task EnableIdentityAutoSaveChanges()
    {
        throw new NotImplementedException();
    }

    public async Task DisableIdentityAutoSaveChanges()
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<Users>> GetAllUsersAsync()
    {
        throw new NotImplementedException();
    }
}