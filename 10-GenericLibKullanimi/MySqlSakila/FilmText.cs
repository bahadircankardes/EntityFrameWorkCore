using System;
using System.Collections.Generic;

namespace _10_GenericLibKullanimi.MySqlSakila;

public partial class FilmText
{
    public ushort FilmId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }
}
