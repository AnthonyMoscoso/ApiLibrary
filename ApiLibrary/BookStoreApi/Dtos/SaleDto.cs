using BookStoreApi.Models.Library;
using BookStoreApi.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class SaleDto
    {
        public string IdSale { get; set; }
        public string IdBuyer { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public int SaleStatus { get; set; }
        public int PayMethod { get; set; }
        public double TotalWithIva { get; set; }
        public double Iva { get; set; }
        public double MoneyPaid { get; set; }
        public double MoneyReturned { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public List<ReturnSale> ReturnSale { get; set; }
        public List<SaleLine> SaleLine { get; set; }
        public List<Reservation> Reservation { get; set; }
        public Coupon Coupon { get; set; }
        public PersonDto Person { get; set; }
    }
}