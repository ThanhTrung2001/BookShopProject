using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Information()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogOut()
        {
            return View();
        }
    }
}
