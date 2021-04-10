using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class PaymentBonusDto
    {
        public string IdPaymentBonus { get; set; }
        public string BonusTittle { get; set; }
        public int BonusType { get; set; }
        public double BonusValue { get; set; }
        public string BonusDescription { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    }
}