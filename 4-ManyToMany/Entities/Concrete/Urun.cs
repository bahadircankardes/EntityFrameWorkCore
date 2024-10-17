using System;
using _4_ManyToMany.Entities.Abstract;

namespace _4_ManyToMany.Entities.Concrete
{
	public class Urun : BaseEntity
	{
		public string UrunKodu { get; set; }

		public string UrunAdi { get; set; }

		public double? Fiyat { get; set; }

        public double? Adet { get; set; }

		public List<Kategori>Kategoriler { get; set; } //Many to Many için yazdık

    }
}

