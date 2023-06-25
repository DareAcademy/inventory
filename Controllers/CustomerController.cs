using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View("CustomerList");
        }
        public IActionResult Index1()
        {
            return View("CustomerAdd");
        }
    }
}
