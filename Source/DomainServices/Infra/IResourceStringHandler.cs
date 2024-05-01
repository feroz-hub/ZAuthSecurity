namespace DomainServices.Infra;

public interface IResourceStringHandler
{
    string GetResourceString(string id,bool skipError=false);
    string GetResourceKeyByValue(string value);
}