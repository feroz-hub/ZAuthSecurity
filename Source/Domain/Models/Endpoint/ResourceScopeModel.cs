namespace Domain.Models.Endpoint;

/// <summary>
/// Domain Model representing Resource scope.
/// </summary>
public class ResourceScopeModel
{
    /// <summary>
    /// Gets or sets a value indicating the raw data as dictionary.
    /// </summary>
    public Dictionary<string, string> RawData { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the requested scope as list of string.
    /// </summary>
    public List<string> RequestedScope { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Client model.
    /// </summary>
    public ClientsModel Client { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the user name.
    /// </summary>
    public string UserName { get; set; }
}