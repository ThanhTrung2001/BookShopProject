using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers
{
  public class UserController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
