using _9_GenericRepository.Concrete;
using _9_GenericRepository.NpgsqlNorthwind;

namespace _9_GenericRepository;

class Program
{
    static void Main(string[] args)
    {
        //NorthwindContext db = new NorthwindContext();
        Repository<Product> prepo = new Repository<Product>();
        var urun1 = prepo.GetById(1);
        Console.WriteLine(urun1.ProductName);

        Repository<Shipper> srepo = new Repository<Shipper>();
        var kargo = new Shipper { CompanyName = "KanBen Kargo", Phone = "0090 546 78 97", ShipperId=33 };
        var sonuc = srepo.Insert(kargo);
        Console.WriteLine(sonuc);
    }
}

