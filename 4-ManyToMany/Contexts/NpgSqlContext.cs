using System;
using _4_ManyToMany.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace _4_ManyToMany.Contexts
{
	public class NpgSqlContext : DbContext
	{
		public DbSet<Kategori> Kategoriler { get; set; }

		public DbSet<Urun> Urunler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=41264126;Host=127.0.0.1;Port=5432;Database=ManyToMany");
        }

    }
}

