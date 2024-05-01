namespace Domain.Models.Endpoint;

/// <summary>
/// Domain model representing the client post logout redirect uris.
/// </summary>
public class ClientPostLogoutRedirectUrisModel : BaseModel
{
    /// <summary>
    /// Gets or sets the client identifier.
    /// </summary>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Gets or sets the post logout redirect uri.
    /// </summary>
    public string PostLogoutRedirectUri { get; set; }
}