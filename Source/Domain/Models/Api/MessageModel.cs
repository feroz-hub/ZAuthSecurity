namespace Domain.Models.Api;

/// <summary>
/// Model for sending email.
/// </summary>
public class EmailMessageModel
{
    /// <summary>
    /// Gets or sets user identifier.
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Gets or sets sender's email address.
    /// </summary>
    public string FromAddress { get; set; }
    /// <summary>
    /// Gets or sets sender's user name.
    /// </summary>
    public string FromName { get; set; }
    /// <summary>
    /// Gets or sets to recipient's email address.
    /// </summary>
    public string ToAddress { get; set; }
    /// <summary>
    /// Gets or sets recipient's name.
    /// </summary>
    public string ToName { get; set; }
    /// <summary>
    /// Gets or sets subject of the email.
    /// </summary>
    public string Subject { get; set; }
    /// <summary>
    /// Gets or sets content of the email.
    /// </summary>
    public string Content { get; set; }
    /// <summary>
    /// Gets or sets user activity.
    /// </summary>
    public string Activity { get; set; }
    /// <summary>
    /// Gets or sets email template.
    /// </summary>
    public string TemplateName { get; set; }
    /// <summary>
    /// Gets or sets Carbon Copy email address.
    /// </summary>
    public string CC { get; set; }
    /// <summary>
    /// Gets or sets notification parameters with key and value.
    /// </summary>
    public Dictionary<string, string> Parameters { get; set; }
}
/// <summary>
/// Model for sending SMS.
/// </summary>
public class SmsMessage
{
    /// <summary>
    /// Gets or sets user identifier.
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Gets or sets recipient phone number.
    /// </summary>
    public string To { get; set; }
    /// <summary>
    /// Gets or sets SMS content.
    /// </summary>
    public string Content { get; set; }
    /// <summary>
    /// Gets or sets user action.
    /// </summary>
    public string Activity { get; set; }
    /// <summary>
    /// Gets or sets SMS template name.
    /// </summary>
    public string TemplateName { get; set; }
    /// <summary>
    /// Gets or sets notification parameters with key and value.
    /// </summary>
    public Dictionary<string, string> Parameters { get; set; }
}
