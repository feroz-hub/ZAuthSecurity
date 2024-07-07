using Domain;

namespace Infrastructure.Data.Repository.Api;

internal class UserRoleRepository:BaseDispose,IUserRoleRepository
{
    public async Task InsertAsync(UserRoles entity)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(UserRoles entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(UserRoles entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(IEnumerable<UserRoles> entityList)
    {
        throw new NotImplementedException();
    }

    public async Task<UserRoles> GetUserRoleAsync(Guid userId, Guid roleId)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<UserRoles>> GetUserRoleAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<FrameworkResult> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}