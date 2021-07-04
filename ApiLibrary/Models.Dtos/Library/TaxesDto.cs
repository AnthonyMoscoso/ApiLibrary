using Core.Models.Abstracts;

namespace Models.Dtos
{
    public class TaxesDto : IEntity
    {
        public string IdTaxes { get; set; }
        public string TaxTittle { get; set; }
        public string TaxDescription { get; set; }
        public int TaxType { get; set; }
        public double TaxValue { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string _Id { get => IdTaxes; set => IdTaxes = value; }

        public override int GetHashCode()
        {
            return IdTaxes.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                TaxesDto x = (TaxesDto)obj;
                return (IdTaxes == x.IdTaxes);
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}