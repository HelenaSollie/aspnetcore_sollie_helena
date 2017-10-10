using Microsoft.AspNetCore.Mvc;
using System;
using Bibliotheek.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

			model.Books = new List<BookDetailViewModel>();
			model.Books.Add(new BookDetailViewModel() { Author = "Deflo", CreationDate = DateTime.Now, ISBN = "isbn 1", Title = "abc" });
			model.Books.Add(new BookDetailViewModel() { Author = "Bracke", CreationDate = DateTime.Now, ISBN = "isbn 2", Title = "def" });
			model.Books.Add(new BookDetailViewModel() { Author = "Mansell", CreationDate = DateTime.Now, ISBN = "isbn 3", Title = "ghi" });
			model.Books.Add(new BookDetailViewModel() { Author = "Murphy", CreationDate = DateTime.Now, ISBN = "isbn 4", Title = "jkl" });
			model.Books.Add(new BookDetailViewModel() { Author = "Janssens", CreationDate = DateTime.Now, ISBN = "isbn 3", Title = "mno" });
			model.Books.Add(new BookDetailViewModel() { Author = "Aspe", CreationDate = DateTime.Now, ISBN = "isbn 4", Title = "pqr" });

            return View(model);
        }

		[HttpGet("/books/{id}")]
		public IActionResult Detail([FromRoute]int id)
		{
			return View();
			var bookDetailViewModel = new BookDetailViewModel();
			bookDetailViewModel.Author = "author " + id;
			bookDetailViewModel.ISBN = "isbn" + id;
			bookDetailViewModel.Title = "title" + id;

			return View(bookDetailViewModel);
		}
	} }
