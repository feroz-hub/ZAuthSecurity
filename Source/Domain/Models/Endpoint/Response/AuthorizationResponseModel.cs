using System.ComponentModel;
using Domain.Models.Endpoint.Request;

namespace Domain.Models.Endpoint.Response;

/// <summary>
/// Domain Model representing Authorization response.
/// </summary>
public class AuthorizationResponseModel : ErrorResponseModel
{
    /// <summary>
    /// Gets or sets a value indicating the validated authorize request model.
    /// </summary>
    public ValidatedAuthorizeRequestModel Request { get; set; }

    /// <summary>
    /// Gets a value indicating the redirect uri.
    /// </summary>
    [DisplayName("redirect_uri")]
    public string RedirectUri => Request?.RedirectUri;

    /// <summary>
    /// Gets a value indicating the requested state.
    /// </summary>
    [DisplayName("state")]
    public string State => Request?.State;

    /// <summary>
    /// Gets or sets a value indicating the scope.
    /// </summary>
    [DisplayName("scope")]
    public string Scope { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Identity token.
    /// </summary>
    [DisplayName("id_token")]
    public string IdentityToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Access token.
    /// </summary>
    [DisplayName("access_token")]
    public string AccessToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the refresh token.
    /// </summary>
    [DisplayName("refresh_token")]
    public string RefreshToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Access token lifetime .
    /// </summary>
    public int AccessTokenLifetime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Authorization code.
    /// </summary>
    [DisplayName("code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Session state.
    /// </summary>
    [DisplayName("session_state")]
    public string SessionState { get; set; }
}