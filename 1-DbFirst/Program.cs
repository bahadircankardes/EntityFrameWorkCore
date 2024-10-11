using _1_DbFirst.NpgsqlServerEntities;

namespace _1_DbFirst;

class Program
{
    #region Gerekli ortamin hazilanmasi
    /*
     * 1- EntityFramework tool 'unu kurmak
     * Bunu komut satiri uzerinden yapacagiz
     * 
     *  dotnet tool install --global dotnet-ef komutu ef tool paketini kurar
     *  
     *  Ayrica projemize hangi database ile calisacak isek 
     *  Mesela EntityFrameWorkCore.SqlServer ilgili paketini ve EntityFrameWorkCore.Design paketini kurmak gereklidir.
     *  Bu paketleri nuget uzerinden indirebiliriz
     *  
     *  Halihazirdaki bir database'in DbContext'ini cikartmak icin aşagidaki komut kullanilabilir.
     *  Burada Connection string ve Hangi database paketi ni kullanacagimiz degistirmek yeterli olacaktir.
     *  
     *  dotnet ef dbcontext scaffold 
     *  "server=.;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=true"  //Burasi Connection string bolumu
     *  Microsoft.EntityFrameWorkCore.SqlServer    // Hangi databasea ile calisacagi bilgisi
     *  -o Entities  // output olarak hangi Klasore cikti verecegi
     */

    //Postgresql için terminale yazdıgım;
    /*dotnet ef dbcontext scaffold "User ID=postgres;Password=41264126;Host=127.0.0.1;Port=5432;Database=Northwind" Npgsql.EntityFrameworkCore.PostgreSQL -o NpgsqlServerEntities*/
    #endregion
    static void Main(string[] args)
    {
        #region Ilk Denemeler
        
        NorthwindContext dbcontext = new NorthwindContext();

        //Shipper tablosundakik tum kayitlari alma
        //dbcontext.Shippers.ToList().ForEach(x=> Console.WriteLine(x.CompanyName));

        //Almanyadaki musterileri alalım
        //dbcontext.Customers.Where(p => p.Country == "Germany").ToList().ForEach(p=> Console.WriteLine(p.CompanyName));


        #endregion

        #region EF ile Crud islemleri
        // Insert icin once nesne olusturulur.

        Shipper shipper = new Shipper()
        {
            CompanyName = "Kırklar Cargo",
            ShipperId = 24,
            Phone = "39 900 30"
        };

        //Sonra ilgili property e eklenir

        dbcontext.Shippers.Add(shipper);

        var shipper24 = dbcontext.Shippers.Find((short) 24);

        Console.WriteLine(shipper24);

        //Update islemi icin once kayda konumlanıp c# tarafına alıyoruz.

        var shipper20 = dbcontext.Shippers.Find((short) 20);

        Console.WriteLine(shipper20);

        shipper20.CompanyName = "Yellowish";
        dbcontext.Shippers.Update(shipper20);//Update komutu cıkarmak icin isaretler

        //Silme islemi : silkmek icin kayda konumlanmak gerekir.

        var shipper8= dbcontext.Shippers.Find((short) 8);
        Console.WriteLine($"{shipper8} siliniyor...");
        dbcontext.Shippers.Remove(shipper8);//Remove komutu cıkarmak icin isaretler


        // En son dbcontext'in Savechanges();

        dbcontext.SaveChanges();


        #endregion

    }
}

