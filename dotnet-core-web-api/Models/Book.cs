using System;
using System.Collections.Generic;

#nullable disable

namespace dotnet_core_web_api.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuther { get; set; }
        public string BookDescription { get; set; }
    }
}
