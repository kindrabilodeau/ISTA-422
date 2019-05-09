using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;  //had to add this using directive 
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class BlogDbContext: DbContext  //an abstraction over the database thats used to load or save data
    {
        public DbSet<Post> Post { get; set; }
    }

    //next need to specify the connection string for the data base 

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
