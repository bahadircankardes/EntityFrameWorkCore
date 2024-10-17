using System;
namespace _4_ManyToMany.Entities.Abstract
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }

		public DateTime CreateDate { get; set; } = DateTime.UtcNow; 
	}
}

