namespace DomainValidation.Interfaces.Validation;

/// <summary>
/// Represents a validation rule interface for validating entities.
/// </summary>
/// <typeparam name="TEntity">The type of entity to be validated.</typeparam>
public interface IRule<in TEntity>
{
    /// <summary>
    /// Gets the error code associated with the validation rule.
    /// </summary>
    string ErrorCode { get; }

    /// <summary>
    /// Gets the error message associated with the validation rule.
    /// </summary>
    string ErrorMessage { get; }

    /// <summary>
    /// Validates the specified entity according to the rule.
    /// </summary>
    /// <param name="entity">The entity to be validated.</param>
    /// <returns>True if the entity passes the validation rule, otherwise false.</returns>
    bool Validate(TEntity entity);
}