﻿using System;
using System.Collections.Generic;

namespace _10_GenericLibKullanimi.NpgsqlNorthwind;

public partial class Shipper
{
    public short ShipperId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Phone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
