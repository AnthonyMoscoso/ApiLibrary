using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class DirectionDto
    {
        public string IdDirection { get; set; }
        public string Country { get; set; }
        public string Poblation { get; set; }
        public string PostalCode { get; set; }
        public string DirectionValue { get; set; }
        public string Details { get; set; }
        public string Latitude { get; set; }
        public string Lenghth { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    }
}