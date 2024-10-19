using System;
using System.Reflection;
using _6_MoviesEntities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace _6_MoviesEntities.Contexts
{
	public class MovieDbContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Week> Weeks { get; set; }

        public DbSet<Seans> Seans { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Saloon> Salons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=MoviesEFCORE;uid=root;pwd=41264126", Microsoft.EntityFrameworkCore.ServerVersion.Parse("7.0.0-mysql"));
        }

    



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }








    }
}

