using System;
using _6_MoviesEntities.Entities.Concrete;
using _6_MoviesEntities.EntitiyConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _6_MoviesEntities.EntitiyConfig.Concrete
{
	public class SeansConfig : BaseConfig<Seans>
	{
        public override void Configure(EntityTypeBuilder<Seans> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.SeansSaati).HasMaxLength(50);

            builder.HasMany(p => p.Sessions)
                   .WithOne(p => p.Seans)
                   .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);

        }

    }
}

