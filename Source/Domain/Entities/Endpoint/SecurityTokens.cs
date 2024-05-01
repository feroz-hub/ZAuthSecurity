namespace Domain.Entities.Endpoint;

/// <summary>
/// DB Entity representing SecurityTokens table.
/// </summary>
public class SecurityTokens : BaseEntity
{
    /// <summary>
    /// Gets or sets the 32 bit random number Key for Security Token.
    /// </summary>
    public virtual string Key { get; set; }

    /// <summary>
    /// Gets or sets the type of Security Token. Currently supported values are Refresh token and Authorization code.
    /// </summary>
    public virtual string TokenType { get; set; }

    /// <summary>
    /// Gets or sets the value/data payload of Security Token.
    /// In Refresh token type, it will be access token raw payload.
    /// </summary>
    public virtual string TokenValue { get; set; }

    /// <summary>
    /// Gets or sets the Client identifier for which the Security Token was issued.
    /// </summary>
    public virtual string ClientId { get; set; }

    /// <summary>
    /// Gets or sets the Session identifier for which the Security Token was issued.
    /// </summary>
    public virtual string SessionId { get; set; }

    /// <summary>
    /// Gets or sets the Subject(user) identifier for which the Security Token was issued.
    /// </summary>
    public virtual string SubjectId { get; set; }

    /// <summary>
    /// Gets or sets the Datetime at which the Security Token was issued.
    /// </summary>
    public virtual DateTime CreationTime { get; set; }

    /// <summary>
    /// Gets or sets the time(seconds) at which the Security Token expires.
    /// </summary>
    public virtual int ExpiresAt { get; set; }

    /// <summary>
    /// Gets or sets the time at which the Security Token was consumed. If its null, it means a new fresh token.
    /// </summary>
    public virtual DateTime ConsumedTime { get; set; }
}