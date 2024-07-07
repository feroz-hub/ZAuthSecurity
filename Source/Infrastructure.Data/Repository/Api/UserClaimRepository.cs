using System.Security.Claims;
using Domain;

namespace Infrastructure.Data.Repository.Api;

internal class UserClaimRepository:BaseDispose,IUserClaimRepository
    
{
    public async Task InsertAsync(UserClaims entity)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(UserClaims entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(IEnumerable<UserClaims> entityList)
    {
        throw new NotImplementedException();
    }

    public async Task<UserClaims> FindIdByClaimAsync(Guid userId, Claim claim, bool isAdminClaim = false)
    {
        throw new NotImplementedException();
    }

    public async Task<UserClaims> FindUserClaimByIdAsync(int userClaimId)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<UserClaims>> GetClaimsAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<UserClaims>> GetAdminUserClaimsAsync(Guid userId, bool getOnlyAdminClaim = true)
    {
        throw new NotImplementedException();
    }

    public async Task<FrameworkResult> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}