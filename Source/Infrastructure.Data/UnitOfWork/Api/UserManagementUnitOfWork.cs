using Domain;
using DomainServices.UnitOfWork.Api;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Data.UnitOfWork.Api;

public class UserManagementUnitOfWork(IApplicationDbContext dbContext,IUserStore<Users> userStoreWrapper):BaseDispose,IUserManagementUnitOfWork
{
    public IUserRepository UserRepository { get; }
    public IUserClaimRepository UserClaimRepository { get; }
    public IUserTokenRepository UserTokenRepository { get; }
    public IUserRoleRepository UserRoleRepository { get; }
    public IRepository<UserSecurityQuestions> UserSecurityQuestionsRepository { get; }
    public IRepository<Notification> NotificationRepository { get; }
    public IRepository<PasswordHistory> PasswordHistoryRepository { get; }
    public IRepository<SecurityQuestions> SecurityQuestionsRepository { get; }
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

    public Task<FrameworkResult> SaveChangesWithHardDeleteAsync()
    {
        throw new NotImplementedException();
    }
}