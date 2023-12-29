using Microsoft.AspNetCore.Mvc;
using Bulk.DataAccess.Data;
using Bulk.Models;
using Bulk.DataAccess.Repository.IRepository;

namespace BulkProject.Areas.Admin.Controllers
{
    //User Admin role structural area
    [Area("Admin")]
    public class CategoryController : Controller
    {
        //Readonly database object variable. 
        //No object created. Already created under Program.cs / Add services (Dependency Injection)
        //private readonly ApplicationDbContext _db;
        private readonly IUnitOfWork _unitOfWork;
        //Retrive data from database to show in page
        //public CategoryController(ApplicationDbContext db) 
        //{
        //    _db = db;
        //}

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        //Action controller to show Categories DbContext as a list 
        public IActionResult Index()
        {
            //Create list of DbContext Categories to initialize with View model
            List<Category> categoryListObj = _unitOfWork.Category.GetAll().ToList();
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
                _unitOfWork.Category.Add(obj);
                //Add and save it to SQL database
                _unitOfWork.Save();
                //TempData
                TempData["success"] = "Category created successfully";
                //Redirect to View to category Index page
                return RedirectToAction("Index");
            }

            return View();

        }

        //New action method for new category edit
        public IActionResult EditCategory(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            if (id != 0)
            {
                ModelState.AddModelError("Id", "Id field can NOT change!!");
            }

            //Retrive category by Id from database to edit (Link operation)
            Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);
            //other ways to retrive category by Id from database to edit
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u => u.Id == id);
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

            //Check if corresponding retrive value is null
            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        //Invoked when posted with Edit through http
        //Create new Category Object
        [HttpPost]
        public IActionResult EditCategory(Category obj)
        {

            //Check all validations 
            if (ModelState.IsValid)
            {
                //Point to SQL database with Id to edit created obj
                _unitOfWork.Category.Update(obj);
                //Add and save it to SQL database
                _unitOfWork.Save();
                //TempData
                TempData["success"] = "Category Updated successfully";
                //Redirect to View to category Index page
                return RedirectToAction("Index");
            }

            return View();
        }


        //New action method for new category delete
        public IActionResult DeleteCategory(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Retrive category by Id from database to edit
            Category? categoryFromDb = _unitOfWork.Category.Get(u => u.Id == id);
            //other ways to retrive category by Id from database to edit
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u => u.Id == id);
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

            //Check if corresponding retrive value is null
            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        //Invoked when posted with Edit through http
        //Create new Category Object
        //ActionName will point IActionResult DeleteCategory
        [HttpPost, ActionName("DeleteCategory")]
        public IActionResult DeleteCategoryPost(int? id)
        {
            //Create new Category object
            Category? obj = _unitOfWork.Category.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            //Point to SQL database with Id to delete created obj
            _unitOfWork.Category.Remove(obj);
            //Add and save it to SQL database
            _unitOfWork.Save();
            //TempData
            TempData["success"] = "Category Deleted successfully";
            //Redirect to View to category Index page
            return RedirectToAction("Index");
        }

    }
}
