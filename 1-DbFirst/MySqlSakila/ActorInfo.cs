using System;
using System.Collections.Generic;

namespace _1_DbFirst.MySqlSakila;

public partial class ActorInfo
{
    public ushort ActorId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? FilmInfo { get; set; }
}
