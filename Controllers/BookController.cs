﻿using Microsoft.AspNetCore.Mvc;

namespace BookShopProject.Controllers
{
  public class BookController : Controller //use for Book, Author & Type
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
