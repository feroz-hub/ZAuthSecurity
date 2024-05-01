namespace Domain.Enums
{
    /// <summary>
    /// Represents query options for filtering data.
    /// </summary>
    public enum QueryOption
    {
        /// <summary>
        /// Filter data by date.
        /// </summary>
        Date = 1,

        /// <summary>
        /// Filter data by created by and date.
        /// </summary>
        CreatedByAndDate = 2,

        /// <summary>
        /// Filter data by created by and between dates.
        /// </summary>
        CreatedByAndBetweenDates = 3,

        /// <summary>
        /// Filter data by created by with action and between dates.
        /// </summary>
        CreatedByWithActionAndBetweenDates = 4,

        /// <summary>
        /// No filtering option.
        /// </summary>
        None = 5
    }

    /// <summary>
    /// Represents the status of a notification.
    /// </summary>
    public enum NotificationStatus
    {
        /// <summary>
        /// Notification initiated but not yet processed.
        /// </summary>
        Initiated = 1,

        /// <summary>
        /// Notification delivered successfully.
        /// </summary>
        Delivered = 2,

        /// <summary>
        /// Notification delivery failed.
        /// </summary>
        Failed = 3,

        /// <summary>
        /// Notification delayed in delivery.
        /// </summary>
        Delayed = 4,

        /// <summary>
        /// Notification relayed to another system for delivery.
        /// </summary>
        Relayed = 5,

        /// <summary>
        /// Notification expanded for delivery to multiple recipients.
        /// </summary>
        Expanded = 6,

        /// <summary>
        /// Notification queued for delivery.
        /// </summary>
        Queued = 7,

        /// <summary>
        /// Notification being sent.
        /// </summary>
        Sending = 8,

        /// <summary>
        /// Notification sent successfully.
        /// </summary>
        Sent = 9,

        /// <summary>
        /// Notification undelivered.
        /// </summary>
        Undelivered = 10,

        /// <summary>
        /// Notification receiving in progress.
        /// </summary>
        Receiving = 11,

        /// <summary>
        /// Notification received successfully.
        /// </summary>
        Received = 12,

        /// <summary>
        /// Notification accepted by the recipient.
        /// </summary>
        Accepted = 13,

        /// <summary>
        /// Notification scheduled for future delivery.
        /// </summary>
        Scheduled = 14,

        /// <summary>
        /// Notification read by the recipient.
        /// </summary>
        Read = 15,

        /// <summary>
        /// Notification partially delivered or received.
        /// </summary>
        Partially = 16
    }
    /// <summary>
    /// Represents types of notifications.
    /// </summary>
    public enum NotificationTypes
    {
        /// <summary>
        /// Notification sent via email.
        /// </summary>
        Email = 1,

        /// <summary>
        /// Notification sent via SMS.
        /// </summary>
        Sms = 2
    }
    /// <summary>
    /// Represents the type of email notification.
    /// </summary>
    public enum EmailNotificationType
    {
        /// <summary>
        /// Email notification containing a token.
        /// </summary>
        Token = 1,

        /// <summary>
        /// Email notification containing a link.
        /// </summary>
        Link = 2
    }
    /// <summary>
    /// Represents different identity providers.
    /// </summary>
    public enum IdentityProvider
    {
        /// <summary>
        /// Local identity provider.
        /// </summary>
        Local = 1,

        /// <summary>
        /// LDAP (Lightweight Directory Access Protocol) identity provider.
        /// </summary>
        Ldap = 2
    }

    /// <summary>
    /// Represents types of audit actions.
    /// </summary>
    public enum AuditType
    {
        /// <summary>
        /// No audit action.
        /// </summary>
        None = 0,

        /// <summary>
        /// Audit action for creation.
        /// </summary>
        Create = 1,

        /// <summary>
        /// Audit action for update.
        /// </summary>
        Update = 2,

        /// <summary>
        /// Audit action for deletion.
        /// </summary>
        Delete = 3
    }
    /// <summary>
    /// Represents types of two-factor authentication.
    /// </summary>
    public enum TwoFactorType
    {
        /// <summary>
        /// No two-factor authentication.
        /// </summary>
        None = 0,

        /// <summary>
        /// Two-factor authentication via email.
        /// </summary>
        Email = 1,

        /// <summary>
        /// Two-factor authentication via SMS.
        /// </summary>
        Sms = 2,

        /// <summary>
        /// Two-factor authentication via authenticator app.
        /// </summary>
        AuthenticatorApp = 3
    }

    /// <summary>
    /// Represents options for security tokens.
    /// </summary>
    public enum SecurityTokenOption
    {
        /// <summary>
        /// Token associated with a client.
        /// </summary>
        Client = 1,

        /// <summary>
        /// Token associated with a user.
        /// </summary>
        User = 2,

        /// <summary>
        /// Token valid between specified dates.
        /// </summary>
        BetweenDates = 3,

        /// <summary>
        /// All tokens.
        /// </summary>
        All = 4,

        /// <summary>
        /// No specific token option.
        /// </summary>
        None = 5
    }

    



    

}