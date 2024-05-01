using Domain.Configurations.Api;
using Domain.Configurations.Endpoint;

namespace Domain;
/// <summary>
/// Represents the configuration settings for the security framework, including system settings, notification template settings, and token settings.
/// </summary>
public class SecurityFrameworkConfig
{
    /// <summary>
    /// Gets or sets the system settings.
    /// </summary>
    public SystemSettings SystemSettings { get; set; } = new();

    /// <summary>
    /// Gets or sets the notification template settings.
    /// </summary>
    public NotificationTemplateSettings NotificationTemplateSettings { get; set; } = new();

    /// <summary>
    /// Gets or sets the token settings.
    /// </summary>
    public TokenSettings TokenSettings { get; set; } = new();
}

/// <summary>
/// Represents the system settings including database configuration, login configuration, user configuration, password configuration, email configuration, SMS configuration, LDAP configuration, cryptographic configuration, and log configuration.
/// </summary>
public class SystemSettings
{
    /// <summary>
    /// Gets or sets the database configuration.
    /// </summary>
    public DbConfig DbConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the login configuration.
    /// </summary>
    public LoginConfig LoginConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the user configuration.
    /// </summary>
    public UserConfig UserConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the password configuration.
    /// </summary>
    public PasswordConfig PasswordConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the email configuration.
    /// </summary>
    public EmailConfig EmailConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the SMS configuration.
    /// </summary>
    public SmsConfig SmsConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the LDAP configuration.
    /// </summary>
    public LdapConfig LdapConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the cryptographic configuration.
    /// </summary>
    public CryptoConfig CryptoConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the log configuration.
    /// </summary>
    public LogConfig LogConfig { get; set; } = new();
}

/// <summary>
/// Represents the Notification Template Settings.
/// </summary>
public class NotificationTemplateSettings
{
    /// <summary>
    /// Gets or sets the framework email template collections.
    /// </summary>
    public List<EmailTemplate> EmailTemplatesCollection{get; set; } = new();
    
    /// <summary>
    /// Gets or sets the framework SMS template collections.
    /// </summary>
    public List<SmsTemplate> SmsTemplatesCollection{get; set; } = new();
}

/// <summary>
/// Represents the token settings including token configuration, authentication configuration, input length restrictions configuration, user interaction configuration, endpoints configuration, and token expiration settings.
/// </summary>
public class TokenSettings
{
    /// <summary>
    /// Gets or sets the token configuration.
    /// </summary>
    public TokenConfig TokenConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the authentication configuration.
    /// </summary>
    public AuthenticationConfig AuthenticationConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the input length restrictions configuration.
    /// </summary>
    public InputLengthRestrictionsConfig InputLengthRestrictionsConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the user interaction configuration.
    /// </summary>
    public UserInteractionConfig UserInteractionConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the endpoints configuration.
    /// </summary>
    public EndpointsConfig EndpointsConfig { get; set; } = new();

    /// <summary>
    /// Gets or sets the token expiration settings.
    /// </summary>
    public TokenExpiration TokenExpiration { get; set; } = new();
}
