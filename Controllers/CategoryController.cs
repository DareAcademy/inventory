using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View("CategoryList");
        }
        public IActionResult Index1()
        {
            return View("CategoryAdd");
        }
    }
}
