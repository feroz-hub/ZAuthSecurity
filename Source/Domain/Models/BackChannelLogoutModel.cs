using Domain.Models.Endpoint;

namespace Domain.Models;
/// <summary>
/// Domain Model representing back channel Logout Model.
/// </summary>
public class BackChannelLogoutModel
{
    /// <summary>
    /// Gets or sets the client identifier.
    /// </summary>
    public string ClientId { get; set; }
    /// <summary>
    /// Gets or sets the subject identifier for the user at logout time.
    /// </summary>
    public string SubjectId { get; set; }
    /// <summary>
    /// Gets or sets the session identifier for the user at logout time.
    /// </summary>
    public string SessionId { get; set; }
    /// <summary>
    /// Gets or sets the logout redirect URI.
    /// </summary>
    public string LogoutUri { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether session identifier required for the user at logout time.
    /// </summary>
    public bool SessionIdRequired { get; set; }
    /// <summary>
    /// Gets or sets the value indicating client.
    /// </summary>
    public ClientsModel Client { get; set; }
}