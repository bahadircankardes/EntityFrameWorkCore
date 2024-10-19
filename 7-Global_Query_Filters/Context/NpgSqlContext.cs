using System;
using System.Reflection;
using _7_Global_Query_Filters.Entiities.Abstract;
using _7_Global_Query_Filters.Entiities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace _7_Global_Query_Filters.Context
{
	public class NpgSqlContext:DbContext
	{
        public DbSet<Person> Persons { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override async void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=41264126;Host=127.0.0.1;Port=5432;Database=GlobalFilterinDb");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Person>().HasQueryFilter(p => p.IsActive);
            //modelBuilder.Entity<Person>().HasQueryFilter(p => p.Orders.Count > 0);
        }

        public override int SaveChanges()
        {
            var deleted = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Deleted)
                        .Select(t => t.Entity)
                        .ToList();
            foreach (var item in deleted)
            {
                var silinen = item as BaseEntity;
                silinen.IsDeleted = true;
                this.Entry<BaseEntity>(silinen).State = EntityState.Modified;
            }

            var added = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Added)
                        .Select(t => t.Entity)
                        .ToList();

            foreach (var item in added)
            {
                var eklenen = item as Person;
                eklenen.Orders.Add(new Order{Description = "Test", Price=10 });
            }

            return base.SaveChanges();
        }
    }
}

