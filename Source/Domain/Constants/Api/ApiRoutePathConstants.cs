using Domain.Models.Api;

namespace Domain.Constants.Api;

public static class ApiRoutePathConstants
{
    ///<summary>
    /// Base path for API endpoints.
    ///</summary>
    private const string BasePath = "/Security/Api";

    ///<summary>
    /// Path for the user API endpoint.
    ///</summary>
    private const string UserApi = BasePath + "/User";

    ///<summary>
    /// Path for the client API endpoint.
    ///</summary>
    private const string ClientApi = BasePath + "/Client";

    ///<summary>
    /// Path for the role API endpoint.
    ///</summary>
    private const string RoleApi = BasePath + "/Role";

    ///<summary>
    /// Path for the API resource API endpoint.
    ///</summary>
    private const string ApiResourceApi = BasePath + "/ApiResource";

    ///<summary>
    /// Path for the identity API endpoint.
    ///</summary>
    private const string IdentityApi = BasePath + "/IdentityResource";

    ///<summary>
    /// Path for the audit trail API endpoint.
    ///</summary>
    private const string AuditTrailApi = BasePath + "/AuditTrail";

    ///<summary>
    /// Path for the authentication API endpoint.
    ///</summary>
    private const string AuthenticationApi = BasePath + "/Authentication";

    ///<summary>
    /// Path for the security token API endpoint.
    ///</summary>
    private const string SecurityTokenApi = BasePath + "/SecurityToken";

    ///<summary>
    /// Path for adding an API resource.
    ///</summary>
    public const string AddApiResource = ApiResourceApi + "/AddApiResource";

    ///<summary>
    /// Path for updating an API resource.
    ///</summary>
    public const string UpdateApiResource = ApiResourceApi + "/UpdateApiResource";

    ///<summary>
    /// Path for deleting an API resource by ID.
    ///</summary>
    public const string DeleteApiResourceById = ApiResourceApi + "/DeleteApiResourceById";

    ///<summary>
    /// Path for deleting an API resource by name.
    ///</summary>
    public const string DeleteApiResourceByName = ApiResourceApi + "/DeleteApiResourceByName";

    ///<summary>
    /// Path for getting an API resource by ID.
    ///</summary>
    public const string GetApiResourceById = ApiResourceApi + "/GetApiResourceById";

    ///<summary>
    /// Path for getting an API resource by name.
    ///</summary>
    public const string GetApiResourceByName = ApiResourceApi + "/GetApiResourceByName";

    ///<summary>
    /// Path for getting all API resources.
    ///</summary>
    public const string GetAllApiResources = ApiResourceApi + "/GetAllApiResources";

    ///<summary>
    /// Path for getting all API resources by scopes.
    ///</summary>
    public const string GetAllApiResourcesByScopes = ApiResourceApi + "/GetAllApiResourcesByScopes";

    ///<summary>
    /// Path for adding an API resource claim.
    ///</summary>
    public const string AddApiResourceClaim = ApiResourceApi + "/AddApiResourceClaim";

    ///<summary>
    /// Path for deleting an API resource claim by ID.
    ///</summary>
    public const string DeleteApiResourceClaimById = ApiResourceApi + "/DeleteApiResourceClaimById";

    ///<summary>
    /// Path for deleting API resource claims by resource ID.
    ///</summary>
    public const string DeleteApiResourceClaimByResourceId = ApiResourceApi + "/DeleteApiResourceClaimByResourceId";

    /// <summary>
    /// Path for deleting API resource claims by Model.
    /// </summary>
    public const string DeleteApiResourceClaimModel = ApiResourceApi + "/DeleteApiResourceClaimModel";

    ///<summary>
    /// Path for getting API resource claims by ID.
    ///</summary>
    public const string GetApiResourceClaimsById = ApiResourceApi + "/GetApiResourceClaimsById";

    ///<summary>
    /// Path for adding an API scope.
    ///</summary>
    public const string AddApiScope = ApiResourceApi + "/AddApiScope";

    ///<summary>
    /// Path for updating an API scope.
    ///</summary>
    public const string UpdateApiScope = ApiResourceApi + "/UpdateApiScope";

    ///<summary>
    /// Path for deleting an API scope by ID.
    ///</summary>
    public const string DeleteApiScopeById = ApiResourceApi + "/DeleteApiScopeById";

    ///<summary>
    /// Path for deleting an API scope by name.
    ///</summary>
    public const string DeleteApiScopeByName = ApiResourceApi + "/DeleteApiScopeByName";

    ///<summary>
    /// Path for getting an API scope by ID.
    ///</summary>
    public const string GetApiScopeById = ApiResourceApi + "/GetApiScopeById";

    ///<summary>
    /// Path for getting an API scope by name.
    ///</summary>
    public const string GetApiScopeByName = ApiResourceApi + "/GetApiScopeByName";

    ///<summary>
    /// Path for getting all API scopes.
    ///</summary>
    public const string GetAllApiScopes = ApiResourceApi + "/GetAllApiScopes";

    ///<summary>
    /// Path for adding an API scope claim.
    ///</summary>
    public const string AddApiScopeClaim = ApiResourceApi + "/AddApiScopeClaim";

    ///<summary>
    /// Path for deleting an API scope claim by scope ID.
    ///</summary>
    public const string DeleteApiScopeClaimByScopeId = ApiResourceApi + "/DeleteApiScopeClaimByScopeId";

    ///<summary>
    /// Path for deleting an API scope claim by ID.
    ///</summary>
    public const string DeleteApiScopeClaimById = ApiResourceApi + "/DeleteApiScopeClaimById";

    ///<summary>
    /// Path for deleting an API scope claim model.
    ///</summary>
    public const string DeleteApiScopeClaimModel = ApiResourceApi + "/DeleteApiScopeClaimModel";

    ///<summary>
    /// Path for getting an API scope claim.
    ///</summary>
    public const string GetApiScopeClaims = ApiResourceApi + "/GetApiScopeClaims";

    ///<summary>
    /// Path for adding an identity resource.
    ///</summary>
    public const string AddIdentityResource = IdentityApi + "/AddIdentityResource";

    ///<summary>
    /// Path for updating an identity resource.
    ///</summary>
    public const string UpdateIdentityResource = IdentityApi + "/UpdateIdentityResource";

