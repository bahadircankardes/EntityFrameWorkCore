using System;
namespace _3_CodeFirst.Models
{
	public enum Birim : byte
	{
		Adet = 1,
		Gram,
		Cm,
		Koli
	}
	public class Urun
	{
		public int UrunId { get; set; }

		public string Urunadi { get; set; }

		public double? Fiyat { get; set; }

		public double? Adet { get; set; }

		public Birim? Birim { get; set; }

		public int KategoriId { get; set; }//Bu alan database e yansıyacak kolondur.

		public Kategori Kategori { get; set; }//Navigation property. burası database e yansımaz
	}
}

