using System.Linq.Expressions;
using Domain;
using DomainServices;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

internal class BaseRepository<TEntity>(IApplicationDbContext context) : IRepository<TEntity> where TEntity : BaseEntity
{
    private DbSet<TEntity> _entities = context.Set<TEntity>();
    private bool disposed = false;
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
            if (disposing)
                if (_entities != null) _entities = null;
        disposed = true;
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    public virtual async Task InsertAsync(TEntity entity)
    {
        entity.IsDeleted = false;
        _entities.Add(entity);
    }


    public virtual async Task InsertAsync(IList<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public virtual async Task UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task UpdateAsync(IList<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public virtual async Task UpdateAsync(TEntity entity, string[] affectedProperties)
    {
        throw new NotImplementedException();
    }

    public virtual async Task DeleteAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task DeleteAsync(IList<TEntity> entities)
    {
        throw new NotImplementedException();
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<IList<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includes)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<IQueryable<TEntity>> GetAllForQueryAsync()
    {
        throw new NotImplementedException();
    }

    public virtual async Task<TEntity> GetAsync(string id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<TEntity> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<IList<TEntity>> GetAsync<TType>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TType>> select = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null) where TType : class
    {
        throw new NotImplementedException();
    }

    public virtual async Task<IList<TType>> GetWithSoftDeleteAsync<TType>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TType>> select = null) where TType : class
    {
        throw new NotImplementedException();
    }

    public virtual async Task<bool> ActiveRecordExistsAsync(Expression<Func<TEntity, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<bool> DuplicateExistsAsync(Expression<Func<TEntity, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<FrameworkResult> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public virtual async Task<FrameworkResult> SaveChangesWithHardDeleteAsync()
    {
        throw new NotImplementedException();
    }
}