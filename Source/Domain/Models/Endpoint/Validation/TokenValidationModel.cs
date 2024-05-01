using Domain.Models.Endpoint.Response;

namespace Domain.Models.Endpoint.Validation;

/// <summary>
/// Domain Model representing Token validation.
/// </summary>
public class TokenValidationModel : ErrorResponseModel
{
    /// <summary>
    /// Gets or sets a value indicating the refresh token.
    /// </summary>
    public SecurityTokenModel RefreshToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the Client model.
    /// </summary>
    public ClientsModel Client { get; set; }
}