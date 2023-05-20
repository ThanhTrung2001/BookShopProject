using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers.Admin
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
