namespace Domain.Entities.Api;

/// <summary>
/// DB Entity representing Notification table.
/// </summary>
public class Notification : BaseEntity
{
    /// <summary>
    /// Gets or sets the User Id.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets the Message Id.
    /// </summary>
    public string MessageId { get; set; }

    /// <summary>
    /// Gets or sets the Type.
    /// </summary>
    public NotificationTypes Type { get; set; }

    /// <summary>
    /// Gets or sets the Activity.
    /// </summary>
    public string Activity { get; set; }

    /// <summary>
    /// Gets or sets the Status.
    /// </summary>
    public NotificationStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the Sender.
    /// </summary>
    public string Sender { get; set; }

    /// <summary>
    /// Gets or sets the Recipient.
    /// </summary>
    public string Recipient { get; set; }

    /// <summary>
    /// Gets or sets the User.
    /// </summary>
    public virtual Users User { get; set; }
}