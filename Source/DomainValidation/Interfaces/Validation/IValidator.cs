using DomainValidation.Validation;

namespace DomainValidation.Interfaces.Validation
{
    /// <summary>
    /// Represents a validator interface for validating entities.
    /// </summary>
    /// <typeparam name="TEntity">The type of entity to be validated.</typeparam>
    public interface IValidator<in TEntity>
    {
        /// <summary>
        /// Validates the specified entity.
        /// </summary>
        /// <param name="entity">The entity to be validated.</param>
        /// <returns>A ValidationResult object containing the validation results.</returns>
        ValidationResult Validate(TEntity entity);
    }
}