using System.Security.Claims;
using Domain.Models.Endpoint.Validation;

namespace Domain.Models.Endpoint.Request;

/// <summary>
/// Domain Model representing Validated Authorize Request.
/// </summary>
public class ValidatedAuthorizeRequestModel : ValidatedBaseModel
{
    /// <summary>
    /// Gets or sets a value indication response type.
    /// </summary>
    public string ResponseType { get; set; }

    /// <summary>
    /// Gets or sets a value indication Response Mode.
    /// </summary>
    public string ResponseMode { get; set; }

    /// <summary>
    /// Gets or sets a value indicating Grant Type.
    /// </summary>
    public string GrantType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating requested scopes.
    /// </summary>
    public List<string> RequestedScopes { get; set; }

    /// <summary>
    /// Gets or sets a value indicating state.
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// Gets or sets a value indicating  whether it Is a OpenId request.
    /// </summary>
    public bool IsOpenIdRequest { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether it is a api resource request.
    /// </summary>
    public bool IsApiResourceRequest { get; set; }

    /// <summary>
    /// Gets or sets a value indicating response type.
    /// </summary>
    public string Nonce { get; set; }

    /// <summary>
    /// Gets or sets a value indicating Authentication context reference classes.
    /// </summary>
    public List<string> AuthenticationContextReferenceClasses { get; set; }

    /// <summary>
    /// Gets or sets a value indicating prompt modes.
    /// </summary>
    public IEnumerable<string> PromptModes { get; set; } = Enumerable.Empty<string>();

    /// <summary>
    /// Gets or sets a value indicating Max age.
    /// </summary>
    public int? MaxAge { get; set; }

    /// <summary>
    /// Gets or sets a value indicating code challenge.
    /// </summary>
    public string CodeChallenge { get; set; }

    /// <summary>
    /// Gets or sets a value indicating code challenge method.
    /// </summary>
    public string CodeChallengeMethod { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the user who is the claims principal.
    /// </summary>
    public ClaimsPrincipal User { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ValidatedAuthorizeRequestModel"/> class.
    /// </summary>
    public ValidatedAuthorizeRequestModel()
    {
        RequestedScopes = [];
        AuthenticationContextReferenceClasses = [];
    }
}