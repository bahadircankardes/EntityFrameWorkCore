using System.Linq;
using _2_EFCoreQuery.DTOs;
using _2_EFCoreQuery.NpgsqlNorthwind;
using Microsoft.EntityFrameworkCore;

namespace _2_EFCoreQuery;

class Program
{
    static void Main(string[] args)
    {
        NorthwindContext context = new NorthwindContext();
        #region Genel Syntax
        #region Sorular
        //1- Londradaki musterilerin listesi Metod Syntax
        //context.Customers.Where(p=> p.City == "London").ToList().ForEach(p=> Console.WriteLine(p.ContactName + " " + p.CompanyName + " " +p.City));
        //Query Syntax ile yapilisi:Yazilan sorguda ToList() metodu cagirilmadigi
        //surece IQueryable seklinde kalir. Henuz database e gonderilmemistir.

        //var customerList = (from cust in context.Customers
        //                   where cust.City == "London"
        //                   select cust).ToList();

        //var customerListAnonimObject = from cust in context.Customers
        //                   where cust.City == "London"
        //                   select new
        //                   {
        //                       MusteriId = cust.CustomerId,
        //                       SirketAdi = cust.CompanyName,
        //                       Sehir = cust.City
        //                   };

        //foreach (var item in customerListAnonimObject)
        //{
        //    Console.WriteLine(item.MusteriId + " " + item.Sehir);
        //}
        //DTo ile kullanımı
        //var productListDTo = (from p in context.Products
        //                               where p.UnitPrice >= 50
        //                               select new ProductListForPriceDTo
        //                               {
        //                                   ProductId = p.ProductId,
        //                                   ProductName = p.ProductName,
        //                                   UnitPrice = p.UnitPrice,
        //                                   UnitsInStock = p.UnitsInStock
        //                               }).ToList();


        //Eger belirli kolonlar isteniyorsa

        //context.Customers.Where(p => p.City == "London")
        //.Select(customer =>
        //new            //Anonim class bir kere işimize yarayıp atacagız
        //{
        //    customer.CustomerId,
        //    customer.CompanyName,
        //    customer.City
        //})
        //.ToList();
        //.ForEach(customer => Console.WriteLine(customer.CustomerId + " "+ customer.CompanyName));



        //2- Fiyati 50$ uzerınde olan urunlerın listesi
        //context.Products.Where(p=> p.UnitPrice > 50)
        //.ToList()
        //.ForEach(p=> Console.WriteLine(p.ProductName + " " + p.UnitPrice));

        //DTO klasörüne class acarsak tekrar kullanabiliriz.class a propları ekliyoruz.
        //context.Products.Where(q => q.UnitPrice > 50)
        //.Select(p => new ProductListForPriceDTo 
        //{
        //    ProductId = p.ProductId,
        //    ProductName = p.ProductName,
        //    UnitPrice = p.UnitPrice,
        //    UnitsInStock = p.UnitsInStock

        //}).ToList();


        //3- 1 numarali kategoriye ait urunlerin listesi
        //context.Products.Where(p=> p.CategoryId ==1)
        //.ToList()
        //.ForEach(p=> Console.WriteLine(p.CategoryId + "\t" + p.ProductName));


        #endregion
        #endregion

        #region Sıralama
        //Method Syntax ile yapilisi
        //context.Products.Where(s => s.CategoryId == 1)
        //                .OrderBy(s => s.ProductName)
        //                .OrderBy(s => s.UnitPrice)
        //                .ToList();

        //Query Syntax ile Yapilisi

        //var productList = (from urun in context.Products
        //                   where urun.CategoryId == 1
        //                   orderby urun.ProductName, urun.UnitPrice
        //                   select urun).ToList();


        //var productList2 = (from urun in context.Products
        //                   where urun.ProductName.Contains('a')
        //                   orderby urun.ProductName, urun.UnitPrice
        //                   select urun).ToList();

        #endregion

        #region Gruplama
        /*select country, count(*) from customers group by country order by country*/

        //Method Syntax
        //var result = context.Customers.GroupBy(p => p.Country).ToList();

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item.Key + " " + item.Count());
        //}

