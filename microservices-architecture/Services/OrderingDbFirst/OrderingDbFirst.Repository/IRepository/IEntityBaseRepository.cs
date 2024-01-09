using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CertificatePRJ.Repository.IRepository
{
    public interface IEntityBaseRepository<T> where T : class
    {
  //      Task<List<T>> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
  //      Task<List<T>> GetAll();
  //      Task<List<T>> GetAll(Expression<Func<T, bool>> predicate);
  //      Task<int> Count();
  //      Task<int> Count(Expression<Func<T, bool>> predicate);
		//Task<T> GetSingle(object id);
  //      Task<T> GetSingle(Expression<Func<T, bool>> predicate);
  //      Task<T> GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
  //      Task<List<T>> FindBy(Expression<Func<T, bool>> predicate);
  //      Task<T> Add(T entity);
  //      Task<List<T>> AddList(List<T> entity);
  //      Task<T> Update(T entity);
  //      Task<List<T>> UpdateList(List<T> entity);
  //      Task<bool> Delete(T entity);
  //      Task<bool> DeleteWhere(Expression<Func<T, bool>> predicate);
  //      Task Commit();
  //      IQueryable<T> AsQueryable();
  //      IQueryable<T> AsQueryable(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
    }
}
