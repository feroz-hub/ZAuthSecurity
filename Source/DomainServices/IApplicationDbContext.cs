using Domain;
using Domain.Entities.Api;
using Domain.Entities.Endpoint;
using Microsoft.EntityFrameworkCore;

namespace DomainServices;

public interface IApplicationDbContext
{
    DbSet<T>Set<T>() where T:BaseEntity;
    DbSet<AuditTrail> AuditTrail{get; set;}
    DbSet<SecurityQuestions> SecurityQuestions{get; set;}
    DbSet<UserSecurityQuestions> UserSecurityQuestions{get; set;}
    DbSet<PasswordHistory> PasswordHistory{get; set;}
    DbSet<Users> Users{get; set;}
    DbSet<UserClaims> UserClaims{get; set;}
    DbSet<UserLogins> UserLogins{get; set;}
    DbSet<UserTokens> UserTokens{get; set;}
    DbSet<Roles> Roles{get; set;}
    DbSet<RoleClaims> RoleClaims{get; set;}
    DbSet<UserRoles> UserRoles{get; set;}
    DbSet<Clients> Clients{get; set;}
    DbSet<Notification> Notification{get; set;}
    DbSet<ApiResources> ApiResources{get; set;}
    DbSet<ApiResourceClaims> ApiResourceClaims{get; set;}
    DbSet<ApiScopes> ApiScopes{get; set;}
    DbSet<ApiScopeClaims> ApiScopesClaims{get; set;}
    DbSet<IdentityResources> IdentityResources{get; set;}
    DbSet<IdentityClaims> IdentityClaims{get; set;}
    DbSet<SecurityTokens> SecurityTokens{get; set;}
    Task<FrameworkResult> SaveChangesAsync();
    Task<FrameworkResult> SaveChangesWithHardDeleteAsync();
    void SetAddedStatus(object entry);
    void SetModifiedStatus(object entry);
    void SetPropertyModifiedStatus(object entry,string property);
    void SetConcurrencyStatus(object entry, string dbConcurrencyStamp);
    void SetRowVersion(object entry,byte[] rowVersion);
}