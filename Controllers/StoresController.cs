using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class StoresController : Controller
    {
        public IActionResult Index()
        {
            return View("StoresList");
        }
        public IActionResult Index1()
        {
            return View("StoresAdd");
        }
    }
}
