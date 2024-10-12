using _3_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace _3_CodeFirst.Contexts
{
    public class MySqlContext :DbContext
	{
        public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Urun> Urunler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=TicariPaket;Uid=root;Pwd=41264126", new MySqlServerVersion(new Version(7, 0, 0)));
        }
    }
}

