using _4_ManyToMany.Contexts;
using _4_ManyToMany.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace _4_ManyToMany;

class Program
{
    static void Main(string[] args)
    {
        /*
         * ManToMany tablolara CRUD islemleri
         */

        //İlk atilan Kayıt

        //Kategori kategori = new Kategori()
        //{
        //    KategoriAdi = "Elektronik",
        //    Aciklama = "Elektronik",
        //    Urunler = new()
        //    {
        //        new Urun { UrunAdi = "Huawei MateBook i7", UrunKodu ="MATEBOOK14", Adet = 5, Fiyat = 50000},
        //        new Urun { UrunAdi = "Apple MacBook 14", UrunKodu ="MACBOOK14", Adet = 5, Fiyat = 50000},
        //        new Urun { UrunAdi = "ACer NoteBook", UrunKodu ="ACER16", Adet = 5, Fiyat = 50000}
        //    }


        //};
        MySqlContext mySqlDb = new MySqlContext();
        NpgSqlContext npgSqlDb = new NpgSqlContext();


        //Kategori kategori = new Kategori()
        //{
        //    KategoriAdi = "Gida",
        //    Aciklama = "Gida",
        //    Urunler = new()
        //    {
        //        new Urun { UrunAdi = "Elma", UrunKodu ="ELMA", Adet = 15, Fiyat = 50},
        //        new Urun { UrunAdi = "Armut", UrunKodu ="ARMUT", Adet = 25, Fiyat = 35},
        //        new Urun { UrunAdi = "Karpuz", UrunKodu ="KARPUZ", Adet = 45, Fiyat = 12}
        //    }


        //};

        //mySqlDb.Kategoriler.Add(kategori);
        //mySqlDb.SaveChanges();

        //npgSqlDb.Kategoriler.Add(kategori);
        //npgSqlDb.SaveChanges();

        //Select Islemi

        // 1 numarali kategoriyi getirme
        var kategorimySql = mySqlDb.Kategoriler.Find(1);
        var kategoripostgre = mySqlDb.Kategoriler.Find(1);

        //Select İslemi
        var kategori = mySqlDb.Kategoriler
                       .Include(p => p.Urunler)
                       .Where(p => p.KategoriAdi == "Gida").FirstOrDefault();

        var elektronik = mySqlDb.Kategoriler
                       .Include(p => p.Urunler)
                       .Where(p => p.KategoriAdi == "Elektronik").FirstOrDefault();


        //Karpuz urunun kategorisini degistirmek
        //Bulundugu kategorideki bagını kemek lazım sonra yeni katgoriye
        //eklemek gerekir

        var karpuz = mySqlDb.Urunler.Where(p=> p.UrunAdi=="Karpuz").FirstOrDefault();
        kategori.Urunler.Remove(karpuz);
        elektronik.Urunler.Add(karpuz);
        mySqlDb.SaveChanges();


    }
}

