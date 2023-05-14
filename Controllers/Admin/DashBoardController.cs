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
    public IActionResult Details()
    {
      return View();
    }
  }
}
