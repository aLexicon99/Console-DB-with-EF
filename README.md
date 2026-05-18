# Console-DB-with-EF
Console App with EntityFramework Core

### Update Database/DB Schema from stored Migration

> inside the "Package Management Console" type : 
`update-database`

>> **IF** any table classes is updated or created/added then create a new migration by typing : `Add-Migration "informative message"`





### Use the DbContext
```csharp
MyDbContext Context = new MyDbContext();
```

### Use/Assign table from DbContext with "DbSet"

```java
public DbSet<Rocket> Rockets { get; set; }
``` 


>>>Commonly used commands 

```
Add-Migration
Drop-Database
Get-DbContext
Scaffold-DbContext
Script-Migrations
Update-Database
```