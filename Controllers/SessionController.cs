using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers
{
  public class SessionController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(string name, string password)
    {
      return RedirectToAction();
    }



  }
}
