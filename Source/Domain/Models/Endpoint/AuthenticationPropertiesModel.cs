using System.Security.Claims;
using Domain.Models.Endpoint.Response;
using Microsoft.AspNetCore.Authentication;

namespace Domain.Models.Endpoint;

/// <summary>
/// Domain Model representing Authentication Properties.
/// </summary>
public class AuthenticationPropertiesModel : ErrorResponseModel
{
    /// <summary>
    /// Gets or sets the Claims Principal.
    /// </summary>
    public ClaimsPrincipal Principal { get; set; }

    /// <summary>
    /// Gets or sets the Authentication properties.
    /// </summary>
    public AuthenticationProperties Properties { get; set; }
}