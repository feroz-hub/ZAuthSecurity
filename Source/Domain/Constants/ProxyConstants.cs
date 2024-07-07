namespace Domain.Constants;
/// <summary>
/// Constants related to API proxies.
/// </summary>
public class ProxyConstants
{
    /// <summary>
    /// List of APIs accessible anonymously.
    /// </summary>
    public static readonly List<string> AnonymousApis =
    [
        "AddAuditTrailAsync",
        "RegisterUserAsync",
        "ResetPasswordAsync",
        "UnLockUserAsync",
        "IsUserExistsAsync",
        "AddClaimAsync",
        "GetAllSecurityQuestionsAsync",
        "AddUserSecurityQuestionAsync",
        "GenerateEmailConfirmationTokenAsync",
        "VerifyEmailConfirmationTokenAsync",
        "GeneratePhoneNumberConfirmationTokenAsync",
        "VerifyPhoneNumberConfirmationTokenAsync",
        "GeneratePasswordResetTokenAsync",
        "GenerateUserTokenAsync",
        "VerifyUserTokenAsync",
        "GenerateEmailTwoFactorTokenAsync",
        "VerifyEmailTwoFactorTokenAsync",
        "GenerateSmsTwoFactorTokenAsync",
        "VerifySmsTwoFactorTokenAsync",
        "GetAllTwoFactorTypeAsync",
        "PasswordSignInAsync",
        "TwoFactorEmailSignInAsync",
        "TwoFactorSmsSignInAsync",
        "TwoFactorAuthenticatorAppSignInAsync",
        "TwoFactorRecoveryCodeSignInAsync",
        "SignOutAsync",
        "IsUserSignedInAsync",
        "SetupAuthenticatorAppAsync",
        "VerifyAuthenticatorAppSetupAsync",
        "ResetAuthenticatorAppAsync",
        "GenerateRecoveryCodesAsync",
        "RopValidateCredentialsAsync",
    ];

    /// <summary>
    /// List of secure APIs requiring authentication.
    /// </summary>
    public static readonly List<string> SecureApis =
    [
        "GetApiResourceAsync", "GetAllApiResourcesByScopesAsync", "GetAllApiResourcesAsync", "GetAllApiScopesAsync",
        "GetApiResourceClaimsAsync", "GetApiScopeAsync", "GetApiScopeClaimsAsync", "GetIdentityResourceAsync",
        "GetAllIdentityResourcesAsync", "GetAllIdentityResourcesByScopesAsync", "GetIdentityResourceClaimsAsync",
        "AddApiResourceAsync", "UpdateApiResourceAsync", "DeleteApiResourceAsync", "AddApiResourceClaimAsync",
        "DeleteApiResourceClaimByResourceIdAsync", "DeleteApiResourceClaimByIdAsync", "AddApiScopeAsync",
        "UpdateApiScopeAsync", "DeleteApiScopeAsync", "AddApiScopeClaimAsync", "DeleteApiScopeClaimByScopeIdAsync",
        "DeleteApiScopeClaimByIdAsync", "AddIdentityResourceAsync", "UpdateIdentityResourceAsync",
        "DeleteIdentityResourceAsync", "AddIdentityResourceClaimAsync",
        "DeleteIdentityResourceClaimByResourceIdAsync", "RegisterClientAsync", "UpdateClientAsync",
        "DeleteClientAsync", "GenerateClientSecret", "GetClientAsync", "GetAllClientAsync",
        "GetClientsActiveTokensAsync", "GetAuditDetailsAsync", "CreateRoleAsync", "UpdateRoleAsync",
        "DeleteRoleAsync", "GetRoleAsync", "AddRoleClaimAsync", "AddRoleClaimsAsync", "RemoveRoleClaimAsync",
        "RemoveRoleClaimsAsync", "GetRoleClaimAsync", "UpdateUserAsync", "DeleteUserAsync", "LockUserAsync",
        "GetUserByNameAsync", "GetUserByEmailAsync", "GetUserByIdAsync", "GetUsersForClaimAsync",
        "RemoveClaimAsync", "ReplaceClaimAsync", "GetClaimsAsync", "GetUserClaimsAsync", "RemoveAdminClaimAsync",
        "AddAdminClaimAsync", "AddUserRoleAsync", "AddUserRolesAsync", "RemoveUserRoleAsync",
        "RemoveUserRolesAsync", "GetUserRolesAsync", "GetUsersInRoleAsync", "GetUserRoleClaimsByIdAsync",
        "GetUserRoleClaimsByNameAsync", "AddSecurityQuestionAsync", "UpdateSecurityQuestionAsync",
        "DeleteSecurityQuestionAsync", "UpdateUserSecurityQuestionAsync", "DeleteUserSecurityQuestionAsync",
        "GetUserSecurityQuestionsAsync", "SetTwoFactorEnabledAsync", "UpdateUserTwoFactorTypeAsync",
        "CountRecoveryCodesAsync", "ChangePasswordAsync", "GetAllRolesAsync", "GetAllUsersAsync"
    ];
}