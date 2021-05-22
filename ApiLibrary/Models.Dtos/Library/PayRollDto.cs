using System.Collections.Generic;

namespace Models.Dtos
{
    public class PayRollDto
    {
        public string IdPayRoll { get; set; }
        public string IdEmployee { get; set; }
        public int YearValue { get; set; }
        public int MonthNum { get; set; }
        public double NormalHourWorkers { get; set; }
        public double ExtraHourWorkers { get; set; }
        public double PayNormalHours { get; set; }
        public double PayExtraHours { get; set; }
        public double ExtraTotal { get; set; }
        public double TotalGross { get; set; }
        public double TotalNet { get; set; }
        public int TaxesTotal { get; set; }
        public System.DateTime PayDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }

        public List<TaxesDto> Taxes { get; set; }
        public List<PaymentBonusDto> PaymentBonus { get; set; }
    }
}