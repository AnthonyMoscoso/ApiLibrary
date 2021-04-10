using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class ReturnSaleDto
    {
        public string IdReturn { get; set; }
        public string IdSale { get; set; }
        public double Repayment { get; set; }
        public int RepaymentMethod { get; set; }
        public int RepaymentStatus { get; set; }
        public string ReturnMotive { get; set; }
        public string ReturnDescription { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public List<ReturnLineDto> ReturnLine { get; set; }
    }
}