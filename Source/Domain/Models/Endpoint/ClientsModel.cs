namespace Domain.Models.Endpoint;

/// <summary>
/// Domain model representing the Clients.
/// </summary>
public class ClientsModel : BaseModel
{
    /// <summary>
    /// Gets or sets the Client Identifier.
    /// </summary>
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or sets the Client Name.
    /// </summary>
    public string ClientName { get; set; }

    /// <summary>
    /// Gets or sets the Client Uri.
    /// </summary>
    public string ClientUri { get; set; }

    /// <summary>
    /// Gets or sets the time (UnixSeconds) at which the ClientId is issued.
    /// </summary>
    public DateTime ClientIdIssuedAt { get; set; }

    /// <summary>
    /// Gets or sets the time (UnixSeconds) at which the ClientId expires.
    /// </summary>
    public DateTime ClientSecretExpiresAt { get; set; }

    /// <summary>
    /// Gets or sets the Client secret.
    /// </summary>
    public string ClientSecret { get; set; }

    /// <summary>
    /// Gets or sets the Logo Uri.
    /// </summary>
    public string LogoUri { get; set; }

    /// <summary>
    /// Gets or sets the TermsOfService Uri.
    /// </summary>
    public string TermsOfServiceUri { get; set; }

    /// <summary>
    /// Gets or sets the Policy Uri.
    /// </summary>
    public string PolicyUri { get; set; }

    /// <summary>
    /// Gets or sets the time (seconds) at which the RefreshToken expires.
    /// Default is 18000 seconds i.e. 5 hours.
    /// </summary>
    public int RefreshTokenExpiration { get; set; } = 86400;

    /// <summary>
    /// Gets or sets the time (seconds) at which the AccessToken expires.
    /// Default is 3600 seconds i.e. 1 hour.
    /// </summary>
    public int AccessTokenExpiration { get; set; } = 3600;

    /// <summary>
    /// Gets or sets the time (seconds) at which the IdentityToken expires.
    /// Default is 3600 seconds i.e. 1 hour.
    /// </summary>
    public int IdentityTokenExpiration { get; set; } = 3600;

    /// <summary>
    /// Gets or sets the time (seconds) at which the logout token expires.
    /// Default is 300 seconds i.e. 5 min.
    /// </summary>
    public int LogoutTokenExpiration { get; set; } = 1800;

    /// <summary>
    /// Gets or sets the time (seconds) at which the Authorization Code expires.
    /// Default is 600 seconds i.e. 10 minutes.
    /// </summary>
    public int AuthorizationCodeExpiration { get; set; } = 1800;

    /// <summary>
    /// Gets or sets the Type of the AccessToken i.e. JWT or Reference.
    /// Currently in Security framework only self contained JWT tokens are supported in V1 release.
    /// </summary>
    public AccessTokenType AccessTokenType { get; set; } = AccessTokenType.Jwt;

    /// <summary>
    /// Gets or sets a value indicating whether clients using authorization code based grant type must send PKCE (defaults to true).
    /// Proof Key for Code Exchange(PKCE) is used to mitigate threat of having the authorization code intercepted.
    /// </summary>
    public bool RequirePkce { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether clients using PKCE can use plain text code challenge (not recommended - and defaults to false).
    /// </summary>
    public bool IsPkceTextPlain { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether client secret is required/mandatory for the client.
    /// </summary>
    public bool RequireClientSecret { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether the client application that is registered is a first party app or a third party app. Defaults to true.
    /// For first party app, it will be open registration. Only for third party apps, dynamic client registration is applicable which is planned for V2 release.
    /// </summary>
    public bool IsFirstPartyApp { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether Client is allowed to use refresh token.
    /// </summary>
    public bool AllowOfflineAccess { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether access tokens are allowed to be shared via browser.
    /// This is used in hybrid flow where a client is not allowed to add the token response type if it is not configured and thus leaking token to the browser.
    /// </summary>
    public bool AllowAccessTokensViaBrowser { get; set; }

    /// <summary>
    /// Gets or sets the ApplicationType of the client.
    /// </summary>
    public ApplicationType ApplicationType { get; set; }

    /// <summary>
    /// Gets or sets the allowed signing algorithm for the client. Defaults to HmacSha256 algorithm.
    /// </summary>
    public string AllowedSigningAlgorithm { get; set; } = OpenIdConstants.Algorithms.HmacSha256;

    /// <summary>
    /// Gets or sets a value indicating whether FrontChannel Logout session required for the Client.
    /// </summary>
    public bool FrontChannelLogoutSessionRequired { get; set; } = false;

    /// <summary>
    /// Gets or sets the FrontChannel Logout Uri for the Client.
    /// </summary>
    public string FrontChannelLogoutUri { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether BackChannel Logout session required for the Client.
    /// </summary>
    public bool BackChannelLogoutSessionRequired { get; set; }

    /// <summary>
    /// Gets or sets the BackChannel Logout Uri for the Client.
    /// </summary>
    public string BackChannelLogoutUri { get; set; }

    /// <summary>
    /// Gets or sets the supported grant types for client as space separated strings.
    /// </summary>
    public List<string> SupportedGrantTypes { get; set; }

    /// <summary>
    /// Gets or sets the supported response types for client as space separated strings.
    /// </summary>
    public List<string> SupportedResponseTypes { get; set; }

    /// <summary>
    /// Gets or sets the allowed Scopes for client as space separated strings.
    /// </summary>
    public List<string> AllowedScopes { get; set; }

    /// <summary>
    /// Gets or sets the list of client Redirect Uris.
    /// </summary>
    public List<ClientRedirectUrisModel> RedirectUris { get; set; }

    /// <summary>
    /// Gets or sets the list of Post Logout Redirect Uris for the client.
    /// </summary>
    public List<ClientPostLogoutRedirectUrisModel> PostLogoutRedirectUris { get; set; }
}