    ///<summary>
    /// Path for deleting an identity resource by ID.
    ///</summary>
    public const string DeleteIdentityResourceById = IdentityApi + "/DeleteIdentityResourceById";

    ///<summary>
    /// Path for deleting an identity resource by name.
    ///</summary>
    public const string DeleteIdentityResourceByName = IdentityApi + "/DeleteIdentityResourceByName";

    ///<summary>
    /// Path for getting an identity resource by ID.
    ///</summary>
    public const string GetIdentityResourceById = IdentityApi + "/GetIdentityResourceById";

    ///<summary>
    /// Path for getting an identity resource by name.
    ///</summary>
    public const string GetIdentityResourceByName = IdentityApi + "/GetIdentityResourceByName";

    ///<summary>
    /// Path for getting all identity resources.
    ///</summary>
    public const string GetAllIdentityResources = IdentityApi + "/GetAllIdentityResources";

    ///<summary>
    /// Path for adding an identity resource claim.
    ///</summary>
    public const string AddIdentityResourceClaim = IdentityApi + "/AddIdentityResourceClaim";

    ///<summary>
    /// Path for deleting an identity resource claim by ID.
    ///</summary>
    public const string DeleteIdentityResourceClaimById = IdentityApi + "/DeleteIdentityResourceClaimById";

    ///<summary>
    /// Path for deleting an identity resource claim by resource ID.
    ///</summary>
    public const string DeleteIdentityResourceClaimByResourceId =
        IdentityApi + "/DeleteIdentityResourceClaimByResourceId";

    ///<summary>
    /// Path for deleting an identity resource claim model.
    ///</summary>
    public const string DeleteIdentityResourceClaimModel = IdentityApi + "/DeleteIdentityResourceClaimModel";

    ///<summary>
    /// Path for getting identity resource claims.
    ///</summary>
    public const string GetIdentityResourceClaims = IdentityApi + "/GetIdentityResourceClaims";

    ///<summary>
    /// Path for creating a role.
    ///</summary>
    public const string CreateRole = RoleApi + "/CreateRole";

    ///<summary>
    /// Path for updating a role.
    ///</summary>
    public const string UpdateRole = RoleApi + "/UpdateRole";

    ///<summary>
    /// Path for deleting a role by ID.
    ///</summary>
    public const string DeleteRoleById = RoleApi + "/DeleteRoleById";

    ///<summary>
    /// Path for deleting a role by name.
    ///</summary>
    public const string DeleteRoleByName = RoleApi + "/DeleteRoleByName";

    ///<summary>
    /// Path for getting a role by ID.
    ///</summary>
    public const string GetRoleById = RoleApi + "/GetRoleById";

    ///<summary>
    /// Path for getting a role by name.
    ///</summary>
    public const string GetRoleByName = RoleApi + "/GetRoleByName";

    ///<summary>
    /// Path for getting all roles.
    ///</summary>
    public const string GetAllRoles = RoleApi + "/GetAllRoles";

    ///<summary>
    /// Path for adding a role claim.
    ///</summary>
    public const string AddRoleClaim = RoleApi + "/AddRoleClaim";

    ///<summary>
    /// Path for adding a list of role claims.
    ///</summary>
    public const string AddRoleClaimList = RoleApi + "/AddRoleClaimList";

    ///<summary>
    /// Path for removing a role claim.
    ///</summary>
    public const string RemoveRoleClaim = RoleApi + "/RemoveRoleClaim";

    ///<summary>
    /// Path for removing a list of role claims.
    ///</summary>
    public const string RemoveRoleClaimsList = RoleApi + "/RemoveRoleClaimsList";

    ///<summary>
    /// Path for removing role claims by ID.
    ///</summary>
    public const string RemoveRoleClaimsById = RoleApi + "/RemoveRoleClaimsById";

    ///<summary>
    /// Path for getting a role claim.
    ///</summary>
    public const string GetRoleClaim = RoleApi + "/GetRoleClaim";

    ///<summary>
    /// Path for adding an admin claim.
    ///</summary>
    public const string AddAdminClaim = UserApi + "/AddAdminClaim";

    ///<summary>
    /// Path for adding a list of admin claims.
    ///</summary>
    public const string AddAdminClaimList = UserApi + "/AddAdminClaimList";

    ///<summary>
    /// Path for adding a user claim.
    ///</summary>
    public const string AddClaim = UserApi + "/AddClaim";

    ///<summary>
    /// Path for adding a list of user claims.
    ///</summary>
    public const string AddClaimList = UserApi + "/AddClaimList";

    /// <summary>
    /// Path for adding a User Role.
    /// </summary>
    public const string AddUserRole = UserApi + "/AddUserRole";

    public const string AddUserRolesList = UserApi + "/AddUserRolesList";

    ///<summary>
    /// Path for adding a security question.
    ///</summary>
    public const string AddSecurityQuestion = UserApi + "/AddSecurityQuestion";

    ///<summary>
    /// Path for adding a user security question.
    ///</summary>
    public const string AddUserSecurityQuestion = UserApi + "/AddUserSecurityQuestion";

    ///<summary>
    /// Path for adding a list of user security questions.
    ///</summary>
    public const string AddUserSecurityQuestionList = UserApi + "/AddUserSecurityQuestionList";

    ///<summary>
    /// Path for changing a user's password.
    ///</summary>
    public const string ChangePassword = UserApi + "/ChangePassword";

    ///<summary>
    /// Path for deleting a security question.
    ///</summary>
    public const string DeleteSecurityQuestion = UserApi + "/DeleteSecurityQuestion";

    ///<summary>
    /// Path for deleting a user by name.
    ///</summary>
    public const string DeleteUserByName = UserApi + "/DeleteUserByName";

    ///<summary>
    /// Path for getting all users.
    ///</summary>
    public const string GetAllUsers = UserApi + "/GetAllUsers";

    ///<summary>
    /// Path for deleting a user by ID.
    ///</summary>
    public const string DeleteUserById = UserApi + "/DeleteUserById";

    ///<summary>
    /// Path for deleting a user security question.
    ///</summary>
    public const string DeleteUserSecurityQuestion = UserApi + "/DeleteUserSecurityQuestion";

    ///<summary>
    /// Path for deleting a list of user security questions.
    ///</summary>
    public const string DeleteUserSecurityQuestionList = UserApi + "/DeleteUserSecurityQuestionList";

