using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers
{
  public class OrderController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
