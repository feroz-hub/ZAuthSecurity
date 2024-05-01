namespace Domain.Models.Endpoint.Request;

/// <summary>
/// Represents a model for a discovery request, containing the base URL.
/// </summary>
public class DiscoveryRequestModel
{
    /// <summary>
    /// Gets or sets the base URL.
    /// </summary>
    public virtual string BaseUrl { get; set; }
}
