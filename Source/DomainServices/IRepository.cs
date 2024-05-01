using System.Linq.Expressions;
using Domain;

namespace DomainServices;
/// <summary>
/// Represents a generic repository interface for CRUD operations on entities.
/// </summary>
/// <typeparam name="TEntity">The type of entity.</typeparam>
public interface IRepository<TEntity>:IDisposable where TEntity :BaseEntity
{
    Task InsertAsync(TEntity entity);
    Task InsertAsync(IList<TEntity> entities);
    Task UpdateAsync(TEntity entity);
    Task UpdateAsync(IList<TEntity> entities);
    Task UpdateAsync(TEntity entity, string[] affectedProperties);
    Task DeleteAsync(TEntity entity);
    Task DeleteAsync(IList<TEntity> entities);
    Task DeleteAsync(Guid id);
    Task<IList<TEntity>> GetAllAsync(params Expression<Func<TEntity,object>>[] includes);
    Task<IQueryable<TEntity>> GetAllForQueryAsync();
    Task<TEntity> GetAsync(string id);
    Task<TEntity> GetAsync(Guid id);
    Task<IList<TEntity>>GetAsync(Expression<Func<TEntity,bool>> filter,params Expression<Func<TEntity,object>>[] includes);

    Task<IList<TEntity>> GetAsync<TType>(Expression<Func<TEntity, bool>> filter,
        Expression<Func<TEntity, TType>> select = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null) where TType : class;
    Task<IList<TType>> GetWithSoftDeleteAsync<TType>(Expression<Func<TEntity,bool>> filter,Expression<Func<TEntity,TType>> select = null)where TType : class;
    Task<bool> ActiveRecordExistsAsync(Expression<Func<TEntity, bool>> filter);
    Task<bool> DuplicateExistsAsync(Expression<Func<TEntity,bool>> filter);
    Task<FrameworkResult> SaveChangesAsync();
    Task<FrameworkResult> SaveChangesWithHardDeleteAsync();
}