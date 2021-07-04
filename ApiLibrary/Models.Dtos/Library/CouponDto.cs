using Core.Models.Abstracts;
using System;

namespace Models.Dtos
{
    public class CouponDto : IEntity
    {
        public string IdCoupon { get; set; }
        public string CouponCode { get; set; }
        public DateTime StartOffert { get; set; }
        public DateTime? FinishOffert { get; set; }
        public int TypeCoupon { get; set; }
        public double CouponValue { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string _Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}