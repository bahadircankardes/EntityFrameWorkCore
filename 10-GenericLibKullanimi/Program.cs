using __10_GenericLibKullanimi.MySqlSakila;
using _10_GenericLibKullanimi.Manager.Concrete;
using _10_GenericLibKullanimi.MySqlSakila;
using _10_GenericLibKullanimi.NpgsqlNorthwind;
using GenericRepository.Concrete;

namespace _10_GenericLibKullanimi;

class Program
{
    static void Main(string[] args)
    {
        #region MySql'e göre Generic Repository Calistirilmasi

        //Repository<Country, SakilaContext> sakiladb = new Repository<Country, SakilaContext>();
        //Country country = new Country() { Country1 = "Turkiye" };

        //var sonuc = sakiladb.Insert(country);
        //Console.WriteLine(country.CountryId);

        #endregion

        #region PostgreSql'e Gore GenericRepository Kullanimi

        //Repository<Region, NorthwindContext> regionrepo = new Repository<Region, NorthwindContext>();
        //Region region = new Region() { RegionId=6, RegionDescription= "Marmara Region" };
        //regionrepo.Insert(region);
        //Console.WriteLine(region.RegionId);

        //Repository<NpgsqlNorthwind.Category, NorthwindContext> catrepo = new Repository<NpgsqlNorthwind.Category, NorthwindContext>();
        //NpgsqlNorthwind.Category category = new NpgsqlNorthwind.Category()
        //{
        //     CategoryId = 9, CategoryName = "Tekstil" 
        //};

        //catrepo.Insert(category);
        #endregion

        #region Generic Repository de iliskili kayitlarin getirilmesi

        Repository<Product, NorthwindContext> productrepo = new Repository<Product, NorthwindContext>();
        //productRepo.GetAll().Include(p=>p.Category); bunu kullanmak icin repository
        //pattern uzerinde degisiklik yapmak gerekir.

        //var result = productrepo.GetAll(p => p.CategoryId == 1).ToList();
        //var result2 = productrepo.GetAllInclude(p => p.CategoryId==1, p => p.Category, p => p.Supplier, p => p.OrderDetails).ToList();
        //Console.WriteLine("");
        #endregion

        CustomerManager<NpgsqlNorthwind.Customer, NorthwindContext> manager = new CustomerManager<NpgsqlNorthwind.Customer, NorthwindContext>();
        NpgsqlNorthwind.Customer customer = new NpgsqlNorthwind.Customer()
        {
            CustomerId = "ABCDE",
            CompanyName = "XYZ LTD",
            Country = "Germany"
        };

        try
        {
            var sonuc = manager.Insert(customer);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}

