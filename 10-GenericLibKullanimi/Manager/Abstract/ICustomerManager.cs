using System;
using _10_GenericLibKullanimi.NpgsqlNorthwind;
using GenericRepository.Abstract;

namespace _10_GenericLibKullanimi.Manager.Abstract
{
	public interface ICustomerManager<T> : IRepository<T> where T : class
	{
		bool CheckForCountry(T entity);
	}
}

