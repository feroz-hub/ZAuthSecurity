namespace Domain.Models.Endpoint;

/// <summary>
/// Domain model representing the Security tokens.
/// </summary>
public class SecurityTokenModel : BaseModel
{
    /// <summary>
    /// Gets or sets the value indicating a random key.
    /// </summary>
    public virtual string Key { get; set; }

    /// <summary>
    /// Gets or sets the value indicating token type.
    /// </summary>
    public virtual string TokenType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the token value.
    /// </summary>
    public virtual string TokenValue { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Consumed time.
    /// </summary>
    public virtual DateTime? ConsumedTime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Client id.
    /// </summary>
    public virtual string ClientId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the session id.
    /// </summary>
    public virtual string SessionId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the user id.
    /// </summary>
    public virtual string UserId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the subject id.
    /// </summary>
    public virtual string SubjectId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Creation time.
    /// </summary>
    public virtual DateTime CreationTime { get; set; }

    /// <summary>
    /// Gets or sets a value in seconds indicating when the security token expires at.
    /// </summary>
    public virtual int ExpiresAt { get; set; }
}