    ///<summary>
    /// Path for generating an email confirmation token.
    ///</summary>
    public const string GenerateEmailConfirmationToken = UserApi + "/GenerateEmailConfirmationToken";

    ///<summary>
    /// Path for generating a phone number confirmation token.
    ///</summary>
    public const string GeneratePhoneNumberConfirmationToken = UserApi + "/GeneratePhoneNumberConfirmationToken";

    ///<summary>
    /// Path for generating an email two-factor token.
    ///</summary>
    public const string GenerateEmailTwoFactorToken = UserApi + "/GenerateEmailTwoFactorToken";

    ///<summary>
    /// Path for generating a password reset token.
    ///</summary>
    public const string GeneratePasswordResetToken = UserApi + "/GeneratePasswordResetToken";

    ///<summary>
    /// Path for generating an SMS two-factor token.
    ///</summary>
    public const string GenerateSmsTwoFactorToken = UserApi + "/GenerateSmsTwoFactorToken";

    ///<summary>
    /// Path for generating a user token asynchronously.
    ///</summary>
    public const string GenerateUserTokenAsync = UserApi + "/GenerateUserTokenAsync";

    ///<summary>
    /// Path for getting all security questions.
    ///</summary>
    public const string GetAllSecurityQuestions = UserApi + "/GetAllSecurityQuestions";

    ///<summary>
    /// Path for getting all two-factor authentication types.
    ///</summary>
    public const string GetAllTwoFactorType = UserApi + "/GetAllTwoFactorType";

    ///<summary>
    /// Path for getting claims.
    ///</summary>
    public const string GetClaims = UserApi + "/GetClaims";

    ///<summary>
    /// Path for getting a user by email.
    ///</summary>
    public const string GetUserByEmail = UserApi + "/GetUserByEmail";

    ///<summary>
    /// Path for getting a user by ID.
    ///</summary>
    public const string GetUserById = UserApi + "/GetUserById";

    ///<summary>
    /// Path for getting a user by name.
    ///</summary>
    public const string GetUserByName = UserApi + "/GetUserByName";

    ///<summary>
    /// Path for getting user claims.
    ///</summary>
    public const string GetUserClaims = UserApi + "/GetUserClaims";

    ///<summary>
    /// Path for getting admin user claims.
    ///</summary>
    public const string GetAdminUserClaims = UserApi + "/GetAdminUserClaims";

    ///<summary>
    /// Path for getting user role claims by ID.
    ///</summary>
    public const string GetUserRoleClaimsById = UserApi + "/GetUserRoleClaimsById";

    ///<summary>
    /// Path for getting user role claims by name.
    ///</summary>
    public const string GetUserRoleClaimsByName = UserApi + "/GetUserRoleClaimsByName";

    ///<summary>
    /// Path for getting user roles.
    ///</summary>
    public const string GetUserRoles = UserApi + "/GetUserRoles";

    ///<summary>
    /// Path for getting user security questions.
    ///</summary>
    public const string GetUserSecurityQuestions = UserApi + "/GetUserSecurityQuestions";

    ///<summary>
    /// Path for getting users for a specific claim.
    ///</summary>
    public const string GetUsersForClaim = UserApi + "/GetUsersForClaim";

    ///<summary>
    /// Path for getting users in a specific role.
    ///</summary>
    public const string GetUsersInRole = UserApi + "/GetUsersInRole";

    ///<summary>
    /// Path for checking if a user exists by claim principal.
    ///</summary>
    public const string IsUserExistsByClaimPrincipal = UserApi + "/IsUserExistsByClaimPrincipal";

    ///<summary>
    /// Path for checking if a user exists by ID.
    ///</summary>
    public const string IsUserExistsById = UserApi + "/IsUserExistsById";

    ///<summary>
    /// Path for checking if a user exists by name.
    ///</summary>
    public const string IsUserExistsByName = UserApi + "/IsUserExistsByName";

    ///<summary>
    /// Path for locking a user.
    ///</summary>
    public const string LockUser = UserApi + "/LockUser";

    ///<summary>
    /// Path for locking a user for a specific period of time.
    ///</summary>
    public const string LockUserByTime = UserApi + "/LockUserByTime";

    ///<summary>
    /// Path for registering a new user.
    ///</summary>
    public const string RegisterUser = UserApi + "/RegisterUser";

    ///<summary>
    /// Path for removing an admin claim from a user.
    ///</summary>
    public const string RemoveAdminClaim = UserApi + "/RemoveAdminClaim";

    ///<summary>
    /// Path for removing a list of admin claims from a user.
    ///</summary>
    public const string RemoveAdminClaimList = UserApi + "/RemoveAdminClaimList";

    ///<summary>
    /// Path for removing a claim from a user.
    ///</summary>
    public const string RemoveClaim = UserApi + "/RemoveClaim";

    ///<summary>
    /// Path for removing a list of claims from a user.
    ///</summary>
    public const string RemoveClaimList = UserApi + "/RemoveClaimList";

    ///<summary>
    /// Path for removing a user role.
    ///</summary>
    public const string RemoveUserRole = UserApi + "/RemoveUserRole";

    ///<summary>
    /// Path for removing multiple user roles.
    ///</summary>
    public const string RemoveUserRoleList = UserApi + "/RemoveUserRoleList";

    ///<summary>
    /// Path for replacing a claim with a new one for a user.
    ///</summary>
    public const string ReplaceClaim = UserApi + "/ReplaceClaim";

    ///<summary>
    /// Path for resetting a user's password.
    ///</summary>
    public const string ResetPassword = UserApi + "/ResetPassword";

    ///<summary>
    /// Path for setting two-factor authentication enabled for a user.
    ///</summary>
    public const string SetTwoFactorEnabled = UserApi + "/SetTwoFactorEnabled";

    ///<summary>
    /// Path for unlocking a locked user.
    ///</summary>
    public const string UnLockUser = UserApi + "/UnLockUser";

    ///<summary>
    /// Path for unlocking a locked user using a token.
    ///</summary>
    public const string UnLockUserByToken = UserApi + "/UnLockUserByToken";

    ///<summary>
    /// Path for unlocking a user by answering security questions.
    ///</summary>
    public const string UnLockUserByUserSecurityQuestions = UserApi + "/UnLockUserByuserSecurityQuestions";

    ///<summary>
    /// Path for updating a security question for a user.
    ///</summary>
    public const string UpdateSecurityQuestion = UserApi + "/UpdateSecurityQuestion";

