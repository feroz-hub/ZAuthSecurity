namespace Domain.Models.Endpoint;
/// <summary>
/// Domain model representing the Client redirect uris.
/// </summary>
public class ClientRedirectUrisModel : BaseModel
{
    /// <summary>
    /// Gets or sets the Client identifier.
    /// </summary>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Gets or sets the redirect uri.
    /// </summary>
    public string RedirectUri { get; set; }
}