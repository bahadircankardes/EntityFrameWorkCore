using System;
using _4_ManyToMany.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace _4_ManyToMany.Contexts
{
	public class MySqlContext : DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Urun> Urunler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=ManyToMany;Uid=root;Pwd=41264126", new MySqlServerVersion(new Version(7, 0, 0)));
        }
    }
}

