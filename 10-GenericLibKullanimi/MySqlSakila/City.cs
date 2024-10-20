using System;
using System.Collections.Generic;
using _10_GenericLibKullanimi.MySqlSakila;

namespace __10_GenericLibKullanimi.MySqlSakila;

public partial class City
{
    public ushort CityId { get; set; }

    public string City1 { get; set; } = null!;

    public ushort CountryId { get; set; }

    public DateTime LastUpdate { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual Country Country { get; set; } = null!;
}
