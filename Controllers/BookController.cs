using BookShopProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers
{
    public class BookController : Controller //use for Book, Author & Type
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ViewDetail(int id)
        {
            return View("~/View/Book/BookDetail.cshtml");
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
            return View();
        }

        [HttpGet]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book book)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            return View();
        }



    }
}
