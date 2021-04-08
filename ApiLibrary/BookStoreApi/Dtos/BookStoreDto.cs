using BookStoreApi.Models.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Request
{
    public class BookStoreDto
    {
        public string IdBookStore { get; set; }
        public string IdBook { get; set; }
        public string IdStore { get; set; }
        public double BookPrice { get; set; }
        public int Stock { get; set; }

    }
}