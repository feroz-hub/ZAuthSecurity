using System.Security.Cryptography.X509Certificates;
using Domain.Enums;

namespace Domain.Models.Endpoint;

/// <summary>
/// Domain Model representing Asymmetric Key Info.
/// </summary>
public class AsymmetricKeyInfoModel
{
    /// <summary>
    /// Gets or sets KeyId.
    /// </summary>
    public string KeyId { get; set; }

    /// <summary>
    /// Gets or sets Signing Algorithm.
    /// </summary>
    public SigningAlgorithm Algorithm { get; set; }

    /// <summary>
    /// Gets or sets X509Certificate Certificate.
    /// </summary>
    public X509Certificate2 Certificate { get; set; }
}