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

        }
    }
}

