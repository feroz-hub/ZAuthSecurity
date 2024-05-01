namespace Domain
{
    /// <summary>
    /// Represents global configuration settings for the application.
    /// </summary>
    public class GlobalConfiguration
    {
        /// <summary>
        /// Gets or sets a value indicating whether the email configuration is valid.
        /// </summary>
        public static bool IsEmailConfigurationValid { get; set; } = false;
        
        /// <summary>
        /// Gets or sets a value indicating whether the SMS configuration is valid.
        /// </summary>
        public static bool IsSmsConfigurationValid { get; set; } = false;
        
        /// <summary>
        /// Gets or sets a value indicating whether the LDAP configuration is valid.
        /// </summary>
        public static bool IsLdapConfigurationValid { get; set; } = false;
    }
}