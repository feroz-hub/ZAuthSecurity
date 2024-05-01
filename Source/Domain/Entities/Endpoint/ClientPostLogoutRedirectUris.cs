namespace Domain.Entities.Endpoint;

/// <summary>
/// Represents a post logout redirect URI associated with a client.
/// </summary>
public class ClientPostLogoutRedirectUris : BaseEntity
{
    /// <summary>
    /// Gets or sets the ID of the client associated with the post logout redirect URI.
    /// </summary>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Gets or sets the post logout redirect URI.
    /// </summary>
    public string PostLogoutRedirectUri { get; set; }

    /// <summary>
    /// Gets or sets the client entity associated with the post logout redirect URI.
    /// </summary>
    public Clients Client { get; set; }
}