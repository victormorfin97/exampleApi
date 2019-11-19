using Microsoft.EntityFrameworkCore;

namespace exampleapi.Models
{
    public class ExampleContext : DbContext
    {
        public ExampleContext(DbContextOptions<ExampleContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}

