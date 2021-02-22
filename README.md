# Assignment1
Using Visual Studio 2019, Entity Framework

Build project using IIS Express,
If
[DirectoryNotFoundException: .. \bin\roslyn\csc.exe”. Occurs, just clean and rebuild Assignment1 solution.
Delete App_Data Folder from the solution, then right click on the Assignment1 -> Add -> Add ASP.NET Folder -> App_Data.

If EntityException: The underlying provider failed on Open, and SqlException: Cannot attach the file 'C:\...\App_Data\Assignment1.Data.AssignmentContext.mdf'
as database 'Assignment1.Data.AssignmentContext'. Occurs delete existing database.


