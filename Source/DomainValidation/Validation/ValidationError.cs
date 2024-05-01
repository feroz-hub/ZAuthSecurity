namespace DomainValidation.Validation;

public class ValidationError(string name,string errorCode,string errorMessage)
{
    public ValidationError():this(string.Empty,string.Empty,string.Empty)
    { }
    public string Name => name;
    public string ErrorMessage =>errorMessage;
    public string ErrorCode=>errorCode;
}