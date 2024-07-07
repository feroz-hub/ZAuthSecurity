namespace Domain.Configurations.Endpoint;

/// <summary>
/// Configuration settings related to authentication endpoints.
/// </summary>
public class AuthenticationConfig
{
    /// <summary>
    /// Gets or sets a value indicating whether Content Security Policy (CSP) frame source is required for sign-out.
    /// </summary>
    public bool RequireCspFrameSrcForSignOut { get; set; } = true;
}