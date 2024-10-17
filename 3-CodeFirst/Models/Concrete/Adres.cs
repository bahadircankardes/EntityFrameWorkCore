using System;
using _3_CodeFirst.Models.Abstract;

namespace _3_CodeFirst.Models.Concrete
{
	public class Adres:BaseEntity
	{
        //public int Id { get; set; }

        public int PersonelId { get; set; }
        public Personel Personel { get; set; }


        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string? Ilce { get; set; }

        public string? CaddeSokak { get; set; }
        public string? PostaKodu { get; set; }
        public string? Numara { get; set; }

        //public DateTime CeateDate { get; set; } = DateTime.UtcNow;


    }
}

