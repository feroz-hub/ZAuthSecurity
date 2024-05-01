using System.Linq.Expressions;
using Domain;

namespace DomainServices;

/// <summary>
/// Represents a generic repository interface for CRUD operations on entities.
/// </summary>
/// <typeparam name="TEntity">The type of entity.</typeparam>
public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
{
   /// <summary>
   /// Inserts a single entity asynchronously into the repository.
   /// </summary>
   /// <param name="entity">The entity to be inserted.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task InsertAsync(TEntity entity);

   /// <summary>
   /// Inserts a list of entities asynchronously into the repository.
   /// </summary>
   /// <param name="entities">The list of entities to be inserted.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task InsertAsync(IList<TEntity> entities);

   /// <summary>
   /// Updates a single entity asynchronously in the repository.
   /// </summary>
   /// <param name="entity">The entity to be updated.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task UpdateAsync(TEntity entity);

   /// <summary>
   /// Updates a list of entities asynchronously in the repository.
   /// </summary>
   /// <param name="entities">The list of entities to be updated.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task UpdateAsync(IList<TEntity> entities);

   /// <summary>
   /// Updates specific properties of an entity asynchronously in the repository.
   /// </summary>
   /// <param name="entity">The entity to be updated.</param>
   /// <param name="affectedProperties">The properties of the entity to be updated.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task UpdateAsync(TEntity entity, string[] affectedProperties);

   /// <summary>
   /// Deletes a single entity asynchronously from the repository.
   /// </summary>
   /// <param name="entity">The entity to be deleted.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task DeleteAsync(TEntity entity);

   /// <summary>
   /// Deletes a list of entities asynchronously from the repository.
   /// </summary>
   /// <param name="entities">The list of entities to be deleted.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task DeleteAsync(IList<TEntity> entities);

   /// <summary>
   /// Deletes an entity asynchronously by its ID from the repository.
   /// </summary>
   /// <param name="id">The ID of the entity to be deleted.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task DeleteAsync(Guid id);

   /// <summary>
   /// Retrieves all entities asynchronously from the repository.
   /// </summary>
   /// <param name="includes">Navigation properties to be included.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task<IList<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includes);

   /// <summary>
   /// Retrieves all entities for querying asynchronously from the repository.
   /// </summary>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task<IQueryable<TEntity>> GetAllForQueryAsync();

   /// <summary>
   /// Retrieves an entity asynchronously by its string ID from the repository.
   /// </summary>
   /// <param name="id">The string ID of the entity to be retrieved.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task<TEntity> GetAsync(string id);

   /// <summary>
   /// Retrieves an entity asynchronously by its GUID ID from the repository.
   /// </summary>
   /// <param name="id">The GUID ID of the entity to be retrieved.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task<TEntity> GetAsync(Guid id);

   /// <summary>
   /// Retrieves entities asynchronously based on a filter and optional includes from the repository.
   /// </summary>
   /// <param name="filter">The filter expression to apply.</param>
   /// <param name="includes">Navigation properties to be included.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter,
      params Expression<Func<TEntity, object>>[] includes);

   /// <summary>
   /// Retrieves entities asynchronously based on a filter, selection, and ordering from the repository.
   /// </summary>
   /// <typeparam name="TType">The type of the selection.</typeparam>
   /// <param name="filter">The filter expression to apply.</param>
   /// <param name="select">The selection expression.</param>
   /// <param name="orderBy">The ordering function.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task<IList<TEntity>> GetAsync<TType>(Expression<Func<TEntity, bool>> filter,
      Expression<Func<TEntity, TType>> select = null,
      Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null) where TType : class;

   /// <summary>
   /// Retrieves entities with soft delete asynchronously based on a filter and selection from the repository.
   /// </summary>
   /// <typeparam name="TType">The type of the selection.</typeparam>
   /// <param name="filter">The filter expression to apply.</param>
   /// <param name="select">The selection expression.</param>
   /// <returns>A task representing the asynchronous operation.</returns>
   Task<IList<TType>> GetWithSoftDeleteAsync<TType>(Expression<Func<TEntity, bool>> filter,
      Expression<Func<TEntity, TType>> select = null) where TType : class;

   /// <summary>
   /// Checks if an entity satisfying the specified filter exists asynchronously in the repository.
   /// </summary>
   /// <param name="filter">The filter expression to apply.</param>
   /// <returns>A task representing the asynchronous operation, returning true if the entity exists; otherwise, false.</returns>
   Task<bool> ActiveRecordExistsAsync(Expression<Func<TEntity, bool>> filter);

   /// <summary>
   /// Checks if a duplicate entity satisfying the specified filter exists asynchronously in the repository.
   /// </summary>
   /// <param name="filter">The filter expression to apply.</param>
   /// <returns>A task representing the asynchronous operation, returning true if a duplicate entity exists; otherwise, false.</returns>
   Task<bool> DuplicateExistsAsync(Expression<Func<TEntity, bool>> filter);

   /// <summary>
   /// Saves changes asynchronously in the repository.
   /// </summary>
   /// <returns>A task representing the asynchronous operation, containing the result of the operation.</returns>
   Task<FrameworkResult> SaveChangesAsync();

   /// <summary>
   /// Saves changes with hard delete asynchronously in the repository.
   /// </summary>
   /// <returns>A task representing the asynchronous operation, containing the result of the operation.</returns>
   Task<FrameworkResult> SaveChangesWithHardDeleteAsync();

}