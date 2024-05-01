using System.Runtime.CompilerServices;
using Domain;


namespace DomainServices.Infra;

public interface ILoggerService
{
    void SetLoggerUserName(string userName);
    void WriteTo(Log loggingOption,string message, params object[] propertyValues);
    void WriteTo(Log loggingOptions,Exception exception,string message, params object[] propertyValues);

    void WriteToWithCaller(Log loggingOptions, string message, object[] propertyValues = null, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string sourceFilePath = null);
    
    void WriteToWithCaller(Log loggingOption, Exception exception, string message, object[] propertyValues = null, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string sourceFilePath = null);

}

