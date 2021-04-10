using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class TaxesDto
    {
        public string IdTaxes { get; set; }
        public string TaxTittle { get; set; }
        public string TaxDescription { get; set; }
        public int TaxType { get; set; }
        public double TaxValue { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    }
}