using System.Security.Claims;

namespace Domain.Models.Endpoint;


/// <summary>
/// Domain model representing the result claims during token generation.
/// </summary>
public class ResultClaimsModel
{
    /// <summary>
    /// Gets or sets a value indicating the role claims during token generation.
    /// </summary>
    public virtual List<Claim> RoleClaims { get; set; }
    /// <summary>
    /// Gets or sets a value indicating the Audience claims during token generation.
    /// </summary>
    public virtual List<Claim> AudienceClaims { get; set; }
    /// <summary>
    /// Gets or sets a value indicating the scope claims during token generation.
    /// </summary>
    public virtual List<Claim> IdentityTokenScopeClaims { get; set; }
    /// <summary>
    /// Gets or sets a value indicating the scope claims during token generation.
    /// </summary>
    public virtual List<Claim> AccessTokenScopeClaims { get; set; }
    /// <summary>
    /// Gets or sets a value indicating the Identity claims during token generation.
    /// </summary>
    public virtual List<Claim> IdentityClaims { get; set; }
    /// <summary>
    /// Gets or sets a value indicating the transaction claims during token generation.
    /// </summary>
    public virtual List<Claim> TransactionClaims { get; set; }
    /// <summary>
    /// Gets or sets a value indicating the permission claims during token generation.
    /// </summary>
    public virtual List<Claim> PermissionClaims { get; set; }
    /// <summary>
    /// Gets the combined list of all access token claims.
    /// </summary>
    public List<Claim> AccessTokenClaims
    {
        get
        {
            var accessTokenClaims = new List<Claim>();
            accessTokenClaims.AddRange(IdentityTokenScopeClaims);
            accessTokenClaims.AddRange(RoleClaims);
            accessTokenClaims.AddRange(TransactionClaims);
            accessTokenClaims.AddRange(PermissionClaims);
            return accessTokenClaims;
        }
    }
}