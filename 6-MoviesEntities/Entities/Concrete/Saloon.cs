using System;
using _6_MoviesEntities.Entities.Abstract;

namespace _6_MoviesEntities.Entities.Concrete
{
	public class Saloon:BaseEntity
	{
		public string SalonName { get; set; }

		public short Kapasite { get; set; }

        public IList<Session>? Sessions { get; set; }





    }
}

