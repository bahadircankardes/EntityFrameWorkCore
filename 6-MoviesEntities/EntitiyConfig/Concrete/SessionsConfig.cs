using System;
using _6_MoviesEntities.Entities.Concrete;
using _6_MoviesEntities.EntitiyConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _6_MoviesEntities.EntitiyConfig.Concrete
{
	public class SessionsConfig:BaseConfig<Session>
	{
        public override void Configure(EntityTypeBuilder<Session> builder)
        {
            base.Configure(builder);

            builder.HasIndex(p => new { p.SaloonId, p.SeansId, p.WeekId }).IsUnique();
        }
    }
}

