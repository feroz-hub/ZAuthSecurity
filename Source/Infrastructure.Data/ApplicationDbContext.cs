using Domain;
using Domain.Entities.Endpoint;
using Infrastructure.Data.Repository.Api;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApplicationDbContext:IdentityDbContext<Users,Roles,Guid,UserClaims,UserRoles,UserLogins,RoleClaims,UserTokens>,IApplicationDbContext
{
    public DbSet<T> Set<T>() where T : BaseEntity
    {
        throw new NotImplementedException();
    }

    public DbSet<AuditTrail> AuditTrail { get; set; }
    public DbSet<SecurityQuestions> SecurityQuestions { get; set; }
    public DbSet<UserSecurityQuestions> UserSecurityQuestions { get; set; }
    public DbSet<PasswordHistory> PasswordHistory { get; set; }
    public DbSet<Clients> Clients { get; set; }
    public DbSet<Notification> Notification { get; set; }
    public DbSet<ApiResources> ApiResources { get; set; }
    public DbSet<ApiResourceClaims> ApiResourceClaims { get; set; }
    public DbSet<ApiScopes> ApiScopes { get; set; }
    public DbSet<ApiScopeClaims> ApiScopesClaims { get; set; }
    public DbSet<IdentityResources> IdentityResources { get; set; }
    public DbSet<IdentityClaims> IdentityClaims { get; set; }
    public DbSet<SecurityTokens> SecurityTokens { get; set; }
    public Task<FrameworkResult> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<FrameworkResult> SaveChangesWithHardDeleteAsync()
    {
        throw new NotImplementedException();
    }

    public void SetAddedStatus(object entry)
    {
        throw new NotImplementedException();
    }

    public void SetModifiedStatus(object entry)
    {
        throw new NotImplementedException();
    }

    public void SetPropertyModifiedStatus(object entry, string property)
    {
        throw new NotImplementedException();
    }

    public void SetConcurrencyStatus(object entry, string dbConcurrencyStamp)
    {
        throw new NotImplementedException();
    }

    public void SetRowVersion(object entry, byte[] rowVersion)
    {
        throw new NotImplementedException();
    }
}