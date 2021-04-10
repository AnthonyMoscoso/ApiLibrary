using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class WareHouseBookDto
    {
        public string IdWareHouseBook { get; set; }
        public string IdWareHouse { get; set; }
        public string IdBook { get; set; }
        public int Stock { get; set; }
    }
}