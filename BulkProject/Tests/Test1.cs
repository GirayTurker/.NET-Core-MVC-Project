using Microsoft.AspNetCore.Mvc;
using BulkProject.Data;
using BulkProject.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using BulkProject.Controllers;
using System.Linq;

namespace BulkProject.Tests
{
    [TestClass]
    public class Test1
    {
        public void CategoryController()
        {
            /*
            var dbContextCatCont = new CatCont<ApplicationDbContext>();
            var controller = new CategoryController(dbContextCatCont.Object);


            var categories = new List<Category>()
            { 
                new Category { Id = 1, Name = "Category 1"},
                new Category { Id = 2, Name = "Category 2" },
            }.AsQueryable();


            var dbSetMock = new Mock<DbSet<Category>>();
            dbSetMock.As<IQueryable<Category>>().Setup(m => m.Provider).Returns(categories.Provider);
            dbSetMock.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(categories.Expression);
            dbSetMock.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(categories.ElementType);
            dbSetMock.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(() => categories.GetEnumerator());

            dbContextCatCont.Setup(d => d.Categories).Returns(dbSetMock.Object);
            */


        }


    }
}
