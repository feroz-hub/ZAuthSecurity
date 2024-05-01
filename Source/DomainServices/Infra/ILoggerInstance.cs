using Domain;

namespace DomainServices.Infra;

public interface ILoggerInstance
{
    void InitiateLoggerInstance(List<LogConfig> logConfig);
    void InitiateLoggerInstance(LogConfig logConfig);
    ILoggerService GetLoggerInstance(string instanceName);
}