using System;
using _6_MoviesEntities.Entities.Concrete;
using _6_MoviesEntities.EntitiyConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _6_MoviesEntities.EntitiyConfig.Concrete
{
	public class CategoryConfig : BaseConfig<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);//Burayı Sakın Silmeyin.
                                    //BaseEntity'deki configuration calisacak
            builder.Property(p => p.Description).HasMaxLength(500);
            builder.Property(p => p.CategoryName).HasMaxLength(50);

            builder.HasIndex(p => p.CategoryName).IsUnique();
            builder.HasData(new Category { Id = 1, CategoryName = "Drama", Description = "Drama", CreateDate = DateTime.UtcNow },
                            new Category { Id = 2, CategoryName = "Sci-Fi", Description = "Sci-Fi", CreateDate = DateTime.UtcNow },
                            new Category { Id = 3, CategoryName = "Comedy", Description = "Comedy", CreateDate = DateTime.UtcNow },
                            new Category { Id = 4, CategoryName = "Adventure", Description = "Adventure", CreateDate = DateTime.UtcNow },
                            new Category { Id = 5, CategoryName = "Crime", Description = "Crime", CreateDate = DateTime.UtcNow });

            builder.Property(e => e.CreateDate)
                   .HasConversion(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

        }

        
    }
}

