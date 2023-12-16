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
            //Custom validations for Name Field
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name", "Display Order can not be same as Name");
            }
            else if (int.TryParse(obj.Name, out int intValue))
            {
                ModelState.AddModelError("Name", "Name can not be a number");
            }
            
            //Check all validations 
            if (ModelState.IsValid) 
            { 
                //Point to SQL database to add created obj
                _db.Categories.Add(obj);
                //Add and save it to SQL database
                _db.SaveChanges();
                //Redirect to View to category Index page
                return RedirectToAction("Index");
            }

            return View();
            
        }
    }
}
