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

        //Action controller to show Categories DbContext as a list 
        public IActionResult Index()
        {
            //Create list of DbContext Categories to initialize with View model
            List<Category> categoryListObj = _db.Categories.ToList();
            //Pass category objects in DbContext to corresponded View model 
            return View(categoryListObj);
        }

        //New action method for new category addition
        public IActionResult CreateCategory()
        {
            return View();
        }

        //Invoked when posted with +New Category through http
        //Create new Category Object
        [HttpPost]
        public IActionResult CreateCategory(Category obj)
        {
            return View();
        }
    }
}
