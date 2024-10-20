using _9_GenericRepository.NpgsqlNorthwind;

namespace _9_GenericRepository;

class Program
{
    static void Main(string[] args)
    {
        NorthwindContext db = new NorthwindContext();


        Console.WriteLine("Hello, World!");
    }
}

