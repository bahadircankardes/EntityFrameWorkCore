using System;
namespace _2_EFCoreQuery.DTOs
{
	public class ProductListForPriceDTo
	{
        public short ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public float? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }
    }
}

