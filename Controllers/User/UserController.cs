using BookShopProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers
{
  public class UserController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    [HttpGet("{id}")]
    public IActionResult ViewDetail(int id)
    {
      return View();
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
      return View();
    }

    [HttpGet]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Book book)
    {
      return View();
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(UserAccount account)
    {
      return View();
    }
  }
}
