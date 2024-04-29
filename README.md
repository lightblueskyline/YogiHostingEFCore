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
