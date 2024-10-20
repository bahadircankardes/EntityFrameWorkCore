using System;
using System.Linq.Expressions;
using _10_GenericLibKullanimi.Manager.Abstract;
using _10_GenericLibKullanimi.NpgsqlNorthwind;
using GenericRepository.Concrete;
using Microsoft.EntityFrameworkCore;

namespace _10_GenericLibKullanimi.Manager.Concrete
{
    public class CustomerManager<T, TContext> : Repository<T, TContext>, ICustomerManager<T>
        where T : class
        where TContext : DbContext, new()
    {
        public bool CheckForCountry(T entity)
        {
            var customer = entity as Customer;

            if (customer.Country == "Germany")
            {
                return true;

            }
            else
            {
                return false;

            }


        }

        public override int Insert(T entity)
        {
            if (!CheckForCountry(entity))
            {
                return base.Insert(entity);
            }

            throw new Exception("Almanya'da Musteri acilmasina izin verilmiyor"); ;
        }
    }
}

