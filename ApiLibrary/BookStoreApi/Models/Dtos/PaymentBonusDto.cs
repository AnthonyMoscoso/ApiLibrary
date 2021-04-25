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
        public override int GetHashCode()
        {
            return IdPaymentBonus.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                PaymentBonusDto x = (PaymentBonusDto)obj;
                return (IdPaymentBonus == x.IdPaymentBonus);
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}