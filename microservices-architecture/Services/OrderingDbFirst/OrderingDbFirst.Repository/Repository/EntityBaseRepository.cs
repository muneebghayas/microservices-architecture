using System;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CertificatePRJ.Repository.IRepository;

namespace CertificatePRJ.Repository.Repository
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class
    {
  //      private readonly ApplicationDbContext _dbContext;
  //      private DbSet<T> _dbSet;
  //      public EntityBaseRepository(ApplicationDbContext dbContext)
  //      {
  //          _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
  //          _dbSet = _dbContext.Set<T>();
  //      }

  //      public virtual async Task<List<T>> GetAll()
  //      {
  //          return await _dbContext.Set<T>().ToListAsync();
  //      }
  //      public virtual async Task<List<T>> GetAll(Expression<Func<T, bool>> predicate)
  //      {
  //          return await _dbContext.Set<T>().Where(predicate).ToListAsync();
  //      }
  //      public virtual async Task<int> Count()
  //      {
  //          return await _dbContext.Set<T>().CountAsync();
  //      }
		//public virtual async Task<int> Count(Expression<Func<T, bool>> predicate)
		//{
		//	return await _dbContext.Set<T>().Where(predicate).CountAsync();
		//}

		//public virtual async Task<List<T>> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
  //      {
  //          IQueryable<T> query = _dbContext.Set<T>();
  //          foreach (var includeProperty in includeProperties)
  //          {
  //              query = query.Include(includeProperty);
  //          }

  //          return await query.ToListAsync();
  //      }

  //      public virtual async Task<T> GetSingle(object id)
  //      {
  //          return await _dbContext.Set<T>().FindAsync(id);
  //      }

  //      public virtual async Task<T> GetSingle(Expression<Func<T, bool>> predicate)
  //      {
  //          return await _dbContext.Set<T>().FirstOrDefaultAsync(predicate);
  //      }

  //      public virtual async Task<T> GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
  //      {
  //          IQueryable<T> query = _dbContext.Set<T>();
  //          foreach (var includeProperty in includeProperties)
  //          {
  //              query = query.Include(includeProperty);
  //          }

  //          return await query.Where(predicate).FirstOrDefaultAsync();
  //      }

  //      public virtual async Task<List<T>> FindBy(Expression<Func<T, bool>> predicate)
  //      {
  //          return await _dbContext.Set<T>().Where(predicate).ToListAsync();
  //      }


  //      public virtual async Task<T> Add(T entity)
  //      {
  //          _dbContext.Add(entity);
  //          await _dbContext.SaveChangesAsync();
  //          return entity;
  //      }

  //      public virtual async Task<List<T>> AddList(List<T> entity)
  //      {
  //          try
  //          {
  //              _dbContext.AddRange(entity);
  //              await _dbContext.SaveChangesAsync();
  //              return entity;
  //          }
  //          catch (Exception ex)
  //          {
  //              string exception = ex.Message;
  //              throw;
  //          }
           
  //      }

  //      public virtual async Task<T> Update(T entity)
  //      {
  //          _dbContext.Update(entity);
  //          await _dbContext.SaveChangesAsync();
  //          return entity;
  //      }

  //      public virtual async Task<List<T>> UpdateList(List<T> entity)
  //      {
  //          try
  //          {
  //              _dbContext.UpdateRange(entity);
  //              await _dbContext.SaveChangesAsync();
  //              return entity;
  //          }
  //          catch (Exception ex)
  //          {
  //              string exception = ex.Message;
  //              throw;
  //          }

  //      }

  //      public virtual async Task<bool> Delete(T entity)
  //      {
  //          _dbContext.Remove(entity);
  //          return await _dbContext.SaveChangesAsync() > 0;
  //      }

  //      public virtual async Task<bool> DeleteWhere(Expression<Func<T, bool>> predicate)
  //      {
  //          IEnumerable<T> entities = _dbContext.Set<T>().Where(predicate);
  //          foreach (var entity in entities)
  //          {
  //              _dbContext.Remove(entity);
  //          }
  //          return await _dbContext.SaveChangesAsync() > 0;
  //      }

  //      public virtual async Task Commit()
  //      {
  //          await _dbContext.SaveChangesAsync();
  //      }
  //      public IQueryable<T> AsQueryable()
  //      {
  //          return _dbSet.AsQueryable();
  //      }
  //      public IQueryable<T> AsQueryable(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
  //      {
  //          IQueryable<T> query = _dbContext.Set<T>().Where(predicate);
  //          foreach (var includeProperty in includeProperties)
  //          {
  //              query = query.Include(includeProperty);
  //          }

  //          return query;
  //      }
    }
}
