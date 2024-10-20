using Microsoft.EntityFrameworkCore;

namespace _8_TablePerHierarchy;

class Program
{
    static void Main(string[] args)
    {
        PgSqlContext pgSqldb = new PgSqlContext();

        #region Discriminator Tabloya Kayıt ekleme

        //Otomobil otomobil = new Otomobil()
        //{
        //    Marka = "Bmw",
        //    KasaTipi = KasaTipi.Sedan,
        //    Model = "320"
        //};
        //Motorsiklet motorsiklet = new Motorsiklet()
        //{
        //    Marka = "Bmw",
        //    Model = "F850",
        //    MotorsikletTipi = MotorsikletTipi.Race
        //};

        //Otobus otobus = new Otobus()
        //{
        //    Marka = "Mercedes",
        //    Model = "ABC",
        //    KoltukSayisi = 48
        //};

        ////pgSqldb.Araclar.AddRange(otomobil, motorsiklet, otobus);

        //pgSqldb.Otobusler.Add(otobus);
        //pgSqldb.Otomobiller.Add(otomobil);
        //pgSqldb.Motosikletler.Add(motorsiklet);

        //pgSqldb.SaveChanges();
        #endregion

        #region Kayit Sorgulama

        //var otomobiller = pgSqldb.Otomobiller.ToList();
        //var otobusler = pgSqldb.Otobusler.ToList();
        //var motorsikletler = pgSqldb.Motosikletler.ToList();

        #endregion

        #region Update, Delete
        //Update
        //var motor = pgSqldb.Motosikletler.Where(p => p.Marka == "Bmw").FirstOrDefault();
        //motor.Model = "Varadero";
        //pgSqldb.Motosikletler.Update(motor);
        //pgSqldb.SaveChanges();

        //Delete
        var f850sil = pgSqldb.Motosikletler.Where(p => p.Model == "F850").FirstOrDefault();
        pgSqldb.Motosikletler.Remove(f850sil);
        pgSqldb.SaveChanges();


        #endregion
        Console.WriteLine("Hello, World!");
    }
    public class PgSqlContext : DbContext
    {
        public DbSet<Arac> Araclar { get; set; } // Burayı yazarsak aşağıda yazılanlar için ayrı bir tablo
                                                 // olusmaz. tek bir tabloda discriminator olrak geliyor tek bir tablo oluşuyor.

        public DbSet<Motorsiklet> Motosikletler { get; set; }

        public DbSet<Otomobil> Otomobiller { get; set; }

        public DbSet<Otobus> Otobusler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID = postgres; Password = 41264126; Host = 127.0.0.1; Port = 5432; Database = AraclarDb");
        }
    }

    public abstract class Arac
    {
        public int Id { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }
    }

    public enum KasaTipi:byte
    {
        Sedan=1,
        Cupe,
        StationWagon
    }

    public class Otomobil:Arac
    {
        public KasaTipi KasaTipi { get; set; }
    }

    public enum MotorsikletTipi:byte
    {
        Scooter=1,
        Naked,
        Race
    }

    public class Motorsiklet:Arac
    {
        public MotorsikletTipi MotorsikletTipi { get; set; }
    }

    public class Otobus : Arac
    {
        public byte KoltukSayisi { get; set; }
    }
}

