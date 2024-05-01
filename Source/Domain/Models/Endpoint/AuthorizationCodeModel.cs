using System.Security.Claims;

namespace Domain.Models.Endpoint;

/// <summary>
/// Domain Model representing Authorization Code.
/// </summary>
public class AuthorizationCodeModel
{
    /// <summary>
    /// Gets or sets a Guid.
    /// </summary>
    public virtual Guid Id { get; set; } = default;

    /// <summary>
    /// Gets or sets a State.
    /// </summary>
    public virtual string State { get; set; }

    /// <summary>
    /// Gets or sets a Client Id.
    /// </summary>
    public virtual string ClientId { get; set; }

    /// <summary>
    /// Gets or sets a Redirect Uri.
    /// </summary>
    public virtual string RedirectUri { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether it is OpenId.
    /// </summary>
    public bool IsOpenId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating Creation time.
    /// </summary>
    public DateTime CreationTime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating life time of the authorization code.
    /// </summary>
    public int Lifetime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Subject.
    /// </summary>
    public ClaimsPrincipal Subject { get; set; }

    /// <summary>
    /// Gets or sets a value indicating Nonce.
    /// </summary>
    public string Nonce { get; set; }

    /// <summary>
    /// Gets or sets a value indicating Session Id.
    /// </summary>
    public string SessionId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating CodeChallenge used.
    /// </summary>
    public string CodeChallenge { get; set; }

    /// <summary>
    /// Gets or sets a value indicating CodeChallenge method used.
    /// </summary>
    public string CodeChallengeMethod { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the requested scopes.
    /// </summary>
    public List<string> RequestedScopes { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Scopes parser model used.
    /// </summary>
    public AllowedScopesParserModel AllowedScopesParserModel { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Token Details model used.
    /// </summary>
    public TokenDetailsModel TokenDetails { get; set; }
}