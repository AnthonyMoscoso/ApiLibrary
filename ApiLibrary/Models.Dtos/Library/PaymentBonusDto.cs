using Core.Models.Abstracts;

namespace Models.Dtos
{
    public class PaymentBonusDto : IEntity
    {
        public string IdPaymentBonus { get; set; }
        public string BonusTittle { get; set; }
        public int BonusType { get; set; }
        public double BonusValue { get; set; }
        public string BonusDescription { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string _Id { get => IdPaymentBonus; set => IdPaymentBonus = value; }

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