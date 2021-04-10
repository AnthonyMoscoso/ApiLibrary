using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class ReturnLineDto
    {
        public string IdReturnLine { get; set; }
        public string IdReturn { get; set; }
        public string IdBook { get; set; }
        public int Quantity { get; set; }
        public double BookPrice { get; set; }
        public string Note { get; set; }
    }
}