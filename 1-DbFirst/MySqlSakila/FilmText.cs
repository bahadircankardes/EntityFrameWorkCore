using System;
using System.Collections.Generic;

namespace _1_DbFirst.MySqlSakila;

public partial class FilmText
{
    public ushort FilmId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }
}
