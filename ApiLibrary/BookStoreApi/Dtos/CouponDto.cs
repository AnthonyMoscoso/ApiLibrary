using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class CouponDto
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
    }
}