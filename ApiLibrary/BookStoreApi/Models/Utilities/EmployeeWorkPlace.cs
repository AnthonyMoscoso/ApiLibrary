using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class EmployeeWorkPlace
    {
        public string IdEmployee { get; set; }
        public int Type { get; set; }
        public string IdOffice { get; set; }
    }
}