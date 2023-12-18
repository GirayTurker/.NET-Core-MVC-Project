# =========== BULKPROJECT ===========

# Project Abstract
 This document describes a proposal of BulkProject, a local based .NET application for e-commerce purpose. User-defined structre is Admin or Subscriber. Admin 
 privileges are Add, Change or Delete Product Category Name and Category Display Order. Sucscriber privileges are Create account, view Products and pruchase. 

# Feature Implementations
 Short-Term implementations: BulkProject will migrate from local to web base. Product details, purchase chart and payment section will be develop.

# Architectural Design 

<a href="https://learn.microsoft.com/en-us/azure/architecture/guide/architecture-styles/n-tier" target="_blank">N-Tier architecture</a>

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
 - Latest Version <a href="https://github.com/GirayTurker/BulkMVCProject/tree/v-1.2.0" target="_blank">v-1.2.0</a>

 # How to Run Version: v-1.2.0

  - Create new database with Microsoft SQL Server Management Studio
  - Change necessary fields at <a href="https://github.com/GirayTurker/BulkMVCProject/blob/master/BulkProject/appsettings.json" target="_blank">appsettings.json</a>
  - Remove <a href="https://github.com/GirayTurker/BulkMVCProject/tree/master/BulkProject/Migrations">Migration Folder</a>. User should generate own migration folder.
  - Open NuGet Package Manager Console, SELECT Default Project:Bulk.DataAccess and write "update-database" on console. On this step databse table should created and      visible in SQL serer manager, otherwise check for error message on console.
  - NuGet Package Manager Console write "add-migration _____" ( ___ reference name of the migration. in this context, it can be anything).
  - NuGet Package Manager Console write "update-database".
  - Migration folder should created. Seeded data on <a href="https://github.com/GirayTurker/BulkMVCProject/blob/master/BulkProject/Data/ApplicationDbContext.cs"          target="_blank">ApplicationDbContext.cs</a> at OnModelCreating function will be visible in SQL server database.
