using Domain.Models.Endpoint.Response;

namespace Domain.Models.Endpoint;

/// <summary>
/// Domain Model representing Navigation.
/// </summary>
public class NavigationModel : ErrorResponseModel
{
    /// <summary>
    /// Gets or sets a value indicating whether the navigation is for the login.
    /// </summary>
    public bool IsLogin { get; set; }

    /// <summary>
    /// Gets a value indicating whether it is a redirect.
    /// </summary>
    public bool IsRedirect => !string.IsNullOrWhiteSpace(RedirectUrl);

    /// <summary>
    /// Gets or sets a value indicating the redirect url.
    /// </summary>
    public string RedirectUrl { get; set; }
}