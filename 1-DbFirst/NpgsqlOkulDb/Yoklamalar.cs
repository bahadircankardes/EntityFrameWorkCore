using System;
using System.Collections.Generic;

namespace _1_DbFirst.NpgsqlOkulDb;

public partial class Yoklamalar
{
    public int Id { get; set; }

    public DateOnly Tarih { get; set; }

    public int PlanId { get; set; }

    public int OgrenciId { get; set; }

    public virtual Ogrenciler Ogrenci { get; set; } = null!;

    public virtual DersPlanlari Plan { get; set; } = null!;
}