    ///<summary>
    /// Path for updating user information.
    ///</summary>
    public const string UpdateUser = UserApi + "/UpdateUser";

    ///<summary>
    /// Path for updating a user's security question.
    ///</summary>
    public const string UpdateUserSecurityQuestion = UserApi + "/UpdateUserSecurityQuestion";

    ///<summary>
    /// Path for updating a user's two-factor authentication type.
    ///</summary>
    public const string UpdateUserTwoFactorType = UserApi + "/UpdateUserTwoFactorType";

    ///<summary>
    /// Path for verifying an email confirmation token.
    ///</summary>
    public const string VerifyEmailConfirmationToken = UserApi + "/VerifyEmailConfirmationToken";

    ///<summary>
    /// Path for verifying an email two-factor authentication token.
    ///</summary>
    public const string VerifyEmailTwoFactorToken = UserApi + "/VerifyEmailTwoFactorToken";

    ///<summary>
    /// Path for verifying a phone number confirmation token.
    ///</summary>
    public const string VerifyPhoneNumberConfirmationToken = UserApi + "/VerifyPhoneNumberConfirmationToken";

    ///<summary>
    /// Path for verifying an SMS two-factor authentication token.
    ///</summary>
    public const string VerifySmsTwoFactorToken = UserApi + "/VerifySmsTwoFactorToken";

    ///<summary>
    /// Path for verifying a generic user token.
    ///</summary>
    public const string VerifyUserToken = UserApi + "/VerifyUserToken";

    ///<summary>
    /// Path for locking a user.
    ///</summary>
    public const string LockUserPath = BasePath + "/lockuser";

    ///<summary>
    /// Path for locking a user with an end date.
    ///</summary>
    public const string LockUserWithEndDatePath = BasePath + "/lockuserwithenddate";

    ///<summary>
    /// Path for adding an audit trail entry.
    ///</summary>
    public const string AddAuditTrail = AuditTrailApi + "/AddAuditTrail";

    ///<summary>
    /// Path for adding an audit trail model.
    ///</summary>
    public const string AddAuditTrailModel = AuditTrailApi + "/AddAuditTrailModel";

    ///<summary>
    /// Path for getting audit details.
    ///</summary>
    public const string GetAuditDetails = AuditTrailApi + "/GetAuditDetails";

    ///<summary>
    /// Path for generating recovery codes.
    ///</summary>
    public const string GenerateRecoveryCodes = AuthenticationApi + "/GenerateRecoveryCodes";

    ///<summary>
    /// Path for checking if a user is signed in.
    ///</summary>
    public const string IsUserSignedIn = AuthenticationApi + "/IsUserSignedIn";

    ///<summary>
    /// Path for signing in with a password.
    ///</summary>
    public const string PasswordSignIn = AuthenticationApi + "/PasswordSignIn";

    ///<summary>
    /// Path for signing in with a two-factor authenticator token.
    ///</summary>
    public const string PasswordSignInByTwoFactorAuthenticatorToken =
        AuthenticationApi + "/PasswordSignInByTwoFactorAuthenticatorToken";

    ///<summary>
    /// Path for resetting the authenticator app.
    ///</summary>
    public const string ResetAuthenticatorApp = AuthenticationApi + "/ResetAuthenticatorApp";

    ///<summary>
    /// Path for validating credentials using the Resource Owner Password (ROP) grant type.
    ///</summary>
    public const string RopValidateCredentials = AuthenticationApi + "/RopValidateCredentials";

    ///<summary>
    /// Path for setting up the authenticator app.
    ///</summary>
    public const string SetupAuthenticatorApp = AuthenticationApi + "/SetupAuthenticatorApp";

    ///<summary>
    /// Path for signing out.
    ///</summary>
    public const string SignOut = AuthenticationApi + "/SignOut";

    ///<summary>
    /// Path for signing in with a two-factor authenticator app.
    ///</summary>
    public const string TwoFactorAuthenticatorAppSignIn = AuthenticationApi + "/TwoFactorAuthenticatorAppSignIn";

    ///<summary>
    /// Path for signing in with a two-factor email.
    ///</summary>
    public const string TwoFactorEmailSignIn = AuthenticationApi + "/TwoFactorEmailSignIn";

    ///<summary>
    /// Path for signing in with a two-factor recovery code.
    ///</summary>
    public const string TwoFactorRecoveryCodeSignIn = AuthenticationApi + "/TwoFactorRecoveryCodeSignIn";

    ///<summary>
    /// Path for signing in with a two-factor SMS.
    ///</summary>
    public const string TwoFactorSmsSignInAsync = AuthenticationApi + "/TwoFactorSmsSignInAsync";

    ///<summary>
    /// Path for verifying authenticator app setup.
    ///</summary>
    public const string VerifyAuthenticatorAppSetup = AuthenticationApi + "/VerifyAuthenticatorAppSetup";

    ///<summary>
    /// Path for counting recovery codes asynchronously.
    ///</summary>
    public const string CountRecoveryCodesAsync = AuthenticationApi + "/CountRecoveryCodesAsync";

    ///<summary>
    /// Path for deleting a client.
    ///</summary>
    public const string DeleteClient = ClientApi + "/DeleteClient";

    ///<summary>
    /// Path for generating a client secret.
    ///</summary>
    public const string GenerateClientSecret = ClientApi + "/GenerateClientSecret";

    ///<summary>
    /// Path for getting all clients.
    ///</summary>
    public const string GetAllClient = ClientApi + "/GetAllClient";

    ///<summary>
    /// Path for getting a client.
    ///</summary>
    public const string GetClient = ClientApi + "/GetClient";

    ///<summary>
    /// Path for registering a client.
    ///</summary>
    public const string RegisterClient = ClientApi + "/RegisterClient";

    ///<summary>
    /// Path for updating a client.
    ///</summary>
    public const string UpdateClient = ClientApi + "/UpdateClient";

    ///<summary>
    /// Path for getting active security tokens by client IDs.
    ///</summary>
    public const string GetActiveSecurityTokensByClientIds = SecurityTokenApi + "/GetActiveSecurityTokensByClientIds";

    ///<summary>
    /// Path for getting active security tokens by user IDs.
    ///</summary>
    public const string GetActiveSecurityTokensByUserIds = SecurityTokenApi + "/GetActiveSecurityTokensByUserIds";

