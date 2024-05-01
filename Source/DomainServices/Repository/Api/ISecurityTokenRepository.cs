using Domain.Enums;
using Domain.Models.Api;
using Domain.Models.Endpoint;

namespace DomainServices.Repository.Api;

public interface ISecurityTokenRepository
{
    /// <summary>
    /// Retrieves security tokens asynchronously based on specified criteria.
    /// </summary>
    /// <param name="page">Paging information for the result.</param>
    /// <param name="option">The security token option specifying the type of tokens to retrieve.</param>
    /// <param name="fromDate">Optional. The start date from which to retrieve tokens.</param>
    /// <param name="toDate">Optional. The end date until which to retrieve tokens.</param>
    /// <param name="clientIds">Optional. The IDs of the clients associated with the tokens.</param>
    /// <param name="userIds">Optional. The IDs of the users associated with the tokens.</param>
    /// <returns>A task representing the asynchronous operation, returning a list of security tokens.</returns>
    Task<IReadOnlyList<TokenModel>> GetSecurityTokenAsync(PagingModel page, SecurityTokenOption option, DateTime? fromDate = null, DateTime? toDate = null, IEnumerable<string> clientIds = null, IEnumerable<string> userIds = null);
}