using System.IdentityModel.Tokens.Jwt;
using Domain.Models.Endpoint.Validation;
using Microsoft.IdentityModel.Tokens;

namespace Domain.Models.Endpoint.Request;

/// <summary>
/// Domain Model representing Validated Introspection Request.
/// </summary>
public class ValidatedIntrospectionRequestModel : ValidatedBaseModel
{
    /// <summary>
    /// Gets or sets a value indicating Whether the token is active. Defaults to true.
    /// </summary>
    public bool Active { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating the Client scopes as space separated string.
    /// </summary>
    public string Scopes { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the list of claims.
    /// </summary>
    public SecurityKey Key { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the list of claims.
    /// </summary>
    public JwtSecurityToken DecodedToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the list of claims.
    /// </summary>
    public string TokenType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the user name.
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating when the token expires at.
    /// </summary>
    public long ExpiresAt { get; set; }

    /// <summary>
    /// Gets or sets a value indicating when the toker issued at.
    /// </summary>
    public long IssuedAt { get; set; }

}