using System;
using System.Collections.Generic;

namespace _2_EFCoreQuery.NpgsqlNorthwind;

public partial class Category
{
    public short CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
