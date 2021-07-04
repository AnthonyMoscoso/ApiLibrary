using Core.Models.Abstracts;
using System;
using System.Collections.Generic;

namespace Models.Dtos
{
    public class SaleDto : IEntity
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
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public List<ReturnSaleDto> ReturnSale { get; set; }
        public List<SaleLineDto> SaleLine { get; set; }
        public List<ReservationDto> Reservation { get; set; }
        public CouponDto Coupon { get; set; }
        public string _Id { get => IdSale; set => IdSale = value; }
    }
}