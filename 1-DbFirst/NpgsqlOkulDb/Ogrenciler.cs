using System;
using System.Collections.Generic;

namespace _1_DbFirst.NpgsqlOkulDb;

public partial class Ogrenciler
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyadi { get; set; } = null!;

    public string? Tcno { get; set; }

    public string? Email { get; set; }

    public string? Gsm { get; set; }

    public DateOnly? DogumTarihi { get; set; }

    public bool? Cinsiyet { get; set; }

    public int? SinifId { get; set; }

    public virtual Siniflar? Sinif { get; set; }

    public virtual ICollection<Yoklamalar> Yoklamalars { get; set; } = new List<Yoklamalar>();
}
