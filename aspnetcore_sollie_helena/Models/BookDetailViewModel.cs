using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore_sollie_helena.Models
{
	public class BookDetailViewModel
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public string ISBN { get; set; }
		public DateTime CreationDate { get; set; }
	}
}
