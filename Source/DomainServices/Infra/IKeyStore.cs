using Domain.Models.Endpoint;

namespace DomainServices.Infra;

public interface IKeyStore
{
    Dictionary<string, AsymmetricKeyInfoModel> Add(IEnumerable<AsymmetricKeyInfoModel> securityKeys);
}