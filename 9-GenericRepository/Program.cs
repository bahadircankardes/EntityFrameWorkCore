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

        #region Func<T,bool> delegate ihtiyaci 

        //srepo.GetAll(p=>p.CompanyName =="qweasd LTD"); //Burada Func<Shipper,bool> => predicate delegate kullanilmasi lazim.
        // Yani benim burada bir Func delegate geçebilecegim bir metod lazim
        srepo.GetBy(p => p.CompanyName == "qweasd Ltd");

        #endregion
    }
}

