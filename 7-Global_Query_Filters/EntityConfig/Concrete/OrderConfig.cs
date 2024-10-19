using System;
using _7_Global_Query_Filters.Entiities.Concrete;
using _7_Global_Query_Filters.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7_Global_Query_Filters.EntityConfig.Concrete
{
	public class OrderConfig:BaseConfig<Order>
	{
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.HasQueryFilter(p => p.IsDeleted == false);

        }

    }
}

