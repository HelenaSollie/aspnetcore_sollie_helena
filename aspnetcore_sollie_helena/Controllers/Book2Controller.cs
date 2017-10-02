using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using aspnetcore_sollie_helena.Models;

namespace aspnetcore_sollie_helena.Controllers
{
	[Route("/books2")]
	public class BookController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			var model = new BookDetailModel();
			model.Author("Deflo");
			model.Title("Spannend");
            model.ISBN(12);
            model.CreatedOn(09/12);

			return View(model);
		}

	}
}
