using System;
using System.Collections.Generic;

namespace _1_DbFirst.NpgsqlOkulDb;

public partial class Siniflar
{
    public int Id { get; set; }

    public string SinifAdi { get; set; } = null!;

    public short? Kapasite { get; set; }

    public virtual ICollection<DersPlanlari> DersPlanlaris { get; set; } = new List<DersPlanlari>();

    public virtual ICollection<Ogrenciler> Ogrencilers { get; set; } = new List<Ogrenciler>();
}
