namespace Infrastructure.Data.Repository.Api;

internal class AuditRepository(IApplicationDbContext context) :BaseRepository<AuditTrail>(context),IAuditRepository
{
    public async Task<int> GetTotalCountAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyList<AuditTrail>> GetAuditDetailsAsync(AuditSearchRequestModel auditSearchRequestModel)
    {
        throw new NotImplementedException();
    }
}