## Kindra Bilodeau
#### Entity Framework Step by Step
##### Code First
##### Followed Tutorial: https://www.youtube.com/watch?v=ZX7_12fwQLU
**Made by:** Programming with Mosh

1. Have Visual Studio and Sql Server Management Studio installed and running.
2. Next install entity Framework
  - Go to Tools (On the nav bar)
  - NuGet Package Manager
  - Package Manager Console
  - In the prompt type the command "install-package EntityFramework"
  - wait for to install
  - when complete it will display "Successfully installed 'EntityFramework 6.2.0' to Whatever the name of your program is"
3. Add the Using Directive:
  - using System.Data.Entity;
4. Add these two class above your Main program
``
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
    ``
5. Go to your App.config file
    - At the bottom just under the closing </entityFramework> tag
    - add connection string element;
    - Give it the same name as your dbcontext (in this case it's BlogDbContext)
    - The initial catalog is the database name (in this case it's CodeFirstDemo)  
``</entityFramework> ``    
``  <connectionStrings>  ``     
``    <add name="BlogDbContext" connectionString="data source=.\SQLEXPRESS; initial catalog=CodeFirstDemo; integrated security=SSPI" providerName="System.Data.SqlClient"/> ``  
``  </connectionStrings> ``  
``</configuration> ``  

6. Go back to package manager console
  - type in: enable-migrations
  - this command is only entered once during the entire project
  - when successful this will appear: "Code First Migrations enabled for project CodeFirstDemo.""
7. Everytime a change is made to the model you have to update the database
  - Go to package manager console
  - type in: add-migration CreatePost
  - CreatePost is just a name that you give it
  - This will create a folder in your Solution Explorer called Migrations with two files
  - The first will be your migration, it will have a datetimestamp and a description.
  - The other is a Configuration.cs file
8. Next step it to run it.
  - go back to package manager console
  - Type command: Update-Database
