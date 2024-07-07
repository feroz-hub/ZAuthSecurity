using Domain.Enums;
using Domain.Models.Endpoint;

namespace Infrastructure.Data.Repository.EndPoint;

public class SecurityTokenRepository:ISecurityTokenRepository
{
    public async Task<IReadOnlyList<TokenModel>> GetSecurityTokenAsync(PagingModel page, SecurityTokenOption option, DateTime? fromDate = null,
        DateTime? toDate = null, IEnumerable<string> clientIds = null, IEnumerable<string> userIds = null)
    {
        throw new NotImplementedException();
    }
}