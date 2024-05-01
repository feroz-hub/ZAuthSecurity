using System.ComponentModel;

namespace Domain.Models.Endpoint.Response;

/// <summary>
/// Domain Model representing Error Response.
/// </summary>
public class ErrorResponseModel
{
    /// <summary>
    /// Gets or sets a value indicating whether it is error.
    /// </summary>
    public bool IsError { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating the error short description/error_code.
    /// </summary>
    [DisplayName("error")]
    public string ErrorCode { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the error brief description.
    /// </summary>
    [DisplayName("error_description")]
    public string ErrorDescription { get; set; }
}

/// <summary>
/// Domain Model representing Error Response.
/// </summary>
public class ErrorResponseResultModel
{
    /// <summary>
    /// Gets or sets a value indicating the error short description/error_code.
    /// </summary>
    public string Error { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the error brief description.
    /// </summary>
    public string ErrorDescription { get; set; }
}