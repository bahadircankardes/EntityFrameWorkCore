using System;
namespace _7_Global_Query_Filters.Entiities.Abstract
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }

		public bool IsDeleted { get; set; }
	}
}

