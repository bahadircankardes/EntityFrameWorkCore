using System;
using System.Collections.Generic;

namespace _1_DbFirst.NpgsqlOkulDb;

public partial class DersPlanlari
{
    public int OgretmenId { get; set; }

    public int SinifId { get; set; }

    public TimeOnly Saat { get; set; }

    public short Gun { get; set; }

    public int PlanId { get; set; }

    public virtual Ogretmenler Ogretmen { get; set; } = null!;

    public virtual Siniflar Sinif { get; set; } = null!;

    public virtual ICollection<Yoklamalar> Yoklamalars { get; set; } = new List<Yoklamalar>();
}
