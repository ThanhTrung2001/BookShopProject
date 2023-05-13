using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers
{
  public class BillController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
