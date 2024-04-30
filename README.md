# [EF Core](https://www.yogihosting.com/category/ef-core/)

## GIT 倉庫建立指令

```bash
git init
git add README.md
git commit -m "first commit"
# git branch -M main
git remote add origin https://github.com/lightblueskyline/YogiHostingEFCore.git
git push -u origin master
```

## [EF Core - Introduction](https://www.yogihosting.com/introduction-entity-framework-core/)

[DbContext Class in Entity Framework Core](https://www.yogihosting.com/dbcontext-entity-framework-core/)  
[Migrations](https://www.yogihosting.com/migrations-entity-framework-core/)  
[EF Core – Installation](https://www.yogihosting.com/install-entity-framework-core/)  
[Xaero – Entity Framework Core Advanced Project](https://www.yogihosting.com/xaero-project-entity-framework-core/)

## [EF Core - Installation](https://www.yogihosting.com/install-entity-framework-core/)

```csharp
/**
Install EF Core Provider
NuGet: Microsoft.EntityFrameworkCore.Sqlite

Install Entity Framework Core Tools
-> dotnet ef
dotnet tool install --global dotnet-ef 更新 dotnet tool update --global dotnet-ef
NuGet: Microsoft.EntityFrameworkCore.Design
 */
```

[Learn ADO.NET by building CRUD features in ASP.NET Core Application](https://www.yogihosting.com/ado-net-aspnet-core/)

## [EF Core - Database First](https://www.yogihosting.com/database-first-approach-entity-framework-core/)

```csharp
/**
// 通過數據庫搭建
dotnet ef dbcontext scaffold "Server=vaio;Database=Company;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models
 */
```

[Calling ASP.NET Core Web APIs with JavaScript and performing CRUD operations](https://www.yogihosting.com/aspnet-core-web-api-javascript/)  
[Installation of Entity Framework Core](https://www.yogihosting.com/install-entity-framework-core/)  
[Xaero – Entity Framework Core Advanced Project](https://www.yogihosting.com/xaero-project-entity-framework-core/)

## [EF Core - DbContext Class](https://www.yogihosting.com/dbcontext-entity-framework-core/)

```csharp
/**
dotnet ef migrations add Migration1
dotnet ef database update
 */
```

[Installation of Entity Framework Core](https://www.yogihosting.com/install-entity-framework-core/)  
[Conventions in Entity Framework Core](https://www.yogihosting.com/conventions-entity-framework-core/)  
[Fluent API in Entity Framework Core](https://www.yogihosting.com/fluent-api-entity-framework-core/)  
[Migrations in Entity Framework Core](https://www.yogihosting.com/migrations-entity-framework-core/)  
[Insert Records in Entity Framework Core](https://www.yogihosting.com/insert-records-entity-framework-core/)

## [EF Core - Code First Approach](https://www.yogihosting.com/code-first-entity-framework-core/)

```csharp
/**
dotnet ef migrations add AddInformation
dotnet ef database update
dotnet ef database drop
 */
```

[EDMX](https://www.yogihosting.com/entity-framework-create-edmx-file/)  
[Install Entity Framework Core](https://www.yogihosting.com/install-entity-framework-core/)  
[Database Context (DbContext)](https://www.yogihosting.com/dbcontext-entity-framework-core/)  
[EF Core Migrations](https://www.yogihosting.com/migrations-entity-framework-core/)

## [EF Core - Migrations](https://www.yogihosting.com/migrations-entity-framework-core/)

```csharp
/**
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef
dotnet ef migrations add Migration1
dotnet ef database update
dotnet ef migrations add Migration1 --context EmployeeContext
dotnet ef database update --context EmployeeDbContext
dotnet ef migrations remove
dotnet ef database drop
// Generate SQL Script
dotnet ef migrations script
 */
```

[Entity Framework Core tools reference - .NET Core CLI](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)  
[Installation of Entity Framework Core](https://www.yogihosting.com/install-entity-framework-core/)  
[Execute SQL Stored Procedures using FromSqlRaw() & ExecuteSqlRawAsync() methods in Entity Framework Core](https://www.yogihosting.com/stored-procedures-entity-framework-core/)

## [EF Core - Insert Records](https://www.yogihosting.com/insert-records-entity-framework-core/)

[How to call Web API from JavaScript](https://www.yogihosting.com/aspnet-core-web-api-javascript/)

## [EF Core - Read Records](https://www.yogihosting.com/read-records-entity-framework-core/)

```csharp
/**
Lazy Loading in EF Core 需要安裝包：
Microsoft.EntityFrameworkCore.Proxies
 */
```

[Read Records using ADO.NET in ASP.NET Core Application](https://www.yogihosting.com/read-records-ado-net-aspnet-core/)  
[Create Number Paging with Custom Tag Helper in ASP.NET Core](https://www.yogihosting.com/aspnet-core-paging/)

## [EF Core - Update Records](https://www.yogihosting.com/update-records-entity-framework-core/)

[Update Records using ADO.NET in ASP.NET Core Application](https://www.yogihosting.com/update-records-ado-net-aspnet-core/)  
[Advanced Model Binding Concepts in ASP.NET Core](https://www.yogihosting.com/aspnet-core-advanced-model-binding/)  
[Read Records in Entity Framework Core](https://www.yogihosting.com/read-records-entity-framework-core/)  
[TryUpdateModelAsync](https://www.yogihosting.com/insert-records-entity-framework-core/#modelupdate)

## [EF Core - Delete Records](https://www.yogihosting.com/delete-records-entity-framework-core/)

[Configurations in Entity Framework Core](https://www.yogihosting.com/configurations-entity-framework-core/)  
[Fluent API of Entity Framework Core](https://www.yogihosting.com/fluent-api-entity-framework-core/)  
[Update Records in Entity Framework Core](https://www.yogihosting.com/update-records-entity-framework-core/)

## [EF Core - Conventions](https://www.yogihosting.com/conventions-entity-framework-core/)

[Configure One-to-Many relationship using Fluent API in Entity Framework Core](https://www.yogihosting.com/fluent-api-one-to-many-relationship-entity-framework-core/)  
[EF Core Migrations](https://www.yogihosting.com/conventions-entity-framework-core/)  
[Configure Many-to-Many relationship using Fluent API in Entity Framework Core](https://www.yogihosting.com/fluent-api-many-to-many-relationship-entity-framework-core/)

## [EF Core - Configurations](https://www.yogihosting.com/configurations-entity-framework-core/)

[Conventions in Entity Framework Core](https://www.yogihosting.com/conventions-entity-framework-core/)  
[Model Validation in ASP.NET Core from Beginning to Expert](https://www.yogihosting.com/aspnet-core-model-validation/)
