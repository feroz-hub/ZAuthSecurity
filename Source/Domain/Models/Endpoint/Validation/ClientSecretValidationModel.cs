using Domain.Models.Endpoint.Response;

namespace Domain.Models.Endpoint.Validation;

/// <summary>
/// Domain Model representing Client secret validation model.
/// </summary>
public class ClientSecretValidationModel : ErrorResponseModel
{
    /// <summary>
    /// Gets or sets a value indicating the Client model.
    /// </summary>
    public ClientsModel Client { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Parsed secret model.
    /// </summary>
    public ParsedSecretModel Secret { get; set; }
}