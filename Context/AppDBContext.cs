using crud.Models;
using Microsoft.EntityFrameworkCore;

namespace crud.Context
{
    public class AppDBContext: DbContext 
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
