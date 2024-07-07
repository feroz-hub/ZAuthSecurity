using Domain;

namespace Infrastructure.Data.Repository.Api;

internal class RoleRepository(IApplicationDbContext dbContext):BaseDispose,IRoleRepository
{
    public async Task UpdateAsync(Roles entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Roles entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<Roles>> GetAllRolesAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<FrameworkResult> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}