using System.Security.Claims;
using Domain;
using Domain.Entities.Api;

namespace DomainServices.Repository.Api;

public interface IUserClaimRepository
{
    Task InsertAsync(UserClaims entity);
    Task UpdateAsync(UserClaims entity);
    Task DeleteAsync(int id);
    Task DeleteAsync(IEnumerable<UserClaims> entityList);
    Task<UserClaims> FindIdByClaimAsync(Guid userId, Claim claim, bool isAdminClaim = false);
    Task<UserClaims> FindUserClaimByIdAsync(int userClaimId);
    Task<IReadOnlyList<UserClaims>> GetClaimsAsync(Guid userId);
    Task<IReadOnlyList<UserClaims>> GetAdminUserClaimsAsync(Guid userId, bool getOnlyAdminClaim = true);
    Task<FrameworkResult> SaveChangesAsync();
}