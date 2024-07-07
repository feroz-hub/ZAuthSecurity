namespace Domain.Configurations.Endpoint;

/// <summary>
/// Configuration settings related to input length restrictions for various endpoints.
/// </summary>
public class InputLengthRestrictionsConfig
{
    private const int DefaultValue = 255;

    /// <summary>
    /// Gets or sets the maximum length for the client ID.
    /// </summary>
    public int ClientId { get; set; } = DefaultValue;

    /// <summary>
    /// Gets or sets the maximum length for the client secret.
    /// </summary>
    public int ClientSecret { get; set; } = DefaultValue;

    /// <summary>
    /// Gets or sets the maximum length for the scope.
    /// </summary>
    public int Scope { get; set; } = 700;

    /// <summary>
    /// Gets or sets the maximum length for the redirect URI.
    /// </summary>
    public int RedirectUri { get; set; } = DefaultValue;

    /// <summary>
    /// Gets or sets the maximum length for the nonce.
    /// </summary>
    public int Nonce { get; set; } = 20;

    /// <summary>
    /// Gets or sets the maximum length for the grant type.
    /// </summary>
    public int GrantType { get; set; } = DefaultValue;

    /// <summary>
    /// Gets or sets the maximum length for the username.
    /// </summary>
    public int UserName { get; set; } = DefaultValue;

    /// <summary>
    /// Gets or sets the maximum length for the password.
    /// </summary>
    public int Password { get; set; } = DefaultValue;

    /// <summary>
    /// Gets or sets the maximum length for the authorization code.
    /// </summary>
    public int AuthorizationCode { get; set; } = 512;

    /// <summary>
    /// Gets or sets the maximum length for the refresh token.
    /// </summary>
    public int RefreshToken { get; set; } = 512;

    /// <summary>
    /// Gets or sets the maximum length for the JWT (JSON Web Token).
    /// </summary>
    public int Jwt { get; set; } = 51200;

    /// <summary>
    /// Gets or sets the minimum length for the code challenge.
    /// </summary>
    public int CodeChallengeMinLength { get; set; } = 43;

    /// <summary>
    /// Gets or sets the maximum length for the code challenge.
    /// </summary>
    public int CodeChallengeMaxLength { get; set; } = 128;

    /// <summary>
    /// Gets or sets the minimum length for the code verifier.
    /// </summary>
    public int CodeVerifierMinLength { get; set; } = 43;

    /// <summary>
    /// Gets or sets the maximum length for the code verifier.
    /// </summary>
    public int CodeVerifierMaxLength { get; set; } = 128;
}