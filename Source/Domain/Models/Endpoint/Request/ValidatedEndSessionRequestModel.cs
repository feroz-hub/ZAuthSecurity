using System.IdentityModel.Tokens.Jwt;
using Domain.Models.Endpoint.Validation;
using Microsoft.IdentityModel.Tokens;

namespace Domain.Models.Endpoint.Request;

/// <summary>
/// Domain Model representing Validated EndSession Request.
/// </summary>
public class ValidatedEndSessionRequestModel : ValidatedBaseModel
{
    /// <summary>
    /// Gets or sets the value indicating the security key.
    /// </summary>
    public SecurityKey Key { get; set; }

    /// <summary>
    /// Gets or sets the value indicating the SubjectId.
    /// </summary>
    public string SubjectId { get; set; }

    /// <summary>
    /// Gets or sets the value indicating the Decoded Token.
    /// </summary>
    public JwtSecurityToken DecodedToken { get; set; }

    /// <summary>
    /// Gets or sets the value indicating the when the key Expires at.
    /// </summary>
    public long ExpiresAt { get; set; }

    /// <summary>
    /// Gets or sets the value indicating the Post LogOut Uri.
    /// </summary>
    public string PostLogOutUri { get; set; }

    /// <summary>
    /// Gets or sets the value indicating the State.
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// Gets or sets the value indicating the list of client ids.
    /// </summary>
    public IEnumerable<string> ClientIds { get; set; }
}