    ///<summary>
    /// Path for getting active security tokens between dates.
    ///</summary>
    public const string GetActiveSecurityTokensBetweenDates = SecurityTokenApi + "/GetActiveSecurityTokensBetweenDates";

    ///<summary>
    /// Path for getting all security tokens between dates.
    ///</summary>
    public const string GetAllSecurityTokensBetweenDates = SecurityTokenApi + "/GetAllSecurityTokensBetweenDates";


    /// <summary>
    /// Api route model list.
    /// </summary>
    public static readonly List<ApiRouteModel> ApiRouteModels =
    [
        // Api Resources
        new ApiRouteModel
        {
            Name = "AddApiResourceAsync", Path = AddApiResource,
            Permissions = [ApiPermissionConstants.ApiResourceWrite, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "UpdateApiResourceAsync", Path = UpdateApiResource,
            Permissions = [ApiPermissionConstants.ApiResourceWrite, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteApiResourceAsync", Path = DeleteApiResourceById,
            Permissions = [ApiPermissionConstants.ApiResourceDelete, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteApiResourceAsync", Path = DeleteApiResourceByName,
            Permissions = [ApiPermissionConstants.ApiResourceDelete, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetApiResourceAsync", Path = GetApiResourceById,
            Permissions = [ApiPermissionConstants.ApiResourceRead, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetApiResourceAsync", Path = GetApiResourceByName,
            Permissions = [ApiPermissionConstants.ApiResourceRead, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetAllApiResourcesAsync", Path = GetAllApiResources,
            Permissions = [ApiPermissionConstants.ApiResourceRead, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetAllApiResourcesByScopesAsync", Path = GetAllApiResourcesByScopes,
            Permissions = [ApiPermissionConstants.ApiResourceRead, ApiPermissionConstants.ApiResourceManage]
        },

        // Api Resource Claim
        new ApiRouteModel
        {
            Name = "AddApiResourceClaimAsync", Path = AddApiResourceClaim,
            Permissions = [ApiPermissionConstants.ApiResourceWrite, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteApiResourceClaimByIdAsync", Path = DeleteApiResourceClaimById,
            Permissions = [ApiPermissionConstants.ApiResourceDelete, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteApiResourceClaimAsync", Path = DeleteApiResourceClaimByResourceId,
            Permissions = [ApiPermissionConstants.ApiResourceDelete, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteApiResourceClaimAsync", Path = DeleteApiResourceClaimModel,
            Permissions = [ApiPermissionConstants.ApiResourceDelete, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetApiResourceClaimsAsync", Path = GetApiResourceClaimsById,
            Permissions = [ApiPermissionConstants.ApiResourceRead, ApiPermissionConstants.ApiResourceManage]
        },

        // Api Scope
        new ApiRouteModel
        {
            Name = "AddApiScopeAsync", Path = AddApiScope,
            Permissions = [ApiPermissionConstants.ApiResourceWrite, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "UpdateApiScopeAsync", Path = UpdateApiScope,
            Permissions = [ApiPermissionConstants.ApiResourceWrite, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteApiScopeAsync", Path = DeleteApiScopeById,
            Permissions = [ApiPermissionConstants.ApiResourceDelete, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteApiScopeAsync", Path = DeleteApiScopeByName,
            Permissions = [ApiPermissionConstants.ApiResourceDelete, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetApiScopeAsync", Path = GetApiScopeById,
            Permissions = [ApiPermissionConstants.ApiResourceRead, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetApiScopeAsync", Path = GetApiScopeByName,
            Permissions = [ApiPermissionConstants.ApiResourceRead, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetAllApiScopesAsync", Path = GetAllApiScopes,
            Permissions = [ApiPermissionConstants.ApiResourceRead, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "AddApiScopeClaimAsync", Path = AddApiScopeClaim,
            Permissions = [ApiPermissionConstants.ApiResourceWrite, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteApiScopeClaimAsync", Path = DeleteApiScopeClaimByScopeId,
            Permissions = [ApiPermissionConstants.ApiResourceDelete, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteApiScopeClaimByIdAsync", Path = DeleteApiScopeClaimById,
            Permissions = [ApiPermissionConstants.ApiResourceDelete, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteApiScopeClaimAsync", Path = DeleteApiScopeClaimModel,
            Permissions = [ApiPermissionConstants.ApiResourceDelete, ApiPermissionConstants.ApiResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetApiScopeClaimsAsync", Path = GetApiScopeClaims,
            Permissions = [ApiPermissionConstants.ApiResourceRead, ApiPermissionConstants.ApiResourceManage]
        },

        // User account service
        new ApiRouteModel
        {
            Name = "LockUserAsync", Path = LockUser,
            Permissions = [ApiPermissionConstants.AdminWrite, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "LockUserAsync", Path = LockUserWithEndDatePath,
            Permissions = [ApiPermissionConstants.AdminWrite, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "AddAdminClaimAsync", Path = AddAdminClaim,
            Permissions = [ApiPermissionConstants.AdminWrite, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "AddAdminClaimAsync", Path = AddAdminClaimList,
            Permissions = [ApiPermissionConstants.AdminWrite, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "AddClaimAsync", Path = AddClaim,
            Permissions = [ApiPermissionConstants.UserWrite, ApiPermissionConstants.AdminWrite]
        },
        new ApiRouteModel
        {
            Name = "AddClaimAsync", Path = AddClaimList,
            Permissions = [ApiPermissionConstants.UserWrite, ApiPermissionConstants.AdminWrite]
        },
        new ApiRouteModel
        {
            Name = "AddSecurityQuestionAsync", Path = AddSecurityQuestion,
            Permissions = [ApiPermissionConstants.AdminWrite, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "AddUserRoleAsync", Path = AddUserRole,
            Permissions = [ApiPermissionConstants.AdminWrite, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "AddUserRolesAsync", Path = AddUserRolesList,
            Permissions = [ApiPermissionConstants.AdminWrite, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "AddUserSecurityQuestionAsync", Path = AddUserSecurityQuestion,
            Permissions = [ApiPermissionConstants.UserWrite, ApiPermissionConstants.AdminWrite]
        },
        new ApiRouteModel
        {
            Name = "AddUserSecurityQuestionAsync", Path = AddUserSecurityQuestionList,
            Permissions = [ApiPermissionConstants.UserWrite, ApiPermissionConstants.AdminWrite]
        },
        new ApiRouteModel
        {
            Name = "ChangePasswordAsync", Path = ChangePassword,
            Permissions = [ApiPermissionConstants.UserWrite, ApiPermissionConstants.AdminWrite]
        },
        new ApiRouteModel
        {
            Name = "DeleteSecurityQuestionAsync", Path = DeleteSecurityQuestion,
            Permissions = [ApiPermissionConstants.AdminDelete, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteUserAsync", Path = DeleteUserById,
            Permissions = [ApiPermissionConstants.AdminDelete, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteUserAsync", Path = DeleteUserByName,
            Permissions = [ApiPermissionConstants.AdminDelete, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteUserSecurityQuestionAsync", Path = DeleteUserSecurityQuestion,
            Permissions = [ApiPermissionConstants.UserDelete, ApiPermissionConstants.AdminDelete]
        },
        new ApiRouteModel
        {
            Name = "DeleteUserSecurityQuestionAsync", Path = DeleteUserSecurityQuestionList,
            Permissions = [ApiPermissionConstants.UserDelete, ApiPermissionConstants.AdminDelete]
        },
        new ApiRouteModel
        {
            Name = "GenerateEmailConfirmationTokenAsync", Path = GenerateEmailConfirmationToken,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "GeneratePhoneNumberConfirmationTokenAsync", Path = GeneratePhoneNumberConfirmationToken,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "GenerateEmailTwoFactorTokenAsync", Path = GenerateEmailTwoFactorToken,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "GeneratePasswordResetTokenAsync", Path = GeneratePasswordResetToken,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "GenerateSmsTwoFactorTokenAsync", Path = GenerateSmsTwoFactorToken,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "GenerateUserTokenAsync", Path = GenerateUserTokenAsync,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "GetAllSecurityQuestionsAsync", Path = GetAllSecurityQuestions,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "GetAllTwoFactorTypeAsync", Path = GetAllTwoFactorType,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "GetClaimsAsync", Path = GetClaims,
            Permissions = [ApiPermissionConstants.UserRead, ApiPermissionConstants.AdminRead]
        },
        new ApiRouteModel
        {
            Name = "GetUserByEmailAsync", Path = GetUserByEmail,
            Permissions = [ApiPermissionConstants.UserRead, ApiPermissionConstants.AdminRead]
        },
        new ApiRouteModel
        {
            Name = "GetUserByIdAsync", Path = GetUserById,
            Permissions = [ApiPermissionConstants.UserRead, ApiPermissionConstants.AdminRead]
        },
        new ApiRouteModel
        {
            Name = "GetUserByNameAsync", Path = GetUserByName,
            Permissions = [ApiPermissionConstants.UserRead, ApiPermissionConstants.AdminRead]
        },
        new ApiRouteModel
        {
            Name = "GetAllUsersAsync", Path = GetAllUsers,
            Permissions = [ApiPermissionConstants.AdminRead, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "GetUserClaimsAsync", Path = GetUserClaims,
            Permissions = [ApiPermissionConstants.UserRead, ApiPermissionConstants.AdminRead]
        },
        new ApiRouteModel
        {
            Name = "GetAdminUserClaimsAsync", Path = GetAdminUserClaims,
            Permissions = [ApiPermissionConstants.AdminRead, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "GetUserRoleClaimsByIdAsync", Path = GetUserRoleClaimsById,
            Permissions = [ApiPermissionConstants.UserRead, ApiPermissionConstants.AdminRead]
        },
        new ApiRouteModel
        {
            Name = "GetUserRoleClaimsByNameAsync", Path = GetUserRoleClaimsByName,
            Permissions = [ApiPermissionConstants.UserRead, ApiPermissionConstants.AdminRead]
        },
        new ApiRouteModel
        {
            Name = "GetUserRolesAsync", Path = GetUserRoles,
            Permissions = [ApiPermissionConstants.UserRead, ApiPermissionConstants.AdminRead]
        },
        new ApiRouteModel
        {
            Name = "GetUserSecurityQuestionsAsync", Path = GetUserSecurityQuestions,
            Permissions = [ApiPermissionConstants.UserRead, ApiPermissionConstants.AdminRead]
        },
        new ApiRouteModel
        {
            Name = "GetUsersForClaimAsync", Path = GetUsersForClaim,
            Permissions = [ApiPermissionConstants.UserRead, ApiPermissionConstants.AdminRead]
        },
        new ApiRouteModel
        {
            Name = "GetUsersInRoleAsync", Path = GetUsersInRole,
            Permissions = [ApiPermissionConstants.UserRead, ApiPermissionConstants.AdminRead]
        },
        new ApiRouteModel
        {
            Name = "IsUserExistsAsync", Path = IsUserExistsByClaimPrincipal,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "IsUserExistsAsync", Path = IsUserExistsById,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "IsUserExistsAsync", Path = IsUserExistsByName,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "RegisterUserAsync", Path = RegisterUser,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "RemoveAdminClaimAsync", Path = RemoveAdminClaim,
            Permissions = [ApiPermissionConstants.AdminDelete, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "RemoveAdminClaimAsync", Path = RemoveAdminClaimList,
            Permissions = [ApiPermissionConstants.AdminDelete, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "RemoveClaimAsync", Path = RemoveClaim,
            Permissions = [ApiPermissionConstants.UserDelete, ApiPermissionConstants.AdminDelete]
        },
        new ApiRouteModel
        {
            Name = "RemoveClaimAsync", Path = RemoveClaimList,
            Permissions = [ApiPermissionConstants.UserDelete, ApiPermissionConstants.AdminDelete]
        },
        new ApiRouteModel
        {
            Name = "RemoveUserRoleAsync", Path = RemoveUserRole,
            Permissions = [ApiPermissionConstants.AdminDelete, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "RemoveUserRolesAsync", Path = RemoveUserRoleList,
            Permissions = [ApiPermissionConstants.AdminDelete, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "ReplaceClaimAsync", Path = ReplaceClaim,
            Permissions = [ApiPermissionConstants.UserWrite, ApiPermissionConstants.AdminWrite]
        },
        new ApiRouteModel
        {
            Name = "ResetPasswordAsync", Path = ResetPassword,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "SetTwoFactorEnabledAsync", Path = SetTwoFactorEnabled,
            Permissions = [ApiPermissionConstants.UserWrite, ApiPermissionConstants.AdminWrite]
        },
        new ApiRouteModel
        {
            Name = "UnLockUserAsync", Path = UnLockUser,
            Permissions = [ApiPermissionConstants.AdminWrite, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "UnLockUserAsync", Path = UnLockUserByToken,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "UnlockUserAsync", Path = UnLockUserByUserSecurityQuestions,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "UpdateSecurityQuestionAsync", Path = UpdateSecurityQuestion,
            Permissions = [ApiPermissionConstants.AdminWrite, ApiPermissionConstants.AdminManage]
        },
        new ApiRouteModel
        {
            Name = "UpdateUserAsync", Path = UpdateUser,
            Permissions = [ApiPermissionConstants.UserWrite, ApiPermissionConstants.AdminWrite]
        },
        new ApiRouteModel
        {
            Name = "UpdateUserSecurityQuestionAsync", Path = UpdateUserSecurityQuestion,
            Permissions = [ApiPermissionConstants.UserWrite, ApiPermissionConstants.AdminWrite]
        },
        new ApiRouteModel
        {
            Name = "UpdateUserTwoFactorTypeAsync", Path = UpdateUserTwoFactorType,
            Permissions = [ApiPermissionConstants.UserWrite, ApiPermissionConstants.AdminWrite]
        },
        new ApiRouteModel
        {
            Name = "VerifyEmailConfirmationTokenAsync", Path = VerifyEmailConfirmationToken,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "VerifyEmailTwoFactorTokenAsync", Path = VerifyEmailTwoFactorToken,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "VerifyPhoneNumberConfirmationTokenAsync", Path = VerifyPhoneNumberConfirmationToken,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "VerifySmsTwoFactorTokenAsync", Path = VerifySmsTwoFactorToken,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "VerifyUserTokenAsync", Path = VerifyUserToken,
            Permissions = [ApiPermissionConstants.Anonymous]
        },

        // Identity Resources
        new ApiRouteModel
        {
            Name = "AddIdentityResourceAsync", Path = AddIdentityResource,
            Permissions = [ApiPermissionConstants.IdentityResourceWrite, ApiPermissionConstants.IdentityResourceManage]
        },
        new ApiRouteModel
        {
            Name = "UpdateIdentityResourceAsync", Path = UpdateIdentityResource,
            Permissions = [ApiPermissionConstants.IdentityResourceWrite, ApiPermissionConstants.IdentityResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteIdentityResourceAsync", Path = DeleteIdentityResourceById,
            Permissions = [ApiPermissionConstants.IdentityResourceDelete, ApiPermissionConstants.IdentityResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteIdentityResourceAsync", Path = DeleteIdentityResourceByName,
            Permissions = [ApiPermissionConstants.IdentityResourceDelete, ApiPermissionConstants.IdentityResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetIdentityResourceAsync", Path = GetIdentityResourceById,
            Permissions = [ApiPermissionConstants.IdentityResourceRead, ApiPermissionConstants.IdentityResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetIdentityResourceAsync", Path = GetIdentityResourceByName,
            Permissions = [ApiPermissionConstants.IdentityResourceRead, ApiPermissionConstants.IdentityResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetAllIdentityResourcesAsync", Path = GetAllIdentityResources,
            Permissions = [ApiPermissionConstants.IdentityResourceRead, ApiPermissionConstants.IdentityResourceManage]
        },
        new ApiRouteModel
        {
            Name = "AddIdentityResourceClaimAsync", Path = AddIdentityResourceClaim,
            Permissions = [ApiPermissionConstants.IdentityResourceWrite, ApiPermissionConstants.IdentityResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteIdentityResourceClaimByIdAsync", Path = DeleteIdentityResourceClaimById,
            Permissions = [ApiPermissionConstants.IdentityResourceDelete, ApiPermissionConstants.IdentityResourceManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteIdentityResourceClaimAsync", Path = DeleteIdentityResourceClaimModel,
            Permissions = [ApiPermissionConstants.IdentityResourceDelete, ApiPermissionConstants.IdentityResourceManage]
        },
        new ApiRouteModel
        {
            Name = "GetIdentityResourceClaimsAsync", Path = GetIdentityResourceClaims,
            Permissions = [ApiPermissionConstants.IdentityResourceRead, ApiPermissionConstants.IdentityResourceManage]
        },

        // RoleService
        new ApiRouteModel
        {
            Name = "CreateRoleAsync", Path = CreateRole,
            Permissions = [ApiPermissionConstants.RoleWrite, ApiPermissionConstants.RoleManage]
        },
        new ApiRouteModel
        {
            Name = "UpdateRoleAsync", Path = UpdateRole,
            Permissions = [ApiPermissionConstants.RoleWrite, ApiPermissionConstants.RoleManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteRoleAsync", Path = DeleteRoleById,
            Permissions = [ApiPermissionConstants.RoleDelete, ApiPermissionConstants.RoleManage]
        },
        new ApiRouteModel
        {
            Name = "DeleteRoleAsync", Path = DeleteRoleByName,
            Permissions = [ApiPermissionConstants.RoleDelete, ApiPermissionConstants.RoleManage]
        },
        new ApiRouteModel
        {
            Name = "GetRoleAsync", Path = GetRoleById,
            Permissions = [ApiPermissionConstants.RoleRead, ApiPermissionConstants.RoleManage]
        },
        new ApiRouteModel
        {
            Name = "GetRoleAsync", Path = GetRoleByName,
            Permissions = [ApiPermissionConstants.RoleRead, ApiPermissionConstants.RoleManage]
        },
        new ApiRouteModel
        {
            Name = "GetAllRolesAsync", Path = GetAllRoles,
            Permissions = [ApiPermissionConstants.RoleRead, ApiPermissionConstants.RoleManage]
        },
        new ApiRouteModel
        {
            Name = "AddRoleClaimAsync", Path = AddRoleClaim,
            Permissions = [ApiPermissionConstants.RoleWrite, ApiPermissionConstants.RoleManage]
        },
        new ApiRouteModel
        {
            Name = "AddRoleClaimsAsync", Path = AddRoleClaimList,
            Permissions = [ApiPermissionConstants.RoleWrite, ApiPermissionConstants.RoleManage]
        },
        new ApiRouteModel
        {
            Name = "RemoveRoleClaimAsync", Path = RemoveRoleClaim,
            Permissions = [ApiPermissionConstants.RoleDelete, ApiPermissionConstants.RoleManage]
        },
        new ApiRouteModel
        {
            Name = "RemoveRoleClaimsAsync", Path = RemoveRoleClaimsList,
            Permissions = [ApiPermissionConstants.RoleDelete, ApiPermissionConstants.RoleManage]
        },
        new ApiRouteModel
        {
            Name = "RemoveRoleClaimsAsync", Path = RemoveRoleClaimsById,
            Permissions = [ApiPermissionConstants.RoleDelete, ApiPermissionConstants.RoleManage]
        },
        new ApiRouteModel
        {
            Name = "GetRoleClaimAsync", Path = GetRoleClaim,
            Permissions = [ApiPermissionConstants.RoleRead, ApiPermissionConstants.RoleManage]
        },

        // Authentication Service
        new ApiRouteModel
        {
            Name = "GenerateRecoveryCodesAsync", Path = GenerateRecoveryCodes,
            Permissions =
            [
                ApiPermissionConstants.UserWrite, ApiPermissionConstants.AdminWrite, ApiPermissionConstants.AdminManage
            ]
        },
        new ApiRouteModel
        {
            Name = "IsUserSignedInAsync", Path = IsUserSignedIn,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "PasswordSignInAsync", Path = PasswordSignIn,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "PasswordSignInAsync", Path = PasswordSignInByTwoFactorAuthenticatorToken,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "ResetAuthenticatorAppAsync", Path = ResetAuthenticatorApp,
            Permissions =
            [
                ApiPermissionConstants.UserWrite, ApiPermissionConstants.AdminWrite, ApiPermissionConstants.AdminManage
            ]
        },
        new ApiRouteModel
        {
            Name = "RopValidateCredentialsAsync", Path = RopValidateCredentials,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "SetupAuthenticatorAppAsync", Path = SetupAuthenticatorApp,
            Permissions = [ApiPermissionConstants.UserWrite]
        },
        new ApiRouteModel
        {
            Name = "SignOutAsync", Path = SignOut,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "TwoFactorAuthenticatorAppSignInAsync", Path = TwoFactorAuthenticatorAppSignIn,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "TwoFactorEmailSignInAsync", Path = TwoFactorEmailSignIn,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "TwoFactorRecoveryCodeSignInAsync", Path = TwoFactorRecoveryCodeSignIn,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "TwoFactorSmsSignInAsync", Path = TwoFactorSmsSignInAsync,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "VerifyAuthenticatorAppSetupAsync", Path = VerifyAuthenticatorAppSetup,
            Permissions = [ApiPermissionConstants.UserWrite]
        },
        new ApiRouteModel
        {
            Name = "CountRecoveryCodesAsync", Path = CountRecoveryCodesAsync,
            Permissions = [ApiPermissionConstants.UserWrite, ApiPermissionConstants.UserManage]
        },

        // Audit Trail
        new ApiRouteModel
        {
            Name = "AddAuditTrailAsync", Path = AddAuditTrail,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "AddAuditTrailAsync", Path = AddAuditTrailModel,
            Permissions = [ApiPermissionConstants.Anonymous]
        },
        new ApiRouteModel
        {
            Name = "GetAuditDetailsAsync", Path = GetAuditDetails,
            Permissions = [ApiPermissionConstants.AuditRead, ApiPermissionConstants.AuditManage]
        },
        //new ApiRouteModel { Name = "GetAuditDetailsAsync", Path = GetAuditDetailsByCreatedOn, Permissions = new List<string> { ApiPermissionConstants.AuditRead, ApiPermissionConstants.AuditManage } },
        //new ApiRouteModel { Name = "GetAuditDetailsAsync", Path = GetAuditDetailsByFromDate, Permissions = new List<string> { ApiPermissionConstants.AuditRead, ApiPermissionConstants.AuditManage } },
        //new ApiRouteModel { Name = "GetAuditDetailsAsync", Path = GetAuditDetailsByActionType, Permissions = new List<string> { ApiPermissionConstants.AuditRead, ApiPermissionConstants.AuditManage } },

        // Client
        new ApiRouteModel
        {
            Name = "DeleteClientAsync", Path = DeleteClient,
            Permissions = [ApiPermissionConstants.ClientDelete, ApiPermissionConstants.ClientManage]
        },
        new ApiRouteModel
        {
            Name = "GenerateClientSecret", Path = GenerateClientSecret,
            Permissions = [ApiPermissionConstants.ClientWrite, ApiPermissionConstants.ClientManage]
        },
        new ApiRouteModel
        {
            Name = "GetAllClientAsync", Path = GetAllClient,
            Permissions = [ApiPermissionConstants.ClientRead, ApiPermissionConstants.ClientManage]
        },
        new ApiRouteModel
        {
            Name = "GetClientAsync", Path = GetClient,
            Permissions = [ApiPermissionConstants.ClientRead, ApiPermissionConstants.ClientManage]
        },
        new ApiRouteModel
        {
            Name = "RegisterClientAsync", Path = RegisterClient,
            Permissions = [ApiPermissionConstants.ClientWrite, ApiPermissionConstants.ClientManage]
        },
        new ApiRouteModel
        {
            Name = "UpdateClientAsync", Path = UpdateClient,
            Permissions = [ApiPermissionConstants.ClientWrite, ApiPermissionConstants.ClientManage]
        },

        // Security Token
        new ApiRouteModel
        {
            Name = "GetActiveSecurityTokensAsync", Path = GetActiveSecurityTokensByClientIds,
            Permissions = [ApiPermissionConstants.SecurityTokenManage, ApiPermissionConstants.SecurityTokenRead]
        },
        new ApiRouteModel
        {
            Name = "GetActiveSecurityTokensAsync", Path = GetActiveSecurityTokensByUserIds,
            Permissions = [ApiPermissionConstants.SecurityTokenManage, ApiPermissionConstants.SecurityTokenRead]
        },
        new ApiRouteModel
        {
            Name = "GetActiveSecurityTokensAsync", Path = GetActiveSecurityTokensBetweenDates,
            Permissions = [ApiPermissionConstants.SecurityTokenManage, ApiPermissionConstants.SecurityTokenRead]
        },
        new ApiRouteModel
        {
            Name = "GetActiveSecurityTokensAsync", Path = GetAllSecurityTokensBetweenDates,
            Permissions = [ApiPermissionConstants.SecurityTokenManage, ApiPermissionConstants.SecurityTokenRead]
        }
    ];
}
