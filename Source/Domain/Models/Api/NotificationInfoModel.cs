namespace Domain.Models.Api;
/// <summary>
/// Model for collecting info from user to send email or SMS notification.
/// </summary>
public class NotificationInfoModel
{
    /// <summary>
    /// Gets or sets user identifier.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    ///  Gets or sets recipient's address.
    /// </summary>
    public string ToAddress { get; set; }

    /// <summary>
    /// Gets or sets user action or activity.
    /// </summary>
    public string Activity { get; set; }

    /// <summary>
    /// Gets or sets name of template for triggering SMS or Email.
    /// </summary>
    public string TemplateName { get; set; }

    /// <summary>
    /// Gets or sets notification parameters with key and value.
    /// </summary>
    public Dictionary<string, string> Parameters { get; set; }
}