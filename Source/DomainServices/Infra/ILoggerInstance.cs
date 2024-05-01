using Domain;

namespace DomainServices.Infra;

/// <summary>
/// Interface defining operations for managing logger instances.
/// </summary>
public interface ILoggerInstance
{
    /// <summary>
    /// Initializes a logger instance with multiple log configurations.
    /// </summary>
    /// <param name="logConfig">The list of log configurations.</param>
    void InitiateLoggerInstance(List<LogConfig> logConfig);

    /// <summary>
    /// Initializes a logger instance with a single log configuration.
    /// </summary>
    /// <param name="logConfig">The log configuration.</param>
    void InitiateLoggerInstance(LogConfig logConfig);

    /// <summary>
    /// Retrieves a logger service instance based on the instance name.
    /// </summary>
    /// <param name="instanceName">The name of the logger instance.</param>
    /// <returns>The logger service instance.</returns>
    ILoggerService GetLoggerInstance(string instanceName);
}
