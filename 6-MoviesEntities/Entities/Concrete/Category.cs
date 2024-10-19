using System;
using _6_MoviesEntities.Entities.Abstract;

namespace _6_MoviesEntities.Entities.Concrete
{
	public class Category : BaseEntity
	{

		public string CategoryName { get; set; }

		public string? Description { get; set; }

		public IList<Movie>? Movies { get; set; }
	}
}

