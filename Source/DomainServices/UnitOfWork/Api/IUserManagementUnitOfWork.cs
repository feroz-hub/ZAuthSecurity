using Domain;
using Domain.Entities.Api;
using DomainServices.Repository.Api;

namespace DomainServices.UnitOfWork.Api;

public interface IUserManagementUnitOfWork
{
    IUserRepository UserRepository { get; }
    IUserClaimRepository UserClaimRepository { get; }
    IUserTokenRepository UserTokenRepository { get; }
    IUserRoleRepository UserRoleRepository { get; }
    IRepository<UserSecurityQuestions> UserSecurityQuestionsRepository { get; }
    IRepository<Notification> NotificationRepository { get; }
    IRepository<PasswordHistory> PasswordHistoryRepository { get; }
    IRepository<SecurityQuestions> SecurityQuestionsRepository { get; }
    Task SetAddedStatusAsync<T>(T entity);
    Task SetModifiedStatusAsync<T>(T entity, string concurrencyStamp);
    Task<FrameworkResult> SaveChangesAsync();
    Task<FrameworkResult> SaveChangesWithHardDeleteAsync();
}