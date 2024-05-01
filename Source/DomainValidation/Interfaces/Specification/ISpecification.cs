namespace DomainValidation.Interfaces.Specification;

/// <summary>
/// Represents a specification interface for validating entities.
/// </summary>
/// <typeparam name="T">The type of entity to be validated.</typeparam>
public interface ISpecification<in T>
{
    /// <summary>
    /// Checks if the specification is satisfied by the given entity.
    /// </summary>
    /// <param name="entity">The entity to be validated.</param>
    /// <returns>True if the specification is satisfied, otherwise false.</returns>
    bool IsSatisfiedBy(T entity);
}