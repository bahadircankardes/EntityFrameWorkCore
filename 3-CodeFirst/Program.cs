using _3_CodeFirst.Contexts;
using _3_CodeFirst.Models;

namespace _3_CodeFirst;

class Program
{
    static void Main(string[] args)
    {
        TicariPaketContext db = new TicariPaketContext();
        Kategori kategori = new Kategori();
        Console.WriteLine(kategori.CreateDate);
        
        Console.WriteLine("Hello, World!");
    }
}

