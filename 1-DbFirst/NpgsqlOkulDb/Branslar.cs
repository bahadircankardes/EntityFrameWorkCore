using System;
using System.Collections.Generic;

namespace _1_DbFirst.NpgsqlOkulDb;

public partial class Branslar
{
    public int Id { get; set; }

    public string BransAdi { get; set; } = null!;

    public virtual ICollection<Ogretmenler> Ogretmenlers { get; set; } = new List<Ogretmenler>();
}
