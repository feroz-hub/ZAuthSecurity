using Domain.Models.Endpoint;

namespace DomainServices.Infra;

/// <summary>
/// Interface defining operations for storing asymmetric security keys.
/// </summary>
public interface IKeyStore
{
    /// <summary>
    /// Adds a collection of security keys to the key store.
    /// </summary>
    /// <param name="securityKeys">The collection of asymmetric key information models to add.</param>
    /// <returns>A dictionary containing the added keys, with their IDs as keys and the key information models as values.</returns>
    Dictionary<string, AsymmetricKeyInfoModel> Add(IEnumerable<AsymmetricKeyInfoModel> securityKeys);
}
