using System.Runtime.CompilerServices;
using Domain;
using DomainValidation.Validation;

namespace DomainServices.Infra;

/// <summary>
/// Interface defining operations for creating framework results and handling errors.
/// </summary>
public interface IFrameworkResultService
{
    /// <summary>
    /// Creates a successful framework result.
    /// </summary>
    /// <returns>A successful framework result.</returns>
    FrameworkResult Succeeded();

    /// <summary>
    /// Creates a failed framework result with specified error code.
    /// </summary>
    /// <typeparam name="T">The type of the result.</typeparam>
    /// <param name="errorCode">The error code indicating the reason for failure.</param>
    /// <param name="callerMemberName">Optional. The name of the calling member.</param>
    /// <param name="sourceFilePath">Optional. The path of the source file.</param>
    /// <returns>A failed framework result of type T.</returns>
    T Failed<T>(string errorCode, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string sourceFilePath = null);

    /// <summary>
    /// Throws an exception with specified error code.
    /// </summary>
    /// <param name="errorCode">The error code indicating the reason for failure.</param>
    /// <param name="callerMemberName">Optional. The name of the calling member.</param>
    /// <param name="sourceFilePath">Optional. The path of the source file.</param>
    void Throw(string errorCode, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string sourceFilePath = null);

    /// <summary>
    /// Creates a validation error with specified OpenID error code and specific error code.
    /// </summary>
    /// <param name="openIdErrorCode">The OpenID error code.</param>
    /// <param name="specificErrorCode">The specific error code.</param>
    /// <param name="callerMemberName">Optional. The name of the calling member.</param>
    /// <param name="sourceFilePath">Optional. The path of the source file.</param>
    /// <returns>A validation error.</returns>
    ValidationError Failed(string openIdErrorCode, string specificErrorCode, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string sourceFilePath = null);

    /// <summary>
    /// Creates a failed framework result with specified errors.
    /// </summary>
    /// <param name="errors">The collection of framework errors.</param>
    /// <param name="callerMemberName">Optional. The name of the calling member.</param>
    /// <param name="sourceFilePath">Optional. The path of the source file.</param>
    /// <returns>A failed framework result.</returns>
    FrameworkResult Failed(IEnumerable<FrameworkError> errors, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string sourceFilePath = null);

    /// <summary>
    /// Constructs a failed framework result with specified error code and error message.
    /// </summary>
    /// <param name="errorCode">The error code indicating the reason for failure.</param>
    /// <param name="errorMessage">The error message describing the failure.</param>
    /// <param name="callerMemberName">Optional. The name of the calling member.</param>
    /// <param name="sourceFilePath">Optional. The path of the source file.</param>
    /// <returns>A failed framework result.</returns>
    FrameworkResult ConstructFailed(string errorCode, string errorMessage, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string sourceFilePath = null);

    /// <summary>
    /// Throws an exception with custom error message.
    /// </summary>
    /// <param name="customErrorMessage">The custom error message.</param>
    /// <param name="callerMemberName">Optional. The name of the calling member.</param>
    /// <param name="sourceFilePath">Optional. The path of the source file.</param>
    void ThrowCustomMessage(string customErrorMessage, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string sourceFilePath = null);

    /// <summary>
    /// Creates an empty result of specified type with specified error code.
    /// </summary>
    /// <typeparam name="T">The type of the result.</typeparam>
    /// <param name="errorCode">The error code indicating the reason for the empty result.</param>
    /// <param name="callerMemberName">Optional. The name of the calling member.</param>
    /// <param name="sourceFilePath">Optional. The path of the source file.</param>
    /// <returns>An empty result of type T.</returns>
    T EmptyResult<T>(string errorCode, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string sourceFilePath = null);
}
