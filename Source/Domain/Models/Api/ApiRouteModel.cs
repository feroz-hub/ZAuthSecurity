namespace Domain.Models.Api;
public class ApiRouteModel
{
    /// <summary>
    /// Gets or sets the name for api.
    /// </summary>
    public virtual string Name { get; set; }

    /// <summary>
    /// Gets or sets the path to route.
    /// </summary>
    public virtual string Path { get; set; }

    /// <summary>
    /// Gets or sets the Permissions for api.
    /// </summary>
    public virtual List<string> Permissions { get; set; }
}