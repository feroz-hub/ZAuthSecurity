using Domain.Enums;

namespace Domain.Models.Api.Response;

/// <summary>
/// Model for user login response.
/// </summary>
public class SignInResponseModel
{
    /// <summary>
    /// Gets or sets a value indicating whether user login succeeded or not.
    /// </summary>
    public bool Succeeded { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether user account is locked or not.
    /// </summary>
    public bool IsLockedOut { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether user allowed to login or not.
    /// </summary>
    public bool IsNotAllowed { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether user require 2FA or not.
    /// </summary>
    public bool RequiresTwoFactor { get; set; } = false;

    /// <summary>
    /// Gets or sets type of 2FA verification mode.
    /// </summary>
    public TwoFactorType TwoFactorVerificationMode { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether 2FA verification code sent or not.
    /// </summary>
    public bool TwoFactorVerificationCodeSent { get; set; } = false;

    /// <summary>
    /// Gets or sets login status message.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    ///  Gets or sets error code.
    /// </summary>
    public string ErrorCode { get; set; }

    /// <summary>
    /// Gets or sets user login confirmation code.
    /// </summary>
    public string UserVerificationCode { get; set; }
}