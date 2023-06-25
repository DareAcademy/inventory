using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View("SupplierList");
        }
        public IActionResult Index1()
        {
            return View("SupplierAdd");
        }
    }
}
