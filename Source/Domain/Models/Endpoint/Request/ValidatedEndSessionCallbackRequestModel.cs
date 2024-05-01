using Domain.Models.Endpoint.Validation;

namespace Domain.Models.Endpoint.Request;

/// <summary>
/// Domain Model representing Validated EndSession Callback Request.
/// </summary>
public class ValidatedEndSessionCallbackRequestModel : ValidatedBaseModel
{
    /// <summary>
    /// Gets or sets value indicating client front-channel logout urls.
    /// </summary>
    public IEnumerable<string> FrontChannelLogoutUrls { get; set; }
}