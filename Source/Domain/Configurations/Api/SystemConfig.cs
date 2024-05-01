using Domain.Enums;

namespace Domain.Configurations.Api
{
    /// <summary>
    /// Represents configuration settings for the database.
    /// </summary>
    public class DbConfig
    {
        /// <summary>
        /// Gets or sets the type of database.
        /// </summary>
        public DbTypes Database { get; set; }

        /// <summary>
        /// Gets or sets the connection string for the database.
        /// </summary>
        public string DbConnectionString { get; set; }
    }

    /// <summary>
    /// Represents configuration settings related to user login.
    /// </summary>
    public class LoginConfig
    {
        /// <summary>
        /// Gets or sets a value indicating whether login session should be persistent.
        /// </summary>
        public bool IsPersistent { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether to lock out the user after login failure.
        /// </summary>
        public bool LockoutOnFailure { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether to remember the client.
        /// </summary>
        public bool RememberClient { get; set; } = false;
    }

    /// <summary>
    /// Represents configuration settings related to user accounts.
    /// </summary>
   /// <summary>
    /// Represents configuration settings related to user accounts.
    /// </summary>
    public class UserConfig
    {
        /// <summary>
        /// Gets or sets the minimum length allowed for user names.
        /// </summary>
        public int MinUserNameLength { get; set; } = 6;

        /// <summary>
        /// Gets or sets the maximum length allowed for user names.
        /// </summary>
        public int MaxUserNameLength { get; set; } = 255;

        /// <summary>
        /// Gets or sets the minimum length allowed for first and last names.
        /// </summary>
        public int MinFirstAndLaseNameLength { get; set; } = 2;

        /// <summary>
        /// Gets or sets the maximum length allowed for first and last names.
        /// </summary>
        public int MaxFirstAndLaseNameLength { get; set; } = 255;

        /// <summary>
        /// Gets or sets the minimum length allowed for phone numbers.
        /// </summary>
        public int MinPhoneNumberLength { get; set; } = 4;

        /// <summary>
        /// Gets or sets the maximum length allowed for phone numbers.
        /// </summary>
        public int MaxPhoneNumberLength { get; set; } = 15;

        /// <summary>
        /// Gets or sets the minimum number of security questions required.
        /// </summary>
        public int MinNoOfQuestions { get; set; } = 3;

        /// <summary>
        /// Gets or sets the minimum length allowed for security answers.
        /// </summary>
        public int MinSecurityAnswersLength { get; set; } = 3;

        /// <summary>
        /// Gets or sets the minimum year allowed for date of birth.
        /// </summary>
        public int MinDobYear { get; set; } = 18;

        /// <summary>
        /// Gets or sets the maximum year allowed for date of birth.
        /// </summary>
        public int MaxDobYear { get; set; } = 100;

        /// <summary>
        /// Gets or sets the maximum number of failed access attempts allowed before the account is locked.
        /// </summary>
        public int AccessFailedCount { get; set; } = 3;

        /// <summary>
        /// Gets or sets the maximum number of failed access attempts allowed.
        /// </summary>
        public int MaxFailedAccessAttempts { get; set; } = 5;

        /// <summary>
        /// Gets or sets the number of recovery codes required for account recovery.
        /// </summary>
        public int RequiredRecoveryCodes { get; set; } = 5;

        /// <summary>
        /// Gets or sets a value indicating whether a unique email is required for each user.
        /// </summary>
        public bool RequireUniqueEmail { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether email confirmation is required for new accounts.
        /// </summary>
        public bool RequireConfirmedEmail { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether phone number confirmation is required for new accounts.
        /// </summary>
        public bool RequireConfirmedPhoneNumber { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether account locking is allowed for new users.
        /// </summary>
        public bool LockOutAllowedForNewUsers { get; set; } = true;

        /// <summary>
        /// Gets or sets the default duration for account lockout in minutes.
        /// </summary>
        public int DefaultLockoutTimeSpanMinutes { get; set; } = 10;

        /// <summary>
        /// Gets or sets the maximum number of attempts allowed for invalid credentials.
        /// </summary>
        public int MaxRetryInvalidCredentials { get; set; } = 3;

        /// <summary>
        /// Gets or sets the expiration time for email confirmation tokens in minutes.
        /// </summary>
        public int EmailTokenExpiration { get; set; } = 720;

        /// <summary>
        /// Gets or sets the expiration time for one-time passwords (OTPs) in minutes.
        /// </summary>
        public int OtpTokenExpiration { get; set; } = 10;

        /// <summary>
        /// Gets or sets the expiration time for password reset tokens in minutes.
        /// </summary>
        public int PasswordResetTokenExpiration { get; set; } = 10;

        /// <summary>
        /// Gets or sets the expiration time for user tokens in minutes.
        /// </summary>
        public int UserTokenExpiration { get; set; } = 10;

        /// <summary>
        /// Gets or sets the duration for locking an account in minutes.
        /// </summary>
        public int LockAccountPeriod { get; set; } = 45;

        /// <summary>
        /// Gets or sets the default role assigned to new users.
        /// </summary>
        public string DefaultUserRole { get; set; } = "SFUser";
    }


   /// <summary>
    /// Represents configuration settings related to user passwords.
    /// </summary>
    public class PasswordConfig
    {
        /// <summary>
        /// Gets or sets the minimum length allowed for passwords.
        /// </summary>
        public int MinPasswordLength { get; set; } = 8;

        /// <summary>
        /// Gets or sets the maximum length allowed for passwords.
        /// </summary>
        public int MaxPasswordLength { get; set; } = 64;

        /// <summary>
        /// Gets or sets the number of unique characters required in passwords.
        /// </summary>
        public int RequiredUniqueCharacters { get; set; } = 8;

        /// <summary>
        /// Gets or sets a value indicating whether passwords must contain at least one digit.
        /// </summary>
        public bool RequireDigit { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether passwords must contain at least one lowercase letter.
        /// </summary>
        public bool RequireLowercase { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether passwords must contain at least one uppercase letter.
        /// </summary>
        public bool RequireUppercase { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether passwords must contain at least one special character.
        /// </summary>
        public bool RequireSpecialCharacters { get; set; } = true;

        /// <summary>
        /// Gets or sets the pattern that passwords must match.
        /// </summary>
        public string PasswordPattern { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of previous passwords that cannot be reused.
        /// </summary>
        public int MaxLimitPasswordReuse { get; set; } = 10;

        /// <summary>
        /// Gets or sets the maximum expiration period for passwords in days.
        /// </summary>
        public int MaxPasswordExpiration { get; set; } = 42;

        /// <summary>
        /// Gets or sets the number of days before password expiration to notify the user.
        /// </summary>
        public int PasswordNotificationBeforeExpiration { get; set; } = 3;
    }

    /// <summary>
    /// Represents configuration settings related to email.
    /// </summary>
    public class EmailConfig
    {
        /// <summary>
        /// Gets or sets the SMTP server address.
        /// </summary>
        public string SmtpServer { get; set; }

        /// <summary>
        /// Gets or sets the port number for the SMTP server.
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets the username for authenticating with the SMTP server.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password for authenticating with the SMTP server.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the type of email notifications to send.
        /// </summary>
        public EmailNotificationType EmailNotificationType { get; set; } = EmailNotificationType.Link;

        /// <summary>
        /// Gets or sets a value indicating whether to use secure socket options.
        /// </summary>
        public bool SecureSocketOptions { get; set; }
    }

    /// <summary>
    /// Represents an email template.
    /// </summary>
    public class EmailTemplate
    {
        /// <summary>
        /// Gets or sets the name of the email template.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the subject of the email template.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the email address from which the email will be sent.
        /// </summary>
        public string FromAddress { get; set; }

        /// <summary>
        /// Gets or sets the name associated with the email address from which the email will be sent.
        /// </summary>
        public string FromName { get; set; }

        /// <summary>
        /// Gets or sets the email addresses to which a copy of the email will be sent.
        /// </summary>
        public string Cc { get; set; }

        /// <summary>
        /// Gets or sets the format of the email template.
        /// </summary>
        public string TemplateFormat { get; set; }
    }

    /// <summary>
    /// Represents configuration settings related to SMS.
    /// </summary>
    public class SmsConfig
    {
        /// <summary>
        /// Gets or sets the account identification for SMS.
        /// </summary>
        public string SmsAccountIdentification { get; set; }

        /// <summary>
        /// Gets or sets the account password for SMS.
        /// </summary>
        public string SmsAccountPassword { get; set; }

        /// <summary>
        /// Gets or sets the sender's identification for SMS.
        /// </summary>
        public string SmsAccountFrom { get; set; }

        /// <summary>
        /// Gets or sets the URL for receiving SMS status callbacks.
        /// </summary>
        public string SmsStatusCallbackUrl { get; set; }
    }

    /// <summary>
    /// Represents an SMS template.
    /// </summary>
    public class SmsTemplate
    {
        /// <summary>
        /// Gets or sets the name of the SMS template.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the format of the SMS template.
        /// </summary>
        public string TemplateFormat { get; set; }
    }

    /// <summary>
    /// Represents configuration settings related to LDAP.
    /// </summary>
    public class LdapConfig
    {
        /// <summary>
        /// Gets or sets the hostname of the LDAP server.
        /// </summary>
        public string LdapHostName { get; set; }

        /// <summary>
        /// Gets or sets the domain name for LDAP.
        /// </summary>
        public string LdapDomainName { get; set; }

        /// <summary>
        /// Gets or sets the port number for LDAP.
        /// </summary>
        public int LdapPort { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the connection to LDAP is secure.
        /// </summary>
        public bool IsSecureConnection { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether two-factor authentication is required for LDAP.
        /// </summary>
        public bool IsTwoFactorAuthenticationRequired { get; set; } = false;

        /// <summary>
        /// Gets or sets the type of two-factor authentication required for LDAP.
        /// </summary>
        public virtual TwoFactorType TwoFactorType { get; set; } = TwoFactorType.None;
    }

    /// <summary>
    /// Represents configuration settings related to cryptography.
    /// </summary>
    public class CryptoConfig
    {
        /// <summary>
        /// Gets or sets the length of random strings generated for cryptographic purposes.
        /// </summary>
        public int RandomStringLength { get; set; } = 32;
    }
}
