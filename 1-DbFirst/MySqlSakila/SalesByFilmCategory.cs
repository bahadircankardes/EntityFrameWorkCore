using System;
using System.Collections.Generic;

namespace _1_DbFirst.MySqlSakila;

public partial class SalesByFilmCategory
{
    public string Category { get; set; } = null!;

    public decimal? TotalSales { get; set; }
}
