using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Request
{
    public class SocieRequest : PersonRequest
    {
        public string IdSocie { get; set; }
        public double Discount { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime? DesactivateDate { get; set; }
    }
}