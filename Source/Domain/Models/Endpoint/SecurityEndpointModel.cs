using Microsoft.AspNetCore.Http;

namespace Domain.Models.Endpoint;

/// <summary>
/// Domain model representing security end point.
/// </summary>
public class SecurityEndpointModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SecurityEndpointModel"/> class.
    /// </summary>
    /// <param name="name">The name of the endpoint.</param>
    /// <param name="path">The endpoint path.</param>
    /// <param name="handlerType">The handler type.</param>
    public SecurityEndpointModel(string name, string path, Type handlerType)
    {
        Name = name;
        Path = path;
        Handler = handlerType;
    }

    /// <summary>
    /// Gets or sets a value indicating the endpoint path.
    /// </summary>
    public PathString Path { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the endpoint name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the endpoint type handler.
    /// </summary>
    public Type Handler { get; set; }
}