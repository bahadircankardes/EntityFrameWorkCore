using System;
using System.Collections.Generic;

namespace _10_GenericLibKullanimi.MySqlSakila;

public partial class SalesByFilmCategory
{
    public string Category { get; set; } = null!;

    public decimal? TotalSales { get; set; }
}
