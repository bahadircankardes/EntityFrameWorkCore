using System;
using _6_MoviesEntities.Entities.Abstract;

namespace _6_MoviesEntities.Entities.Concrete
{
	public class Seans : BaseEntity
	{
		public TimeOnly SeansSaati { get; set; }

        public IList<Session>? Sessions { get; set; }


    }
}

