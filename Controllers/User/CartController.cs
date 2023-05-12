using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers
{
  public class CartController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
