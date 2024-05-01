using DomainValidation.Interfaces.Specification;
using DomainValidation.Interfaces.Validation;

namespace DomainValidation.Validation;


public class Rule<TEntity>(ISpecification<TEntity> spec, string errorCode, string errorMessage)
    : IRule<TEntity>
{
    private readonly ISpecification<TEntity> _spec = spec ?? throw new ArgumentNullException(nameof(spec));

    public Rule(ISpecification<TEntity> spec,string errorCode ):this(spec,errorCode,string.Empty){}

    string IRule<TEntity>.ErrorCode { get; } = errorCode ?? throw new ArgumentNullException(nameof(errorCode));

    string IRule<TEntity>.ErrorMessage { get; } = errorMessage ?? throw new ArgumentNullException(nameof(errorMessage));

    bool IRule<TEntity>.Validate(TEntity entity) => _spec.IsSatisfiedBy(entity);
}

