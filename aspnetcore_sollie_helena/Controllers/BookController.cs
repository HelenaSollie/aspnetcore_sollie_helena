using Microsoft.AspNetCore.Mvc;
using System;
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
			model.Books = new List<BookDetailModel>();
            model.Books.Add(new BookDetailModel
			{
				Author = "Deflo",
				Title = "Angst",
				ISBN = " --- ",
				CreatedOn = new DateTime(2016, 06, 05),
			});
			
            model.Books.Add(new BookDetailModel
			{
				Author = "Jill Mansel",
				Title = "Verliefd",
				ISBN = "---",
				CreatedOn = new DateTime(2008, 10, 10),
			});

			model.Books.Add(new BookDetailModel
			{
				Author = "John Green",
				Title = "The Fault in Our Stars",
				ISBN = "---",
				CreatedOn = new DateTime(2002, 12, 12),
			});

			return View(model);

		}
	} }
