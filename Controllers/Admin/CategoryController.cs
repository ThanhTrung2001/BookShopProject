using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers.Admin
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
