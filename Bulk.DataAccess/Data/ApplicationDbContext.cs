
using Bulk.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulk.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Whatever options we configure in Contractor will pass passed to the base class of DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options){}

        //Object-Relational Mapping
        //Automatically create table for Categories in SQL database
        //Package Manager Console command update-database
        
        //Category DBSet
        public DbSet<Category> Categories { get; set; }

        //Product DBSet
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, DisplayOrder = 1, Name = "Electronics" },
                new Category { Id = 2, DisplayOrder = 2, Name = "Clothing" },
                new Category { Id = 3, DisplayOrder = 3, Name = "Food" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product 
                { 
                    Id=1,Title="Title-1",
                    SKU="SKU-1", 
                    BrandName="Brand Name-1",
                    Description="Description-1",
                    Price = 50,
                    Price2 = 45,
                    PriceMoreThan10 = 40,
                    CategoryId=1,
                    ImageUrl="",
                },
                new Product
                {
                    Id = 2,
                    Title = "Title-2",
                    SKU = "SKU-2",
                    BrandName = "Brand Name-2",
                    Description = "Description-2",
                    Price = 5,
                    Price2 = 4.5,
                    PriceMoreThan10 = 4,
                    CategoryId = 1,
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 3,
                    Title = "Title-3",
                    SKU = "SKU-3",
                    BrandName = "Brand Name-3",
                    Description = "Description-3",
                    Price = 25,
                    Price2 = 20,
                    PriceMoreThan10 = 15,
                    CategoryId = 1,
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 4,
                    Title = "Title-4",
                    SKU = "SKU-4",
                    BrandName = "Brand Name-4",
                    Description = "Description-4",
                    Price = 75,
                    Price2 = 70,
                    PriceMoreThan10 = 65,
                    CategoryId = 1,
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 5,
                    Title = "Title-5",
                    SKU = "SKU-5",
                    BrandName = "Brand Name-5",
                    Description = "Description-5",
                    Price = 15,
                    Price2 = 10,
                    PriceMoreThan10 = 7.5,
                    CategoryId = 2,
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 6,
                    Title = "Title-6",
                    SKU = "SKU-6",
                    BrandName = "Brand Name-6",
                    Description = "Description-6",
                    Price = 150,
                    Price2 = 120,
                    PriceMoreThan10 = 99,
                    CategoryId = 2,
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 7,
                    Title = "Title-7",
                    SKU = "SKU-7",
                    BrandName = "Brand Name-7",
                    Description = "Description-7",
                    Price = 255,
                    Price2 = 230,
                    PriceMoreThan10 = 210,
                    CategoryId = 2,
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 8,
                    Title = "Title-8",
                    SKU = "SKU-8",
                    BrandName = "Brand Name-8",
                    Description = "Description-8",
                    Price = 344,
                    Price2 = 320,
                    PriceMoreThan10 = 280,
                    CategoryId = 3,
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 9,
                    Title = "Title-9",
                    SKU = "SKU-9",
                    BrandName = "Brand Name-9",
                    Description = "Description-9",
                    Price = 9,
                    Price2 = 7,
                    PriceMoreThan10 = 4,
                    CategoryId = 3,
                    ImageUrl = "",
                },
                new Product
                {
                    Id = 10,
                    Title = "Title-10",
                    SKU = "SKU-10",
                    BrandName = "Brand Name-10",
                    Description = "Description-10",
                    Price = 500,
                    Price2 = 450,
                    PriceMoreThan10 = 400,
                    CategoryId = 3,
                    ImageUrl = "",
                });
        }
    }
}
