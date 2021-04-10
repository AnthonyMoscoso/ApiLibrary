using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class ReceptionLineDto
    {
        public string IdReceptionLine { get; set; }
        public string IdReception { get; set; }
        public string IdBook { get; set; }
        public int Quantity { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    }
}