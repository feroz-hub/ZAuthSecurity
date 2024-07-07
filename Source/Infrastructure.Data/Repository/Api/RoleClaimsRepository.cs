using System.Security.Claims;
using Domain;

namespace Infrastructure.Data.Repository.Api;

internal class RoleClaimsRepository:BaseDispose,IRoleClaimsRepository
{
    public async Task InsertAsync(RoleClaims entity)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(RoleClaims entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(int roleClaimId)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid roleId)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(RoleClaims entity)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<RoleClaims>> GetClaimsAsync(Guid roleId)
    {
        throw new NotImplementedException();
    }

    public async Task<int> FindIdByClaimAsync(Guid roleId, Claim claim)
    {
        throw new NotImplementedException();
    }

    public async Task<RoleClaims> FindRoleByClaimAsync(Guid roleId, Claim claim)
    {
        throw new NotImplementedException();
    }

    public async Task<RoleClaims> FindRoleClaimByIdAsync(int roleClaimId)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<UserRoleClaimTypesModel>> GetRolesAndClaimsForUser(Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<FrameworkResult> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}