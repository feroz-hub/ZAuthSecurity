namespace Domain.Constants;

public class Constants
{
    public const string DefaultProvider = "Default";
    public const string DefaultEmailProvider = "Email";
    public const string DefaultPhoneProvider = "Phone";
    public const string DefaultAuthenticatorProvider = "Authenticator";
    public const string CreatedBy = "CreatedBy";
    public const string RoleTable = "Roles";
    public const string UserTable = "Users";

    public const int ColumnLength255 = 255;
    public const int ColumnLength2048 = 2048;

    public static readonly List<string> AllowedAuditTables =
        ["Roles", "RoleClaims", "Users", "UserClaims", "UserRoles","UserSecurityQuestions"];

    public static readonly List<string> IgnoredAuditColumns =
    [
        "Id", "NormalizedName", "ConCurrencyStamp", "NormalizedUserName", "NormalizedEmail", "PasswordHash",
        "SecurityStamp", "DateOfBirth", "RowVersion"
    ];
}

public class ResultCustomConstants
{
    public const string AuthorizeCodeRequestKey = "AuthorizeCodeRequestKey";
    public const string TokenRequestKey = "TokenRequestKey";
}

public class EncryptionKeyConstants
{
    public const string DefaultEncryptionKey="CSSecurityFramework";
    public const string RequestParameterEncryptedKey = "RPSecurityKey";
    public const string VerificationEncryptedKey="VerificationSecurityKey";
}

public class LoggerKeyConstants
{
    public const string DefaultLoggerKey = "CSSecurityFramework";
}

public class NotificationConstants
{
    public const string DefaultTemplate="DefaultTemplate";
    public const string EmailVerification="EmailVerification";
    public const string PhoneNumberVerification="PhoneNumberVerification";
    public const string EmailVerificationUsingLink="EmailVerificationUsingLink";
    public const string EmailVerificationUsingToken="EmailVerificationUsingToken";
    public const string PhoneNumberVerificationToken="PhoneNumberVerificationToken";
    public const string ResetPasswordUsingToken="ResetPasswordUsingToken";
}

public class PermissionsConstants
{
    public const string Read = ".read";
    public const string Write = ".write";
    public const string Delete = ".delete";
    public const string Manage = ".manage";
}
