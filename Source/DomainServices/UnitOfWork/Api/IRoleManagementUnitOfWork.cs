using Domain;
using DomainServices.Repository.Api;

namespace DomainServices.UnitOfWork.Api;

public interface IRoleManagementUnitOfWork
{
    IRoleRepository RoleRepository { get; }
    IRoleClaimsRepository RoleClaimsRepository { get; }
    Task SetAddedStatusAsync<T>(T entity);
    Task SetModifiedStatusAsync<T>(T entity, string concurrencyStamp);
    Task<FrameworkResult> SaveChangesAsync();
}