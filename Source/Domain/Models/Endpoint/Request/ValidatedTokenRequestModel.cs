using Domain.Models.Endpoint.Validation;

namespace Domain.Models.Endpoint.Request;

/// <summary>
/// Domain Model representing Validated token Request.
/// </summary>
public class ValidatedTokenRequestModel : ValidatedBaseModel
{
    /// <summary>
    /// Gets or sets the Issuer.
    /// </summary>
    public string Issuer { get; set; }

    /// <summary>
    /// Gets or sets the Nonce.
    /// </summary>
    public string Nonce { get; set; }

    /// <summary>
    /// Gets or sets the State.
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// Gets or sets the GrantType.
    /// </summary>
    public string GrantType { get; set; }

    /// <summary>
    /// Gets or sets the UserName.
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// Gets or sets the Requested Refresh Token.
    /// </summary>
    public string RequestedRefreshToken { get; set; }

    /// <summary>
    /// Gets or sets the Authorization code.
    /// </summary>
    public AuthorizationCodeModel AuthorizationCode { get; set; }

    /// <summary>
    /// Gets or sets the Access Token to hash.
    /// </summary>
    public string AccessTokenToHash { get; set; }

    /// <summary>
    /// Gets or sets the Authorization Code to hash.
    /// </summary>
    public string AuthorizationCodeToHash { get; set; }

    /// <summary>
    /// Gets or sets the CodeVerifier.
    /// </summary>
    public string CodeVerifier { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this request is from authorization endpoint.
    /// </summary>
    public bool IsRequestFromAuthorizationEndpoint { get; set; } = false;

    /// <summary>
    /// Gets or sets List of Response types.
    /// </summary>
    public List<string> ResponseTypes { get; set; }

    /// <summary>
    /// Gets or sets Token details.
    /// </summary>
    public TokenDetailsModel TokenDetails { get; set; }
}