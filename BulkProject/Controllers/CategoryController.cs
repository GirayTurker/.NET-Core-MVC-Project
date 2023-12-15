using Microsoft.AspNetCore.Mvc;

namespace BulkProject.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
