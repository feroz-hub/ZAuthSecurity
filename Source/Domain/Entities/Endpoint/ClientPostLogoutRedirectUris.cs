namespace Domain.Entities.Endpoint;

/// <summary>
/// DB Entity representing ClientPostLogoutRedirectUris table.
/// </summary>
public class ClientPostLogoutRedirectUris : BaseEntity
{
    /// <summary>
    /// Gets or sets the Client Identifier.
    /// </summary>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Gets or sets the Post Logout RedirectUri.
    /// </summary>
    public string PostLogoutRedirectUri { get; set; }

    /// <summary>
    /// Gets or sets the Clients.
    /// </summary>
    public Clients Client { get; set; }
}