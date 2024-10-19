using System;
using _6_MoviesEntities.Entities.Concrete;
using _6_MoviesEntities.EntitiyConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _6_MoviesEntities.EntitiyConfig.Concrete
{
	public class MovieConfig:BaseConfig<Movie>
	{
        public override void Configure(EntityTypeBuilder<Movie> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.MovieName).HasMaxLength(100);
            builder.Property(p => p.Description).HasMaxLength(1000);

            builder.HasMany(p => p.Sessions).WithOne(p => p.Movie)
                   .HasForeignKey(p => p.MovieId)
                   .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);
        }

    }
}

