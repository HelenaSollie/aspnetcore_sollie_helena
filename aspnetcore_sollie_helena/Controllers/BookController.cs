using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using aspnetcore_sollie_helena.Models;

namespace aspnetcore_sollie_helena.Controllers
{
    [Route("/books")]
    public class BookController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new BookListViewModel();
            model.Books = new List<string>();
            model.Books.Add("book 1");
            model.Books.Add("book 2");
            return View(model);
        }
       
    }
}
