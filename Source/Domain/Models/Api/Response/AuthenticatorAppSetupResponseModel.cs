namespace Domain.Models.Api.Response;

/// <summary>
/// Model storing the response of the Authenticator App Setup.
/// <para>It contains the authenticator URI and authenticator key for user's two factor authentication.</para>
/// </summary>
public class AuthenticatorAppSetupResponseModel
{
    /// <summary>
    /// Gets or sets shared key for authenticator app.
    /// </summary>
    public string SharedKey { get; set; }

    /// <summary>
    /// Gets or sets for authenticator app url.
    /// </summary>
    public string AuthenticatorUri { get; set; }

    /// <summary>
    /// Gets or sets for authenticator app verification code.
    /// </summary>
    public string VerificationCode { get; set; }
}