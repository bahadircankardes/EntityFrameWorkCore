using System;
using _7_Global_Query_Filters.Entiities.Abstract;

namespace _7_Global_Query_Filters.Entiities.Concrete
{
	public class Order:BaseEntity
	{
        public string Description { get; set; }
        public int Price { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}

