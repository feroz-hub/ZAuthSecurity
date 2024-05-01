namespace Domain.Models.Endpoint;
/// <summary>
/// Domain model representing the Clients.
/// </summary>
public class TokenModel
{
    /// <summary>
    /// Gets or sets the Client Identifier.
    /// </summary>
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or sets the Client Name.
    /// </summary>
    public string ClientName { get; set; }

    /// <summary>
    /// Gets or sets the User Identifier.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets user name.
    /// </summary>
    public virtual string UserName { get; set; }

    /// <summary>
    /// Gets or sets user login date time.
    /// </summary>
    public virtual DateTime LoginDateTime { get; set; }

    /// <summary>
    /// Gets or sets token.
    /// </summary>
    public virtual string Token { get; set; }

    /// <summary>
    /// Gets or sets token hint.
    /// </summary>
    public virtual string TokenTypeHint { get; set; }
}