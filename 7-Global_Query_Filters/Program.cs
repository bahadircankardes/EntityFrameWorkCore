using System.Reflection;
using _7_Global_Query_Filters.Context;
using _7_Global_Query_Filters.Entiities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace _7_Global_Query_Filters;

class Program
{
    #region Global Query Filters Nedir?
    //Bir entity'e özel uygulama seviyesinde genel/ön kabullü şartlar oluşturmamızı ve
    //böylece verileri global bir şekilde filtrelememizi sağlayan bir özelliktir.
    //Böylece belirtilen entity üzerinden yapılan tüm sorgulamalarda ekstradan bir şart
    //ifadesine gerek kalmaksızın filtreleri otomatik uygulayarak hızlıca sorgulama
    //yapmamızı sağlamaktadır.

    //Genellikle uygulama bazında aktif(IsActive) gibi verilerle çalışıldığı durumlarda,
    //MultiTenancy uygulamalarda TenantId tanımlarken vs. kullanılabilri.
    #endregion

    #region Global Query Filters Nasıl Uygulanır?
    //await context.Persons.Where(p => p.IsActive).ToListAsync();
    //await context.Persons.ToListAsync();
    //await context.Persons.FirstOrDefaultAsync(p => p.Name.Contains("a") || p.PersonId == 3);
    #endregion
    static void Main(string[] args)
    {
        NpgSqlContext db = new NpgSqlContext();

        //DataBaseE kayit ekleme
        //Person person1 = new Person() { Name="Bahadir"};
        //Person person2 = new Person() { Name = "Salih",IsDeleted= true};
        //Person person3 = new Person() { Name = "Berkay"};
        //Person person4 = new Person() { Name = "Bilge", IsDeleted=true};
        //Person person5 = new Person() { Name = "Emre"};

        //db.Add(person1);
        //db.Add(person2);
        //db.Add(person3);
        //db.Add(person4);
        //db.Add(person5);

        #region Mevcut Kayitlarin Soft Delete İle güncellenmesi
        //var persons = db.Persons.ToList();

        //foreach (var item in persons)
        //{
        //    item.IsDeleted = true;
        //    Console.WriteLine($"{item.Name}");
        //}
        //db.SaveChanges();

        //var degisenler = db.ChangeTracker.Entries();
        //foreach (var item in degisenler)
        //{
        //    Console.WriteLine(item.ToString);
        //    Console.WriteLine(item.CurrentValues);
        //}
        #endregion

        #region Global Filter'in ignore edilmesi.

        var persons1 = db.Persons.ToList();

        var persons2 = db.Persons.IgnoreQueryFilters().ToList();



        #endregion

        #region SoftDelete ile mevcut bir kaydı remove edersek ne olur?

        //var emre = db.Persons.IgnoreQueryFilters().Where(p=> p.Name == "Emre").FirstOrDefault();
        //emre.IsDeleted = false;
        //db.SaveChanges();

        //var emre2 = db.Persons.Where(p => p.Name == "Emre").FirstOrDefault();

        //db.Persons.Remove(emre2);
        //db.SaveChanges();

        #endregion
        Console.WriteLine("Hay Allah");
        Person person3 = new Person() { Name = "Hasan" };
        Person person4 = new Person() { Name = "Bekir" };
        Person person5 = new Person() { Name = "Fatma" };

        var bilge = db.Persons.FirstOrDefault(p => p.Name == "Bilge");
        db.Persons.Remove(bilge);
        db.Persons.Add(person3);
        db.Persons.Add(person4);
        db.Persons.Add(person5);

        db.SaveChanges();
    }

}

//public class Person
//{
//    public int PersonId { get; set; }
//    public string Name { get; set; }
//    public bool IsActive { get; set; }

//    public List<Order> Orders { get; set; }
//}
//public class Order
//{
//    public int OrderId { get; set; }
//    public int PersonId { get; set; }
//    public string Description { get; set; }
//    public int Price { get; set; }

//    public Person Person { get; set; }
//}

//class ApplicationDbContext : DbContext
//{
//    public DbSet<Person> Persons { get; set; }
//    public DbSet<Order> Orders { get; set; }
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    //    modelBuilder.Entity<Person>().HasQueryFilter(p => p.IsActive);
    //    //modelBuilder.Entity<Person>().HasQueryFilter(p => p.Orders.Count > 0);
    //}

    //protected override async void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseNpgsql("User ID=postgres;Password=41264126;Host=127.0.0.1;Port=5432;Database=ApplicationDb");

    //}


