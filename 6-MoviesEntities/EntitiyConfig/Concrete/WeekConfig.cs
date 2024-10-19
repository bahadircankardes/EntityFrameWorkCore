using System;
using _6_MoviesEntities.Entities.Concrete;
using _6_MoviesEntities.EntitiyConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _6_MoviesEntities.EntitiyConfig.Concrete
{
	public class WeekConfig:BaseConfig<Week>
	{
        public override void Configure(EntityTypeBuilder<Week> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.WeekName).HasMaxLength(50);

            builder.HasMany(p => p.Sessions)
                   .WithOne(p => p.Week)
                   .HasForeignKey(p => p.WeekId)
                   .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);

            builder.HasData(new Week {Id=1, WeekName="W32", CreateDate=DateTime.Now,StartDate= new DateOnly(2023,8,14), EndDate = new DateOnly(2025, 8, 14) },
                            new Week { Id = 2, WeekName = "W33", CreateDate = DateTime.Now, StartDate = new DateOnly(2023, 8, 14), EndDate = new DateOnly(2025, 8, 14) },
                            new Week { Id = 3, WeekName = "W34", CreateDate = DateTime.Now, StartDate = new DateOnly(2023, 8, 14), EndDate = new DateOnly(2025, 8, 14) }
                           );
        }

    }
}

