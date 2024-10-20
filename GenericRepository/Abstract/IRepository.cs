using System;
using System.Linq.Expressions;

namespace GenericRepository.Abstract
{
	public interface IRepository<T> where T : class
	{
		int Insert(T entity);

		int Update(T entity);

		int Delete(T entity);

		int Delete(int id);

		int Delete(string id);

		T? GetById(short id);

		T? GetById(string id);

        T? GetBy(Expression<Func<T, bool>> predicate);

        List<T> ?GetAll(Expression<Func<T, bool>> predicate=null);

		IQueryable<T> GetAllInclude(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] include);



	}
}

