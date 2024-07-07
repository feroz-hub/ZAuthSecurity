using System.Security.Claims;
using Domain.Models.Endpoint.Response;

namespace Domain.Models.Endpoint.Validation;

/// <summary>
/// Domain Model representing the validated base model.
/// </summary>
public class ValidatedBaseModel : ErrorResponseModel
{
    /// <summary>
    /// Gets or sets the value indicating the data coming as request.
    /// </summary>
    public Dictionary<string, string> RequestRawData { get; set; }

    /// <summary>
    /// Gets or sets the value indicating Client Id.
    /// </summary>
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or sets the value indicating client.
    /// </summary>
    public ClientsModel Client { get; set; }

    /// <summary>
    /// Gets or sets the value indicating the Parsed secret model.
    /// </summary>
    public ParsedSecretModel Secret { get; set; }

    /// <summary>
    /// Gets or sets the value indicating Access token expiration.
    /// </summary>
    public int AccessTokenExpiration { get; set; }

    /// <summary>
    /// Gets or sets the value indicating the Access token type.
    /// </summary>
    public AccessTokenType AccessTokenType { get; set; }

    /// <summary>
    /// Gets or sets the value indicating the Subject as claims principal.
    /// </summary>
    public ClaimsPrincipal Subject { get; set; }

    /// <summary>
    /// Gets or sets the value indicating the Session id.
    /// </summary>
    public string SessionId { get; set; }

    /// <summary>
    /// Gets or sets the value indicating the token configuration options.
    /// </summary>
    public TokenSettings TokenConfigOptions { get; set; }

    /// <summary>
    /// Gets or sets the value indicating Allowed scopes parser model.
    /// </summary>
    public AllowedScopesParserModel AllowedScopesParserModel { get; set; }

    /// <summary>
    /// Gets or sets the value indicating redirect uri.
    /// </summary>
    public string RedirectUri { get; set; }

    /// <summary>
    /// Gets or sets the base url of the current endpoint.
    /// </summary>
    public string EndpointBaseUrl { get; set; }

    /// <summary>
    /// Method to set the client options.
    /// </summary>
    /// <param name="client">The client model.</param>
    /// <param name="secret">The parsed secret of the client.</param>
    public void SetClient(ClientsModel client, ParsedSecretModel secret = null)
    {
        Client = client ?? throw new ArgumentNullException(nameof(client));
        Secret = secret;
        ClientId = client.ClientId;

        AccessTokenExpiration = client.AccessTokenExpiration;
        AccessTokenType = client.AccessTokenType;
    }
}