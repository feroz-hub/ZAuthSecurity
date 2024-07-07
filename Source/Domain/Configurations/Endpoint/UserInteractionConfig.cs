namespace Domain.Configurations.Endpoint;

/// <summary>
/// Configuration settings related to user interaction endpoints.
/// </summary>
public class UserInteractionConfig
{
    /// <summary>
    /// Gets or sets the URL for the login endpoint.
    /// </summary>
    public string LoginUrl { get; set; }

    /// <summary>
    /// Gets or sets the parameter name for the return URL in the login endpoint.
    /// </summary>
    public string LoginReturnUrlParameter { get; set; } =
        AuthenticationConstants.ApplicationUiConstants.DefaultRoutePathParams.Login;

    /// <summary>
    /// Gets or sets the URL for the logout endpoint.
    /// </summary>
    public string LogoutUrl { get; set; }

    /// <summary>
    /// Gets or sets the parameter name for the logout ID in the logout endpoint.
    /// </summary>
    public string LogoutIdParameter { get; set; } =
        AuthenticationConstants.ApplicationUiConstants.DefaultRoutePathParams.Logout;

    /// <summary>
    /// Gets or sets the URL for the error endpoint.
    /// </summary>
    public string ErrorUrl { get; set; }

    /// <summary>
    /// Gets or sets the parameter name for the error ID in the error endpoint.
    /// </summary>
    public string ErrorIdParameter { get; set; } =
        AuthenticationConstants.ApplicationUiConstants.DefaultRoutePathParams.Error;
}