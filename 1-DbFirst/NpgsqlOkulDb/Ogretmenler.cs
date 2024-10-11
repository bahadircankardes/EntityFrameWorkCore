using System;
using System.Collections.Generic;

namespace _1_DbFirst.NpgsqlOkulDb;

public partial class Ogretmenler
{
    public int Id { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? TcNo { get; set; }

    public string? Email { get; set; }

    public DateOnly? DogumTarihi { get; set; }

    public bool? Cinsiyet { get; set; }

    public int? BransId { get; set; }

    public virtual Branslar? Brans { get; set; }

    public virtual ICollection<DersPlanlari> DersPlanlaris { get; set; } = new List<DersPlanlari>();
}
