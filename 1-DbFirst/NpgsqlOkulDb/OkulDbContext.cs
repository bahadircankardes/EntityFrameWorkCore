using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _1_DbFirst.NpgsqlOkulDb;

public partial class OkulDbContext : DbContext
{
    public OkulDbContext()
    {
    }

    public OkulDbContext(DbContextOptions<OkulDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branslar> Branslars { get; set; }

    public virtual DbSet<DersPlanlari> DersPlanlaris { get; set; }

    public virtual DbSet<Ogrenciler> Ogrencilers { get; set; }

    public virtual DbSet<Ogretmenler> Ogretmenlers { get; set; }

    public virtual DbSet<Siniflar> Siniflars { get; set; }

    public virtual DbSet<Yoklamalar> Yoklamalars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("User ID=postgres;Password=41264126;Host=127.0.0.1;Port=5432;Database=OkulDb");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branslar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Branslar_pkey");

            entity.ToTable("Branslar");

            entity.Property(e => e.BransAdi).HasColumnType("character varying");
        });

        modelBuilder.Entity<DersPlanlari>(entity =>
        {
            entity.HasKey(e => e.PlanId).HasName("DersPlanlari_pkey");

            entity.ToTable("DersPlanlari");

            entity.HasIndex(e => new { e.OgretmenId, e.Gun, e.Saat }, "FK-DersPlanlari_Ogretmenler").IsUnique();

            entity.HasIndex(e => new { e.Gun, e.Saat, e.SinifId }, "IX_DersPlanlari").IsUnique();

            entity.Property(e => e.OgretmenId).HasColumnName("OgretmenID");

            entity.HasOne(d => d.Ogretmen).WithMany(p => p.DersPlanlaris)
                .HasForeignKey(d => d.OgretmenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ogretmen");

            entity.HasOne(d => d.Sinif).WithMany(p => p.DersPlanlaris)
                .HasForeignKey(d => d.SinifId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sıniflar");
        });

        modelBuilder.Entity<Ogrenciler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Ogrenciler_pkey");

            entity.ToTable("Ogrenciler");

            entity.Property(e => e.Ad).HasColumnType("character varying");
            entity.Property(e => e.Email).HasColumnType("character varying");
            entity.Property(e => e.Gsm).HasColumnType("character varying");
            entity.Property(e => e.Soyadi).HasColumnType("character varying");
            entity.Property(e => e.Tcno)
                .HasColumnType("character varying")
                .HasColumnName("TCNO");

            entity.HasOne(d => d.Sinif).WithMany(p => p.Ogrencilers)
                .HasForeignKey(d => d.SinifId)
                .HasConstraintName("FK_Siniflar");
        });

        modelBuilder.Entity<Ogretmenler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Ogretmenler_pkey");

            entity.ToTable("Ogretmenler");

            entity.Property(e => e.Ad).HasColumnType("character varying");
            entity.Property(e => e.BransId).HasColumnName("BransID");
            entity.Property(e => e.Email).HasColumnType("character varying");
            entity.Property(e => e.Soyad).HasColumnType("character varying");
            entity.Property(e => e.TcNo).HasColumnType("character varying");

            entity.HasOne(d => d.Brans).WithMany(p => p.Ogretmenlers)
                .HasForeignKey(d => d.BransId)
                .HasConstraintName("FK_Branslar");
        });

        modelBuilder.Entity<Siniflar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Siniflar_pkey");

            entity.ToTable("Siniflar");

            entity.Property(e => e.SinifAdi).HasColumnType("character varying");
        });

        modelBuilder.Entity<Yoklamalar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Yoklamalar_pkey");

            entity.ToTable("Yoklamalar");

            entity.HasIndex(e => new { e.OgrenciId, e.Tarih, e.PlanId }, "IX_Ogrenci").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PlanId).HasColumnName("PlanID");

            entity.HasOne(d => d.Ogrenci).WithMany(p => p.Yoklamalars)
                .HasForeignKey(d => d.OgrenciId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ogrenciler");

            entity.HasOne(d => d.Plan).WithMany(p => p.Yoklamalars)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DersPlanlari");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
