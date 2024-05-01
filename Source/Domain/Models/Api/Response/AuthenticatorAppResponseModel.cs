namespace Domain.Models.Api.Response;

/// <summary>
/// Model for storing Authenticator app token response.
/// </summary>
public class AuthenticatorAppResponseModel
{
    /// <summary>
    /// Gets or sets a value indicating whether authenticator app code verified successfully or not.
    /// </summary>
    public bool Succeeded { get; set; } = false;

    /// <summary>
    /// Gets or sets error message when authenticator app verification failed.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Gets or sets List of recovery code for authenticator app.
    /// </summary>
    public IEnumerable<string> RecoveryCodes { get; set; }
}