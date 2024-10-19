using System;
namespace _6_MoviesEntities.Entities.Abstract
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }

		public DateTime CreateDate { get; set; } = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);

	}
}

