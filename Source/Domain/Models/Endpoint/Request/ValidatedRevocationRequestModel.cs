using Domain.Models.Endpoint.Validation;

namespace Domain.Models.Endpoint.Request;

/// <summary>
/// Represents a model for a validated revocation request, extending the validated base model.
/// </summary>
public class ValidatedRevocationRequestModel : ValidatedBaseModel
{
    /// <summary>
    /// Gets or sets the token type hint.
    /// </summary>
    public string TokenTypeHint { get; set; }

    /// <summary>
    /// Gets or sets the token.
    /// </summary>
    public string Token { get; set; }
}
