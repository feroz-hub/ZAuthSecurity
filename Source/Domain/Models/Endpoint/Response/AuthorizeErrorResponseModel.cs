using System.ComponentModel;

namespace Domain.Models.Endpoint.Response;

/// <summary>
/// Domain Model representing Error response.
/// </summary>
public class AuthorizeErrorResponseModel : ErrorResponseModel
{
    /// <summary>
    /// Gets or sets a value indicating the error uri.
    /// </summary>
    [DisplayName("error_uri")]
    public virtual string ErrorUri { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the state.
    /// </summary>
    [DisplayName("state")]
    public virtual string State { get; set; }

    // TODO Update the below 4 values where it is applicable.

    /// <summary>
    /// Gets or sets a value indicating the trace id.
    /// </summary>
    [DisplayName("trace_id")]
    public string TraceId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the client id.
    /// </summary>
    [DisplayName("client_id")]
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the redirect uri.
    /// </summary>
    [DisplayName("redirect_uri")]
    public string RedirectUri { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the response mode.
    /// </summary>
    [DisplayName("response_mode")]
    public string ResponseMode { get; set; }
}