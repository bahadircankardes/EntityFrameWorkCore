using System;
using _3_CodeFirst.Models.Abstract;

namespace _3_CodeFirst.Models.Concrete
{
	public class Personel:BaseEntity
	{
		//public int Id { get; set; }

		public string Adi { get; set; }

		public string Soyadi { get; set; }

		public string Email { get; set; }

		public string Gsm { get; set; }

		public string TcNo { get; set; }

		//Bir kişinin birden çok adresi olmasını istiyoruz diyelim 
		//public Adres Adres { get; set; } dersek bir kisinin bir adresi olur
		//Ya liste , Ya Icollection, IEnumarable yapmaliyiz.

		public ICollection<Adres> Adresler { get; set; } = new HashSet<Adres>();

		//public DateTime CeateDate { get; set; } = DateTime.UtcNow;

	}
}

