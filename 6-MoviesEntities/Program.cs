using _6_MoviesEntities.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _6_MoviesEntities;

class Program
{
    static void Main(string[] args)
    {
        MovieDbContext db = new MovieDbContext();

        db.Database.Migrate();
       
    }
}

