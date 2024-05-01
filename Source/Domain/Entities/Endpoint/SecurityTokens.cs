namespace Domain.Entities.Endpoint;

/// <summary>
/// Represents a security token entity.
/// </summary>
public class SecurityTokens : BaseEntity
{
    /// <summary>
    /// Gets or sets the key of the security token.
    /// </summary>
    public virtual string Key { get; set; }

    /// <summary>
    /// Gets or sets the type of the token.
    /// </summary>
    public virtual string TokenType { get; set; }

    /// <summary>
    /// Gets or sets the value of the token.
    /// </summary>
    public virtual string TokenValue { get; set; }

    /// <summary>
    /// Gets or sets the client ID associated with the token.
    /// </summary>
    public virtual string ClientId { get; set; }

    /// <summary>
    /// Gets or sets the session ID associated with the token.
    /// </summary>
    public virtual string SessionId { get; set; }

    /// <summary>
    /// Gets or sets the subject ID associated with the token.
    /// </summary>
    public virtual string SubjectId { get; set; }

    /// <summary>
    /// Gets or sets the creation time of the token.
    /// </summary>
    public virtual DateTime CreationTime { get; set; }

    /// <summary>
    /// Gets or sets the expiration time of the token.
    /// </summary>
    public virtual int ExpiresAt { get; set; }

    /// <summary>
    /// Gets or sets the time when the token was consumed.
    /// </summary>
    public virtual DateTime ConsumedTime { get; set; }
}