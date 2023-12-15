using BulkProject.Data;
using BulkProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkProject.Controllers
{
    public class CategoryController : Controller
    {
        //Readonly database object variable. 
        //No object created. Already created under Program.cs / Add services (Dependency Injection)
        private readonly ApplicationDbContext _db;
        //Retrive data from database to show in page
        public CategoryController(ApplicationDbContext db) 
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> categoryListObj = _db.Categories.ToList();
            return View();
        }
    }
}
