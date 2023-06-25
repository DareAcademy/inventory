using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View("ProductList");
        }
        public IActionResult Index1()
        {
            return View("ProductAdd");
        }
    }
}
