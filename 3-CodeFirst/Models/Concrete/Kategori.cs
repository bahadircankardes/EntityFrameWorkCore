using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using _3_CodeFirst.Models.Abstract;
using _3_CodeFirst.Models.Concrete; // Kategori ve Urun sınıflarının olduğu namespace.


namespace _3_CodeFirst.Models.Concrete
{
	//Property'leri kisitlamak icin DataAnnotations Kullanilabilir.
	//Ancak bu single responsibility prensbini ezmektedir.
	//Bunun yerine Fluent Api kullanilmasi tavsiye edilmektedir.

	//[Table("Kategoriler")]
	public class Kategori:BaseEntity
	{
		//[Key]
		//public int Id { get; set; }

		[MaxLength(50)]
		public string KategoriAdi { get; set; }

        [MaxLength(500)]
        public string? Aciklama { get; set; }

		//public DateTime? CreateDate { get; set; } = DateTime.UtcNow;

		public ICollection<Urun> Urunler{ get; set; } //Navigation Property.
		//Herbir kategorinin bir urunu var dedik



	}
}

