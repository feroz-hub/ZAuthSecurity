using System.ComponentModel;

namespace Domain.Models.Endpoint.Response;

/// <summary>
/// Domain Model representing Token response.
/// </summary>
public class TokenResponseModel
{
    /// <summary>
    /// Gets or sets a value indicating the token type.
    /// </summary>
    [DisplayName("token_type")]
    public string TokenType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the identity token.
    /// </summary>
    [DisplayName("id_token")]
    public string IdentityToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the access token.
    /// </summary>
    [DisplayName("access_token")]
    public string AccessToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the expiry in unix time.
    /// </summary>
    [DisplayName("expires_in")]
    public int AccessTokenExpiresIn { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the refresh token.
    /// </summary>
    [DisplayName("refresh_token")]
    public string RefreshToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the scope.
    /// </summary>
    [DisplayName("scope")]
    public string Scope { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the state.
    /// </summary>
    [DisplayName("state")]
    public string State { get; set; } = null;
}

/// <summary>
/// Domain Model representing Token response.
/// </summary>
public class TokenResponseResultModel
{
    /// <summary>
    /// Gets or sets a value indicating the identity token.
    /// </summary>
    public string IdToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the access token.
    /// </summary>
    public string AccessToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the expiry in unix time.
    /// </summary>
    public int ExpiresIn { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the token type.
    /// </summary>
    public string TokenType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the refresh token.
    /// </summary>
    public string RefreshToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the scope.
    /// </summary>
    public string Scope { get; set; }
}