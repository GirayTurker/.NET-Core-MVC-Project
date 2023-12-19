
using Bulk.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulk.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Whatever options we configure in Contractor will pass passed to the base class of DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
        {
            
        }

        //Object-Relational Mapping
        //Automatically create table for Categories in SQL database
        //Package Manager Console command update-database
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, DisplayOrder = 1, Name = "Electronics" },
                new Category { Id = 2, DisplayOrder = 2, Name = "Clothing" },
                new Category { Id = 3, DisplayOrder = 3, Name = "Food" }
                );
        }
    }
}
