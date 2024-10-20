using System;
using System.Linq.Expressions;
using GenericRepository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Concrete
{
    public class Repository<T, TContext> : IRepository<T>
        where T : class
        where TContext : DbContext, new()
    {
        readonly TContext context;

        public Repository()
        {
            context = new TContext();
        }

        public virtual int Delete(T entity)
        {
            //Buradaki T parametresi Hangi Entity geldiyse onu temsil eder.
            context.Set <T>().Remove(entity);
            return context.SaveChanges();
        }

        public virtual int Delete(int id)
        {
            var entity = context.Set<T>().Find(id);
            context.Set<T>().Remove(entity);
            return context.SaveChanges();
        }

        public virtual int Delete(string id)
        {
            var entity = context.Set<T>().Find(id);
            context.Set<T>().Remove(entity);
            return context.SaveChanges();
        }

        public virtual List<T> GetAll(Expression<Func<T, bool>> predicate=null)
        {
            //if (predicate == null)
            //{
            //    return context.Set<T>().ToList();
            //}
            //else
            //{
            //    return context.Set<T>().Where(predicate).ToList();
            //}

            return predicate == null ? context.Set<T>().ToList() : context.Set<T>().Where(predicate).ToList();

        }

        public virtual IQueryable<T> GetAllInclude(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> query;
            if (predicate == null)
            {
                query = context.Set<T>().Where(predicate);
            }
            else
            {
                query = context.Set<T>();
            }
            //contex.Set<T>().Include(p=>p.Category)
            var result = include.Aggregate(query, (abc, xyz) => abc.Include(xyz));
            return result;
        }

        public virtual T? GetBy(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().FirstOrDefault(predicate);
        }

        public virtual T GetById(short id)
        {
            return context.Set<T>().Find(id);
        }

        public virtual T GetById(string id)
        {
            return context.Set<T>().Find(id);
        }

        public virtual int Insert(T entity)
        {
            context.Set<T>().Add(entity);
            return context.SaveChanges();
        }

        public virtual int Update(T entity)
        {
            context.Set<T>().Update(entity);
            return context.SaveChanges();
        }
    }
}

