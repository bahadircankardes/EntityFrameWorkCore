using System;
namespace _3_CodeFirst.Models
{
	public class Kategori
	{
		public int Id { get; set; }

		public string KategoryAdi { get; set; }

		public string? Aciklama { get; set; }

		public DateTime? CreateDate { get; set; } = DateTime.UtcNow;

		public ICollection<Urun> Urunler{ get; set; }
		//Herbir kategorinin bir urunu var dedik

	}
}

