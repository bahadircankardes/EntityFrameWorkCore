using System.Linq;
using _2_EFCoreQuery.DTOs;
using _2_EFCoreQuery.NpgsqlNorthwind;

namespace _2_EFCoreQuery;

class Program
{
    static void Main(string[] args)
    {
        NorthwindContext context = new NorthwindContext();
        #region Genel Syntax
        #region Sorular
        //1- Londradaki musterilerin listesi Metod Syntax
        context.Customers.Where(p=> p.City == "London").ToList().ForEach(p=> Console.WriteLine(p.ContactName + " " + p.CompanyName + " " +p.City));
        //Query Syntax ile yapilisi:Yazilan sorguda ToList() metodu cagirilmadigi
        //surece IQueryable seklinde kalir. Henuz database e gonderilmemistir.

        var customerList = (from cust in context.Customers
                           where cust.City == "London"
                           select cust).ToList();

        var customerListAnonimObject = from cust in context.Customers
                           where cust.City == "London"
                           select new
                           {
                               MusteriId = cust.CustomerId,
                               SirketAdi = cust.CompanyName,
                               Sehir = cust.City
                           };

        foreach (var item in customerListAnonimObject)
        {
            Console.WriteLine(item.MusteriId + " " + item.Sehir);
        }
        //DTo ile kullanımı
        var productListDTo = (from p in context.Products
                                       where p.UnitPrice >= 50
                                       select new ProductListForPriceDTo
                                       {
                                           ProductId = p.ProductId,
                                           ProductName = p.ProductName,
                                           UnitPrice = p.UnitPrice,
                                           UnitsInStock = p.UnitsInStock
                                       }).ToList();


        //Eger belirli kolonlar isteniyorsa

        context.Customers.Where(p => p.City == "London")
        .Select(customer =>
        new            //Anonim class bir kere işimize yarayıp atacagız
        {
            customer.CustomerId,
            customer.CompanyName,
            customer.City
        })
        .ToList();
        //.ForEach(customer => Console.WriteLine(customer.CustomerId + " "+ customer.CompanyName));



        //2- Fiyati 50$ uzerınde olan urunlerın listesi
        context.Products.Where(p=> p.UnitPrice > 50)
        .ToList()
        .ForEach(p=> Console.WriteLine(p.ProductName + " " + p.UnitPrice));

        //DTO klasörüne class acarsak tekrar kullanabiliriz.class a propları ekliyoruz.
        context.Products.Where(q => q.UnitPrice > 50)
        .Select(p => new ProductListForPriceDTo 
        {
            ProductId = p.ProductId,
            ProductName = p.ProductName,
            UnitPrice = p.UnitPrice,
            UnitsInStock = p.UnitsInStock

        }).ToList();


        //3- 1 numarali kategoriye ait urunlerin listesi
        context.Products.Where(p=> p.CategoryId ==1)
        .ToList()
        .ForEach(p=> Console.WriteLine(p.CategoryId + "\t" + p.ProductName));


        #endregion
        #endregion

        #region Gruplama

        #endregion

        #region Join Islemleri

        #endregion

        Console.WriteLine("Hello, World!");
    }
}

