using System;
using System.Collections.Generic;

namespace _1_DbFirst.NpgsqlServerEntities;

public partial class Musterisiparisleri
{
    public short? Siparisno { get; set; }

    public string? Musteri { get; set; }

    public string? Calisan { get; set; }

    public DateOnly? Siparistarihi { get; set; }

    public string? Kargo { get; set; }

    public string? Sehir { get; set; }

    public string? Ulke { get; set; }
}
