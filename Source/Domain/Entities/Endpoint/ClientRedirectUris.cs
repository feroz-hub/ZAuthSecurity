namespace Domain.Entities.Endpoint;

/// <summary>
/// Represents a client redirect URI entity.
/// </summary>
public class ClientRedirectUris : BaseEntity
{
    /// <summary>
    /// Gets or sets the ID of the client associated with the redirect URI.
    /// </summary>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Gets or sets the redirect URI.
    /// </summary>
    public string RedirectUri { get; set; }

    /// <summary>
    /// Gets or sets the client associated with the redirect URI.
    /// </summary>
    public Clients Client { get; set; }
}