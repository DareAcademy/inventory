using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View("OrdersList");
        }
        public IActionResult Index1()
        {
            return View("OrdersAdd");
        }
    }
}
