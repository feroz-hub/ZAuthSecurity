using System.ComponentModel;

namespace Domain.Models.Endpoint.Response;

/// <summary>
/// Domain Model representing Introspection response.
/// </summary>
public class IntrospectionResponseModel
{
    /// <summary>
    /// Gets or sets a value indicating whether the token is active.
    /// </summary>
    [DisplayName("active")]
    public bool Active { get;  set; }

    /// <summary>
    /// Gets or sets a value indicating the client id.
    /// </summary>
    [DisplayName("client_id")]
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the user name.
    /// </summary>
    [DisplayName("username")]
    public string UserName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the scope.
    /// </summary>
    [DisplayName("scope")]
    public string Scope { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Subject id.
    /// </summary>
    [DisplayName("sub")]
    public string SubjectId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the audience.
    /// </summary>
    [DisplayName("aud")]
    public string Audience { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the issuer.
    /// </summary>
    [DisplayName("iss")]
    public string Issuer { get; set; }

    /// <summary>
    /// Gets or sets a value indicating when the token expires at.
    /// </summary>
    [DisplayName("exp")]
    public string ExpiresAt { get; set; }

    /// <summary>
    /// Gets or sets a value indicating when the token was issued at.
    /// </summary>
    [DisplayName("iat")]
    public string IssuedAt { get; set; }
}