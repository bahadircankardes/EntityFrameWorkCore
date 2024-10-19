using System;
using _6_MoviesEntities.Entities.Abstract;

namespace _6_MoviesEntities.Entities.Concrete
{
	public class Movie :BaseEntity
	{
		public string MovieName { get; set; }

		public string? Description { get; set; }

		public short? Duration { get; set; }

		public IList<Category>? Categories { get; set; }

		public IList<Session>? Sessions { get; set; }

	}
}

