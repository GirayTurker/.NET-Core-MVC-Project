# =========== BULKPROJECT ===========

# Project Abstract
 This document describes a proposal of BulkProject, a local based .NET application for e-commerce purpose. User-defined structre is Admin or Subscriber. Admin 
 privileges are Add, Change or Delete Product Category Name and Category Display Order. Sucscriber privileges are Create account, view Products and pruchase. 

# Feature Implementations

 - Short-Term: Product details, purchase chart and payment section will be develop. Test cases for individual components and CI/CD pipelines will    develope and add in related repositories.
 - Long-Term implementations: BulkProject will migrate from local to web base.
  

# Architectural Design 

<a href="https://learn.microsoft.com/en-us/azure/architecture/guide/architecture-styles/n-tier" target="_blank">N-Tier architecture</a>

# Design Patterns

<a href="https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application#the-repository-and-unit-of-work-patterns" target="_blank">Repository Pattern</a>

# Dependencies

 Framework
  - .NET 8.0
 
 Packages
  - Microsoft AspNetCore V="2.22.0"
  - Microsoft EntityFrameworkCore "V=8.0.0"

# Requirements

 Enviromental Requirements
   - IDE supports .NET 8.0 Framework
   - Microsoft SQL Server Management Studio
  
 # Properties
    
 Launch
   - http://localhost:5064
   - https://localhost:7169 https://localhost:5190
   - IIS Express


 Version
 - Latest Version: <a href="https://github.com/GirayTurker/BulkMVCProject/tree/v-1.2.1" target="_blank">v-1.2.1</a>

 # How to Run Version: All versions

 Local Environment
  - Download the project
  - Create new database with Microsoft SQL Server Management Studio
  - Change necessary fields at <a href="https://github.com/GirayTurker/BulkMVCProject/blob/master/BulkProject/appsettings.json" target="_blank">appsettings.json</a>
  - Open NuGet Package Manager Console, SELECT Default Project:Bulk.DataAccess and write "update-database" on console. On this step databse table should created and      visible in SQL serer manager, otherwise check for error message on console.

  - NuGet Package Manager Console write "add-migration _____" ( ___ reference name of the migration. in this context, it can be anything).
  - NuGet Package Manager Console write "update-database".
  - Migration folder should created. Seeded data on <a href="https://github.com/GirayTurker/BulkMVCProject/blob/master/BulkProject/Data/ApplicationDbContext.cs"          target="_blank">ApplicationDbContext.cs</a> at OnModelCreating function will be visible in SQL server database.
 
 GitHub Codespace Environment
  - Open project in Codespace (<a href="https://docs.github.com/en/codespaces/developing-in-a-codespace/opening-an-existing-codespace" target="_blank">Click How</a>) 
  - From terminal window, write: "cd ./BulkProject" than, "dotnet run" (Category page is not visible due to implementation database to GitHub) 
=======
 
# Versions

-  <a href="https://github.com/GirayTurker/BulkMVCProject/tree/v-1.1.0" target="_blank">v-1.1.1</a>
-  <a href="https://github.com/GirayTurker/BulkMVCProject/tree/v-1.2.0" target="_blank">v-1.2.0</a>
-  <a href="https://github.com/GirayTurker/BulkMVCProject/tree/v-1.2.1" target="_blank">v-1.2.1</a>


# Updates

12/28/2023
- Product Model: New Product Model created with its components for Admin Area, New database and table created, Data migration completed.

1/04/2024
- Start to develop ViewModels. Create Product ViewModel is developed.


