using System;
using _6_MoviesEntities.Entities.Abstract;

namespace _6_MoviesEntities.Entities.Concrete
{
	public class Session : BaseEntity
	{

		public int MovieId { get; set; }
		public Movie Movie { get; set; } // Bire Cok iliski için navigation property
										 // bir movie nin birden çok seansı olabilir 

		public int SaloonId { get; set; }
		public Saloon Saloon { get; set; }

		public int SeansId { get; set; }
		public Seans Seans { get; set; }


		public int WeekId { get; set; }
		public Week Week { get; set; }
	}
}