        //Query Syntax
        //var result2 = from od in context.OrderDetails
        //              group od by od.OrderId into g
        //              select new
        //              {
        //                  SiparisNo = g.Key,
        //                  Ciro = g.Sum(p=> p.Quantity * p.UnitPrice)
        //              };

        //foreach (var item in result2)
        //{
        //    Console.WriteLine(item.SiparisNo + " " + item.Ciro);

        //}



        //Siparislerin Toplam Tutarini toplayın

        //select order_id, sum(unit_price * quantity) Ciro
        //from order_details group by order_id

        //var siparisToplamlari = context.OrderDetails.GroupBy(p=> p.OrderId).ToList();
        //foreach (var item in siparisToplamlari)
        //{
        //    Console.WriteLine(item.Key + " " + item.Sum(p=> p.Quantity * p.UnitPrice));
        //}

        #endregion

        #region Join Islemleri

        /*select p.product_id, p.product_name, s.company_name, c.category_name 
         * from products p
         * inner join categories c on p.category_id = c.category_id
         * inner join suppliers s on s.supplier_id = p.supplier_id*/


        //Method Syntax

        //var urunler = context.Products
        //                .Include(p => p.Category)
        //                .Include(p => p.Supplier)
        //                .Select(p=> new
        //                {
        //                    UrunId = p.ProductId,
        //                    UrunAdi = p.ProductName,
        //                    Kategory = p.Category.CategoryName,
        //                    Tedarikci = p.Supplier.CompanyName
        //                })
        //                .ToList();
        //foreach (var item in urunler)
        //{
        //    Console.WriteLine(item.UrunId + " " + item.UrunAdi + " " + item.Kategory + " " + item.Tedarikci );


        //}

        //Query Syntax

        //var urunler = from p in context.Products
        //              join c in context.Categories on p.CategoryId equals c.CategoryId
        //              join s in context.Suppliers on p.SupplierId equals s.SupplierId
        //              select new
        //              {
        //                  UrunId = p.ProductId,
        //                  UrunAdi = p.ProductName,
        //                  Kategori = p.Category.CategoryName,
        //                  Tedarikci = p.Supplier.CompanyName + "=>" + p.Supplier.ContactName
        //              };
        //foreach (var item in urunler)
        //{
        //    Console.WriteLine(item.UrunId + " " + item.UrunAdi + " " + item.Kategori + " " + item.Tedarikci);
        //}

        #region Calisanlarin 1997 yilinda aldigi siparis sayilarini bastirin.
        /*select e.last_name, e.first_name, count(o.employee_id) 
                    from orders o 
                    inner join employees e on e.employee_id = o.employee_id 
                    where date_part(('year'), order_date)= 1997
                    group by e.last_name, e.first_name
                    order by count desc
         */

        //var calisanlar = context.Employees
        //    .Include(p => p.Orders.Where(o => o.OrderDate.Value.Year == 1997))
        //    .GroupBy(e=>e.FirstName+ " " + e.LastName)//Group by da belitilenler Keydir
        //    .ToList();
        //foreach (var item in calisanlar)
        //{
        //    Console.WriteLine(item.Key + " " + item.Count());//Group by da belitilenler Keydir

        //}
        //Query Syntax

        var calisanlar2 = from e in context.Employees
                          join o in context.Orders on e.EmployeeId equals o.EmployeeId
                          where o.OrderDate.Value.Year == 1997
                          group e by e.FirstName + " " + e.LastName into g
                          select new
                          {
                              Calisan = g.Key,
                              Adet = g.Count()
                          };
        foreach (var item in calisanlar2)
        {
            Console.WriteLine(item.Calisan + " " + item.Adet);
        }


                          #endregion



                          #endregion

        Console.WriteLine("Hello, World!");
    }
}

