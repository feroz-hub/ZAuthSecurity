namespace DomainServices.Infra;

/// <summary>
/// Interface defining operations for handling resource strings.
/// </summary>
public interface IResourceStringHandler
{
    /// <summary>
    /// Retrieves the resource string for the specified ID.
    /// </summary>
    /// <param name="id">The ID of the resource string.</param>
    /// <param name="skipError">Optional. Indicates whether to skip errors if the resource string is not found. Default is false.</param>
    /// <returns>The resource string corresponding to the ID, or an empty string if not found (unless skipError is true).</returns>
    string GetResourceString(string id, bool skipError = false);

    /// <summary>
    /// Retrieves the resource key associated with the specified value.
    /// </summary>
    /// <param name="value">The value of the resource string.</param>
    /// <returns>The resource key corresponding to the value, or null if not found.</returns>
    string GetResourceKeyByValue(string value);
}
