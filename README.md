# Assignment1
Using Visual Studio 2019, Entity Framework

In AssignmentContext.cs there's a constructor which inherits from base construktor for the context and it takes in key in the parameter for the connection string which is in web.config, and in this way it connects. DataSource is an instance of sql server and initialCalalog is a name for the database on this server.


Build project using IIS Express,
If
[DirectoryNotFoundException: .. \bin\roslyn\csc.exe”. Occurs, just clean and rebuild Assignment1 solution.
iF
Delete App_Data Folder from the solution, then right click on the Assignment1 -> Add -> Add ASP.NET Folder -> App_Data.

If EntityException: The underlying provider failed on Open, and SqlException: Cannot attach the file 'C:\...\App_Data\Assignment1.Data.AssignmentContext.mdf'
as database 'Assignment1.Data.AssignmentContext'. Occurs delete existing database.


