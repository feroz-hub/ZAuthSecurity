using System.Security.Claims;
using Domain.Models.Endpoint.Request;
using Domain.Models.Endpoint.Response;

namespace Domain.Models.Endpoint.Validation;

/// <summary>
/// Domain Model representing Resource Owner Password validation.
/// </summary>
public class RopValidationModel : ErrorResponseModel
{
    /// <summary>
    /// Gets or sets a value indicating the User Name.
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Password.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the validated token request model.
    /// </summary>
    public ValidatedTokenRequestModel Request { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Subject which is the Claims principal.
    /// </summary>
    public ClaimsPrincipal Subject { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="RopValidationModel"/> class.
    /// </summary>
    public RopValidationModel()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RopValidationModel"/> class.
    /// </summary>
    /// <param name="principal">The claims principal.</param>
    public RopValidationModel(ClaimsPrincipal principal)
    {
        IsError = false;
        if (principal.Identities.Count() != 1) return;

        if (principal.FindFirst(OpenIdConstants.ClaimTypes.Sub) == null) return;

        if (principal.FindFirst(OpenIdConstants.ClaimTypes.IdentityProvider) == null) return;

        if (principal.FindFirst(OpenIdConstants.ClaimTypes.AuthenticationMethod) == null) return;

        if (principal.FindFirst(OpenIdConstants.ClaimTypes.AuthenticationTime) == null) return;

        Subject = principal;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RopValidationModel"/> class.
    /// </summary>
    /// <param name="subject">Subject.</param>
    /// <param name="authenticationMethod">Authentication method.</param>
    /// <param name="authTime">Authentication time.</param>
    /// <param name="claims">List of claims.</param>
    /// <param name="identityProvider">The local identity provider.</param>
    public RopValidationModel(
        string subject,
        string authenticationMethod,
        DateTime authTime,
        IEnumerable<Claim> claims = null,
        string identityProvider = AuthenticationConstants.LocalIdentityProvider)
    {
        IsError = false;

        var resultClaims = new List<Claim>
        {
            new(OpenIdConstants.ClaimTypes.Sub, subject),
            new(OpenIdConstants.ClaimTypes.AuthenticationMethod, authenticationMethod),
            new(OpenIdConstants.ClaimTypes.IdentityProvider, identityProvider),
            new(OpenIdConstants.ClaimTypes.AuthenticationTime, new DateTimeOffset(authTime).ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64),
        };

        if (claims != null && claims.Any()) resultClaims.AddRange(claims);

        var id = new ClaimsIdentity(authenticationMethod);
        id.AddClaims(resultClaims.Distinct());

        Subject = new ClaimsPrincipal(id);
    }
}