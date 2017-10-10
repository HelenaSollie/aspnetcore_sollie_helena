using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore_sollie_helena.Models
{
	public class BookListViewModel
	{
		public List<BookDetailViewModel> Books { get; set; }
		public DateTime GeneratedAt => DateTime.Now;
	}

	
}
