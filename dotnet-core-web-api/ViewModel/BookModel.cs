using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_web_api.ViewModels
{
	public class BookModel
	{
		public int BookId { get; set; }
		public string BookTitle { get; set; }
		public string BookAuther { get; set; }
		public string BookDescription { get; set; }
	}
}
