using BookShopProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers
{
    public class BookController : Controller //use for Book, Author & Type
    {

        [HttpGet]
        public IActionResult IndexPage()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return RedirectToAction("Create");
        }

        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book book)
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            return View();
        }



    }
}
