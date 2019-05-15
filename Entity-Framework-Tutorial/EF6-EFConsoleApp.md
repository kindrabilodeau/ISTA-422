## Kindra Bilodeau
### Entity Framework Tutorial: Basic Console Application
###### Followed this tutorial: https://www.codeproject.com/Tips/1046655/Very-Basic-Console-Application-Using-Entity-Framew

1. Have Visual Studio and SQL Server installed and running  
2. Create a new project
  - Select Console APP (.Net Framework)
  - Name it: **EfConsoleApplication**
3. To add Entity Frame work:
  - On the navigation bar find "Tools"
  - Find: "Nuget Package Manager"
  - Then: "Manage NuGet Package for Solution"
  - On the Browse tab search for "Entity Framework"
  - Click on it and install it.
    - (I installed version 6.2.0)
4. Add a new class
  - Right click on solution, Find Add > Class > Name it **Person.cs**
  - Add the following:
````C#
  using System;
  namespace EfConsoleApplication
  {
      public class Person
      {
          public int PersonId { get; set; }
          public string LastName { get; set; }
          public string FirstName { get; set; }
          public DateTime BirthDate { get; set; }
      }
  }
  ````
5. Add a new class
  - Right click on solution, Find Add > Class > Name it **PersonDbContext.cs**
  - Add the following:
````C#
  using System.Data.Entity;
  namespace EfConsoleApplication
  {
      public class PersonDbContext : DbContext
      {
          public PersonDbContext() : base("name=PersonContext")
          {

          }
          public DbSet<Person> Persons { get; set; }
      }
  }
  ````
6. In the App.config file **below** the closing entity Framework tag ``</entityFramework>`` (approx line 19) add the following:

````C#
</entityFramework>
  <connectionStrings>  
          <add name="PersonContext"

         connectionString="Data Source=.;Initial Catalog=PersonDb;  
          	Integrated Security=true"

          providerName="System.Data.SqlClient"/>  
 </connectionStrings>   
 ````
 - Note that the "Data Source" name of your connectionstring may be different
 - You can try: connectionString="Data Source=(localdb)\mssqllocaldb;

7. In the Program file add
````C#  
 using System;    
 namespace EfConsoleApplication  
{    
    public class Program  
    {  
        public static void Main(string[] args)  
        {  
            PerformDatabaseOperations();  
            Console.Write("Person saved !");  
            Console.ReadLine();  
        }  

        // The perform database operations.
        public static void PerformDatabaseOperations()  
        {  
            using (var db = new PersonDbContext())  
            {  
                var person = new Person   
                { FirstName = "Nadege",   
                LastName = "Deroussen", BirthDate = DateTime.Now };  
                db.Persons.Add(person);  
                db.SaveChanges();  
             }  
         }  
      }
}  
````
8. Open SQL Server and look at your databases.
  - Now you have a Database named PersonDb
  - You can see you have a Person table
