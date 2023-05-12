using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers
{
  public class StorageController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
