namespace Domain.Models.Endpoint.Request;

/// <summary>
/// Represents a model for a logout request, extending the base logout message model.
/// </summary>
public class LogoutRequestModel : LogoutMessageModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LogoutRequestModel"/> class.
    /// </summary>
    /// <param name="endSessionCallBackUrl">The end session callback URL.</param>
    /// <param name="message">The logout message model.</param>
    public LogoutRequestModel(string endSessionCallBackUrl, LogoutMessageModel message)
    {
        if (message != null)
        {
            ClientId = message.ClientId;
            PostLogoutRedirectUri = message.PostLogoutRedirectUri;
            SubjectId = message.SubjectId;
            SessionId = message.SessionId;
            ClientIdCollection = message.ClientIdCollection;
            Parameters = message.Parameters;
        }
        EndSessionCallBackUrl = endSessionCallBackUrl;
    }

    /// <summary>
    /// Gets or sets the end session callback URL.
    /// </summary>
    public string EndSessionCallBackUrl { get; set; }

    /// <summary>
    /// Gets a value indicating whether to show the sign-out prompt.
    /// </summary>
    public bool ShowSignOutPrompt => string.IsNullOrWhiteSpace(ClientId);
}
