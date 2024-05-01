namespace DomainValidation.Validation;

public class ValidationResult
{
    private IEnumerable<ValidationError> Errors { get; set; }
    public string Message { get; set; }
    private bool IsValid => !Errors.Any();

    public ValidationResult()
    {
        Errors = Array.Empty<ValidationError>();
    }
    private void SetErrors(IReadOnlyList<ValidationError> errors)
    {
        Errors = errors;

        if (!IsValid)
            Message = errors[0].ErrorCode;
    }
    public void Add(params ValidationResult[] validationResults)
    {
        var list = new List<ValidationError>(Errors);
        foreach (var validation in validationResults)
            list.AddRange(validation.Errors);

        SetErrors(list);
    }
    public void Add(ValidationError error)
    {
        var list = new List<ValidationError>(Errors) { error };
        SetErrors(list);
    }
    public void Remove(ValidationError error)
    {
        var list = new List<ValidationError>(Errors);
        list.Remove(error);
        SetErrors(list);
    }
}