using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers
{
  public class SessionController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
