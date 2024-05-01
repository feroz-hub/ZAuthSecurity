using System.Runtime.CompilerServices;
using Domain;


namespace DomainServices.Infra;

/// <summary>
/// Interface defining operations for logging.
/// </summary>
public interface ILoggerService
{
    /// <summary>
    /// Sets the user name for logging purposes.
    /// </summary>
    /// <param name="userName">The user name to set.</param>
    void SetLoggerUserName(string userName);

    /// <summary>
    /// Writes a log message with the specified logging option and message.
    /// </summary>
    /// <param name="loggingOption">The logging option.</param>
    /// <param name="message">The log message.</param>
    /// <param name="propertyValues">The values of additional properties to include in the log message.</param>
    void WriteTo(Log loggingOption, string message, params object[] propertyValues);

    /// <summary>
    /// Writes a log message with the specified logging option, exception, and message.
    /// </summary>
    /// <param name="loggingOptions">The logging option.</param>
    /// <param name="exception">The exception to log.</param>
    /// <param name="message">The log message.</param>
    /// <param name="propertyValues">The values of additional properties to include in the log message.</param>
    void WriteTo(Log loggingOptions, Exception exception, string message, params object[] propertyValues);

    /// <summary>
    /// Writes a log message with the specified logging option, message, and additional caller information.
    /// </summary>
    /// <param name="loggingOptions">The logging option.</param>
    /// <param name="message">The log message.</param>
    /// <param name="propertyValues">The values of additional properties to include in the log message.</param>
    /// <param name="callerMemberName">The name of the calling member.</param>
    /// <param name="sourceFilePath">The path of the source file.</param>
    void WriteToWithCaller(Log loggingOptions, string message, object[] propertyValues = null, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string sourceFilePath = null);

    /// <summary>
    /// Writes a log message with the specified logging option, exception, message, and additional caller information.
    /// </summary>
    /// <param name="loggingOption">The logging option.</param>
    /// <param name="exception">The exception to log.</param>
    /// <param name="message">The log message.</param>
    /// <param name="propertyValues">The values of additional properties to include in the log message.</param>
    /// <param name="callerMemberName">The name of the calling member.</param>
    /// <param name="sourceFilePath">The path of the source file.</param>
    void WriteToWithCaller(Log loggingOption, Exception exception, string message, object[] propertyValues = null, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string sourceFilePath = null);
}
