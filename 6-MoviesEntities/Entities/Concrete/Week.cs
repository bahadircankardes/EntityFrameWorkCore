using System;
using _6_MoviesEntities.Entities.Abstract;

namespace _6_MoviesEntities.Entities.Concrete
{
	public class Week:BaseEntity
	{
		public string WeekName { get; set; }

		public DateOnly? StartName { get; set; }

        public DateOnly? EndDate { get; set; }

        public IList<Session>? Sessions { get; set; }




    }
}

