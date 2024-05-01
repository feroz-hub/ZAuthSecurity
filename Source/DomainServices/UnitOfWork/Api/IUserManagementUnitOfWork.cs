using Domain;
using Domain.Entities.Api;
using DomainServices.Repository.Api;

namespace DomainServices.UnitOfWork.Api;

/// <summary>
/// Represents a unit of work interface for user management.
/// </summary>
public interface IUserManagementUnitOfWork
{
    /// <summary>
    /// Gets the repository for managing users.
    /// </summary>
    IUserRepository UserRepository { get; }

    /// <summary>
    /// Gets the repository for managing user claims.
    /// </summary>
    IUserClaimRepository UserClaimRepository { get; }

    /// <summary>
    /// Gets the repository for managing user tokens.
    /// </summary>
    IUserTokenRepository UserTokenRepository { get; }

    /// <summary>
    /// Gets the repository for managing user roles.
    /// </summary>
    IUserRoleRepository UserRoleRepository { get; }

    /// <summary>
    /// Gets the repository for managing user security questions.
    /// </summary>
    IRepository<UserSecurityQuestions> UserSecurityQuestionsRepository { get; }

    /// <summary>
    /// Gets the repository for managing notifications.
    /// </summary>
    IRepository<Notification> NotificationRepository { get; }

    /// <summary>
    /// Gets the repository for managing password history.
    /// </summary>
    IRepository<PasswordHistory> PasswordHistoryRepository { get; }

    /// <summary>
    /// Gets the repository for managing security questions.
    /// </summary>
    IRepository<SecurityQuestions> SecurityQuestionsRepository { get; }

    /// <summary>
    /// Asynchronously sets the added status for the specified entity.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    /// <param name="entity">The entity for which to set the added status.</param>
    Task SetAddedStatusAsync<T>(T entity);

    /// <summary>
    /// Asynchronously sets the modified status for the specified entity with concurrency stamp.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    /// <param name="entity">The entity for which to set the modified status.</param>
    /// <param name="concurrencyStamp">The concurrency stamp for optimistic concurrency.</param>
    Task SetModifiedStatusAsync<T>(T entity, string concurrencyStamp);

    /// <summary>
    /// Asynchronously saves changes to the underlying data store.
    /// </summary>
    /// <returns>A task representing the asynchronous operation with a FrameworkResult indicating the outcome.</returns>
    Task<FrameworkResult> SaveChangesAsync();

    /// <summary>
    /// Asynchronously saves changes to the underlying data store with hard delete.
    /// </summary>
    /// <returns>A task representing the asynchronous operation with a FrameworkResult indicating the outcome.</returns>
    Task<FrameworkResult> SaveChangesWithHardDeleteAsync();
}