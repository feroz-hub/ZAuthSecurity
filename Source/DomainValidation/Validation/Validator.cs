using DomainValidation.Interfaces.Validation;

namespace DomainValidation.Validation;

public class Validator<TEntity> : IValidator<TEntity>
{
    private readonly Dictionary<string, IRule<TEntity>> rules;
    
    protected Validator()=>rules = new Dictionary<string,IRule<TEntity>>();
    
    protected virtual void Add(string name,IRule<TEntity> rule)=>rules.Add(name,rule);
    
    protected IRule<TEntity> GetRule(string name)=>rules[name];

    protected virtual void Remove(string name) => rules.Remove(name);
    
    public ValidationResult Validate(TEntity entity)
    {
        var validation = new ValidationResult();
        foreach (var rule in rules.Where(rule => !rule.Value.Validate(entity)))
        {
            validation.Add(new ValidationError(rule.Key, rule.Value.ErrorCode, rule.Value.ErrorMessage));
            return validation;
        }
        return validation;
    }

    public ValidationResult ValidateAll(TEntity entity)
    {
        var validation = new ValidationResult();
        foreach (var rule in rules.Where(rule => !rule.Value.Validate(entity)))
        {
            validation.Add(new ValidationError(rule.Key,rule.Value.ErrorCode,rule.Value.ErrorMessage));
            if (entity==null)
                break;
        }
        return validation;
    }
    
}