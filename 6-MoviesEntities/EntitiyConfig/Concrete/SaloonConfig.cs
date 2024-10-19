using System;
using _6_MoviesEntities.Entities.Concrete;
using _6_MoviesEntities.EntitiyConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _6_MoviesEntities.EntitiyConfig.Concrete
{
	public class SaloonConfig:BaseConfig<Saloon>
	{
        public override void Configure(EntityTypeBuilder<Saloon> builder)
        {
            base.Configure(builder);
            builder.Property(p=> p.SalonName).HasMaxLength(50);
            builder.HasMany(p => p.Sessions).WithOne(p => p.Saloon)
                .HasForeignKey(p => p.SaloonId)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);

            builder.HasData(new Saloon { Id = 3, SalonName = "C Salonu", Kapasite = 50 });
            builder.HasData(new Saloon { Id = 2, SalonName = "B Salonu", Kapasite = 150 });
            builder.HasData(new Saloon { Id = 1, SalonName = "A Salonu", Kapasite = 50 });
            builder.HasData(new Saloon { Id = 4, SalonName = "D Salonu", Kapasite = 50 });

            #region Restrict
            //Esas tablodan herhangi bir veri silinmeye çalışıldığında 
            //o veriye karşılık dependent table'da ilişkisel veri/ler varsa eğer 
            //bu sefer bu silme işlemini engellemesini sağlar.
            #endregion
            #region Cascade
            //Esas tablodan silinen veriyle karşı/bağımlı tabloda bulunan ilişkili verilerin silinmesini sağlar.
            #endregion

            #region SetNull
            //Esas tablodan silinen veriyle karşı/bağımlı tabloda bulunan ilişkili verilere 
            //null değerin atanmasını sağlar.

            //One to One senaryolarda eğer ki Foreign key ve Primary key kolonları 
            //aynı ise o zaman SetNull davranuışını KULLANAMAYIZ!
            #endregion

        }

    }
}

