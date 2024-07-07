using Domain;

namespace Infrastructure.Data.Repository.Api;

internal class UserTokenRepository:BaseDispose,IUserTokenRepository
{
    public async Task<IReadOnlyList<UserTokens>> GetUserTokenAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<UserTokens>> GetUserTokenAsync(Guid userId, string name, string loginProvider)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(IEnumerable<UserTokens> entityList)
    {
        throw new NotImplementedException();
    }

    public async Task<FrameworkResult> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}