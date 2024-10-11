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
    #endregion
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");

    }
}

