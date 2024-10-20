using System;
using _9_GenericRepository.Abstract;
using _9_GenericRepository.NpgsqlNorthwind;

namespace _9_GenericRepository.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        readonly NorthwindContext context;

        public Repository()
        {
            context = new NorthwindContext();
        }

        public int Delete(T entity)
        {
            //Buradaki T parametresi Hangi Entity geldiyse onu temsil eder.
            context.Set <T>().Remove(entity);
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            var entity = context.Set<T>().Find(id);
            context.Set<T>().Remove(entity);
            return context.SaveChanges();
        }

        public int Delete(string id)
        {
            var entity = context.Set<T>().Find(id);
            context.Set<T>().Remove(entity);
            return context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public T GetById(string id)
        {
            return context.Set<T>().Find(id);
        }

        public int Insert(T entity)
        {
            context.Set<T>().Add(entity);
            return context.SaveChanges();
        }

        public int Update(T entity)
        {
            context.Set<T>().Update(entity);
            return context.SaveChanges();
        }
    }
}

