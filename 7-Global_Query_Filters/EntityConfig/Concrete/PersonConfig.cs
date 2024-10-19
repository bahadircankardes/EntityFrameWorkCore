using System;
using _7_Global_Query_Filters.Entiities.Concrete;
using _7_Global_Query_Filters.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _7_Global_Query_Filters.EntityConfig.Concrete
{
	public class PersonConfig :BaseConfig<Person>
	{

        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            base.Configure(builder);
            builder.HasQueryFilter(p => p.IsDeleted == false);
            builder.Property(p => p.Name).HasMaxLength(50);

        }
    }
}

