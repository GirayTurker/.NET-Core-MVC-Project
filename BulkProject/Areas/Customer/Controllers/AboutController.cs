using Microsoft.AspNetCore.Mvc;

namespace BulkProject.Areas.Customer.Controllers
{
    public class AboutController : Controller
    {
        //User Customer role structural area
        [Area("Customer")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
