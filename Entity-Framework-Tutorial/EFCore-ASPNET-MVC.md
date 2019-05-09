## Kindra Bilodeau
#### ASP.NET Entity Framework Core - Code First Tutuorial
##### Followed this tutorial: https://www.c-sharpcorner.com/article/code-first-approach-in-asp-net-core-mvc-with-ef-core-migration/

1. Have Visual Studio and SQL Server installed and running
2. Open a new project in Visual Studio > select ASP.NET Core Web Application > Name it **CodeFirstMigration**
3. On the next screen
  - At the top in the drop down bars make sure: **.NET Core** and **ASP.NET Core 2.2** is selected.
  - Select **Web Application(Model-View-Controller)**
  - Make sure authentication is set to **No Authentication**
  - Click **OK**
4. On the navigation bar go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution
  - On the Browse tab search and install:  
    - **Microsoft.EntityFrameworkCore.SqlServer** v.2.2.4.
    - **Microsoft.EntityFrameworkCore.Tools**  v.2.2.4
5. Right Click on the project (CodeFirstMigration)
  - Add a new Folder name it **Context**
  - Add a class to the Context folder name it: **Employee**
  - Add this Code:
````C#
 namespace CodeFirstMigration.Context
{
      public class Employee
        {
          public int EmployeeId { get; set; }
          public string Name { get; set; }
          public string Address { get; set; }
          public string CompanyName { get; set; }
          public string Designation { get; set; }
        }
}
````

  - Add another class to the Context folder name it: **EmployeeDbContext**
  - Add this code:   
````C#
  using Microsoft.EntityFrameworkCore;  

  namespace CodeFirstMigration.Context  
  {  
      public class EmployeeDbContext : DbContext  
      {  
          public EmployeeDbContext(DbContextOptions options) : base(options)  
          {  
          }  

          DbSet<Employee> Employees { get; set; }  
      }  
  }
````
6. Go the appsetting.json file, and add this code:
````C#
  {  
    "Logging": {  
      "IncludeScopes": false,  
      "LogLevel": {  
        "Default": "Warning"  
      }  
    },  
    "ConnectionStrings": {  
      "myconn": "server=.; database=EmployeeDB;Trusted_Connection=True;"  
    }  
  }  
````
7. Go to the Startup.cs file:
  - Add these using directives:   
  ``using CodeFirstMigration.Context;``  
  ``using Microsoft.EntityFrameworkCore;``
  - Find the ConfigureServices method. And modify it so it looks like this:
````C#
public void ConfigureServices(IServiceCollection services)  
{  
    services.AddMvc();  
    services.AddDbContext<EmployeeDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("myconn")));  
}  
````
8. Go to Tools > NuGet Package Manager > Package Manager Console
  - In the prompt type in: **add-migration firstmigration**
  - If successful you will see a Migrations folder added to your project.
9. To add this to SQL Server
  - In the Package Manager Console:
    - type **update-database firstmigration**
10.  Go to SQL Server and refresh your Databases and will see that you now a database name EmployeeDb with a table that is named Employees.
