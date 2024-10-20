﻿using System;
using System.Linq.Expressions;

namespace _9_GenericRepository.Abstract
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

		List<T> GetAll();



	}
}

