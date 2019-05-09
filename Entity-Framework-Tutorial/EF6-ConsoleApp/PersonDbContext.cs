using System.Data.Entity;

namespace EfConsoleApplication
{
    /// <summary>
    /// The person db context.
    /// </summary>
    public class PersonDbContext : DbContext
    {
        public PersonDbContext() : base("name=PersonContext")
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}