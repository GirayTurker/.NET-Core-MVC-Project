using Microsoft.AspNetCore.Mvc;
using Bulk.DataAccess.Data;
using Bulk.Models;
using Bulk.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BulkProject.Areas.Admin.Controllers
{
    //User Admin role structural area
    [Area("Admin")]
    public class ProductController : Controller
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

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        //Action controller to show Categories DbContext as a list 
        public IActionResult Index()
        {
            //Create list of DbContext Categories to initialize with View model
            List<Product> ProductListObj = _unitOfWork.Product.GetAll().ToList();
            
            //Projection object variable in another object view 
            //Press F12 while SelectListItem highlighted to see all List Items
            IEnumerable<SelectListItem>CategoryList = _unitOfWork.Category.GetAll().Select(u=> new SelectListItem
            {
              Text =u.Name,
              Value=u.Id.ToString(),
            });

            //Pass product objects in DbContext to corresponded View model 
            return View(ProductListObj);
        }

        //New action method for new category addition
        public IActionResult CreateProduct()
        {
            return View();
        }

        //Invoked when posted with +New Category through http
        //Create new Category Object
        [HttpPost]
        public IActionResult CreateProduct(Product obj)
        {
            //Custom validations for Name Field
            //if (obj.Name == obj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("Name", "Display Order can not be same as Name");
            //}
            //else if (int.TryParse(obj.Name, out int intValue))
            //{
            //    ModelState.AddModelError("Name", "Name can not be a number");
            //}

            //Check all validations 
            if (ModelState.IsValid)
            {
                //Point to SQL database to add created obj
                _unitOfWork.Product.Add(obj);
                //Add and save it to SQL database
                _unitOfWork.Save();
                //TempData
                TempData["success"] = "Product created successfully";
                //Redirect to View to category Index page
                return RedirectToAction("Index");
            }

            return View();

        }

        //New action method for new category edit
        public IActionResult EditProduct(int? id)
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
            Product? productFromDb = _unitOfWork.Product.Get(u => u.Id == id);
            //other ways to retrive category by Id from database to edit
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u => u.Id == id);
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

            //Check if corresponding retrive value is null
            if (productFromDb == null)
            {
                return NotFound();
            }

            return View(productFromDb);
        }

        //Invoked when posted with Edit through http
        //Create new Category Object
        [HttpPost]
        public IActionResult EditCategory(Product obj)
        {

            //Check all validations 
            if (ModelState.IsValid)
            {
                //Point to SQL database with Id to edit created obj
                _unitOfWork.Product.Update(obj);
                //Add and save it to SQL database
                _unitOfWork.Save();
                //TempData
                TempData["success"] = "Product Updated successfully";
                //Redirect to View to category Index page
                return RedirectToAction("Index");
            }

            return View();
        }


        //New action method for new category delete
        public IActionResult DeleteProduct(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Retrive category by Id from database to edit
            Product? productFromDb = _unitOfWork.Product.Get(u => u.Id == id);
            //other ways to retrive category by Id from database to edit
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u => u.Id == id);
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

            //Check if corresponding retrive value is null
            if (productFromDb == null)
            {
                return NotFound();
            }

            return View(productFromDb);
        }

        //Invoked when posted with Edit through http
        //Create new Category Object
        //ActionName will point IActionResult DeleteCategory
        [HttpPost, ActionName("DeleteProduct")]
        public IActionResult DeleteProductPost(int? id)
        {
            //Create new Category object
            Product? obj = _unitOfWork.Product.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            //Point to SQL database with Id to delete created obj
            _unitOfWork.Product.Remove(obj);
            //Add and save it to SQL database
            _unitOfWork.Save();
            //TempData
            TempData["success"] = "Product Deleted successfully";
            //Redirect to View to category Index page
            return RedirectToAction("Index");
        }

    }
}
