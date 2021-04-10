using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Request
{
    public class SocieDto : PersonDto
    {
        public double Discount { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public Nullable<System.DateTime> DesactivateDate { get; set; }
    }
}