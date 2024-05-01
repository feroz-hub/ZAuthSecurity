using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Domain.Models.Endpoint.Validation;
using Microsoft.IdentityModel.Tokens;

namespace Domain.Models.Endpoint.Request;

/// <summary>
/// Domain Model representing Validated User info Request.
/// </summary>
public class ValidatedUserInfoRequestModel : ValidatedBaseModel
{
    /// <summary>
    /// Gets or sets a value indicating the list of claims.
    /// </summary>
    public List<Claim> Claims { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Token.
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Security Key.
    /// </summary>
    public SecurityKey Key { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Decoded token.
    /// </summary>
    public JwtSecurityToken DecodedToken { get; set; }
}