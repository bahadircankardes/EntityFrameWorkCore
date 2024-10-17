using System;
using _3_CodeFirst.Models;
using _3_CodeFirst.Models.Concrete;
using Microsoft.EntityFrameworkCore;

namespace _3_CodeFirst.Contexts
{
	public class TicariPaketContext : DbContext
	{
		public DbSet<Kategori> Kategoriler { get; set; }

        public DbSet<Urun> Urunler { get; set; }

        public DbSet<Personel> Personeller { get; set; }

        public DbSet<Adres> Adresler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=41264126;Host=127.0.0.1;Port=5432;Database=TicariPaket");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Entity'lerimizi burada konfigure edebiliriz.

            //modelBuilder.Entity<Kategori>().HasKey(k=> k.Id);
            modelBuilder.Entity<Kategori>().Property(p => p.KategoriAdi).HasMaxLength(50);
            modelBuilder.Entity<Kategori>().HasIndex(p => p.KategoriAdi).IsUnique();
            modelBuilder.Entity<Kategori>().Property(p => p.Aciklama).HasMaxLength(500);

            modelBuilder.Entity<Kategori>()
                            .HasMany(p => p.Urunler) // Kategori tablosundaki Colection'dur.
                            .WithOne(u=> u.Kategori)//Urun tablosundaki Navigation propety^dir
                            .HasForeignKey(p=>p.KategoriId)//Urun Talosundaki KategoriId
                            .OnDelete(DeleteBehavior.NoAction);//Kayit silindiğinde bir sey yapma demek. Yani Silme

            //modelBuilder.Entity<Urun>().HasKey(p => p.Id);
            modelBuilder.Entity<Urun>().Property(p => p.Urunadi).HasMaxLength(50);
            modelBuilder.Entity<Urun>().HasOne(p=> p.Kategori)
                        .WithMany(k=> k.Urunler)
                        .HasForeignKey(p => p.KategoriId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Personel>().Property(p => p.Adi).HasMaxLength(50);
            modelBuilder.Entity<Personel>().Property(p => p.Soyadi).HasMaxLength(50);
            modelBuilder.Entity<Personel>().Property(p => p.Email).HasMaxLength(50);
            modelBuilder.Entity<Personel>().Property(p => p.TcNo).HasMaxLength(11);
            modelBuilder.Entity<Personel>().Property(p => p.Gsm).HasMaxLength(15);

            modelBuilder.Entity<Personel>().HasIndex(p => p.TcNo).IsUnique();


        }
    }
}

