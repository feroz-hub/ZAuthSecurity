namespace Domain.Models.Endpoint;
/// <summary>
/// Domain Model representing Logout Message.
/// </summary>
public class LogoutMessageModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LogoutMessageModel"/> class.
    /// </summary>
    public LogoutMessageModel()
    {
    }

    /// <summary>
    /// Gets or sets the client identifier.
    /// </summary>
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or sets the post logout redirect URI.
    /// </summary>
    public string PostLogoutRedirectUri { get; set; }

    /// <summary>
    /// Gets or sets the subject identifier for the user at logout time.
    /// </summary>
    public string SubjectId { get; set; }

    /// <summary>
    /// Gets or sets the session identifier for the user at logout time.
    /// </summary>
    public string SessionId { get; set; }

    /// <summary>
    /// Gets or sets the Ids of clients known to have an authentication session for user at end session time.
    /// </summary>
    public IEnumerable<string> ClientIdCollection { get; set; }

    /// <summary>
    /// Gets or sets the entire parameter collection.
    /// </summary>
    public Dictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>();

    /// <summary>
    ///  Gets a value indicating whether the payload contains useful information or not to avoid serialization.
    /// </summary>
    public bool HasClient => !string.IsNullOrWhiteSpace(ClientId) || ClientIdCollection?.Any() == true;
}