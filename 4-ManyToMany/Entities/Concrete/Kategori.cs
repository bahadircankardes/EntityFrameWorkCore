using System;
using _4_ManyToMany.Entities.Abstract;

namespace _4_ManyToMany.Entities.Concrete
{
	public class Kategori : BaseEntity
	{
		public string KategoriAdi { get; set; }

		public string Aciklama { get; set; }

        public List<Urun> Urunler { get; set; } //Many to Many için yazdık


    }
}

