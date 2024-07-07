using Domain;
using DomainServices.UnitOfWork.Api;
using Infrastructure.Data.Repository.Api;

namespace Infrastructure.Data.UnitOfWork.Api;

public class RoleManagementUnitOfWork(IApplicationDbContext dbContext):BaseDispose,IRoleManagementUnitOfWork
{
    public IRoleRepository RoleRepository { get; } = new RoleRepository(dbContext);
    public IRoleClaimsRepository RoleClaimsRepository { get; }
    public Task SetAddedStatusAsync<T>(T entity)
    {
        throw new NotImplementedException();
    }

    public Task SetModifiedStatusAsync<T>(T entity, string concurrencyStamp)
    {
        throw new NotImplementedException();
    }

    public Task<FrameworkResult> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}