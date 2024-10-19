using System;
using _7_Global_Query_Filters.Entiities.Abstract;

namespace _7_Global_Query_Filters.Entiities.Concrete
{
	public class Person:BaseEntity
	{

        public string Name { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}

