using System;
using System.Collections.Generic;
using System.Linq;
namespace aspnetcore_sollie_helena.Models
{
    public class BookListViewModel
    {
        
            public List<string> Books { get; set; }
            public DateTime GeneratedAt => DateTime.Now;
        }
    }
