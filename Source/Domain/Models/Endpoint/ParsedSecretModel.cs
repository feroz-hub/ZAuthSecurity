using Domain.Models.Endpoint.Response;

namespace Domain.Models.Endpoint;

/// <summary>
/// Domain Model representing Parsed secret.
/// </summary>
public class ParsedSecretModel : ErrorResponseModel
{
    /// <summary>
    /// Gets or sets a value indicating the client id.
    /// </summary>
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or sets value indicating the credential.
    /// </summary>
    public object Credential { get; set; }

    /// <summary>
    /// Gets or sets value indicating the secret type.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets value indicating the secret ParseMethods.
    /// </summary>
    public ParseMethods ParseMethod { get; set; }
}