namespace Domain.Entities.Endpoint;

/// <summary>
/// DB Entity representing ClientRedirectUris table.
/// </summary>
public class ClientRedirectUris : BaseEntity
{
    /// <summary>
    /// Gets or sets the Client Identifier.
    /// </summary>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Gets or sets the RedirectUri.
    /// </summary>
    public string RedirectUri { get; set; }

    /// <summary>
    /// Gets or sets the Clients.
    /// </summary>
    public Clients Client { get; set; }
}