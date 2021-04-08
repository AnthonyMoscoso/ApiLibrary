//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStoreApi.Models.Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class PayRoll
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PayRoll()
        {
            this.PaymentBonus = new HashSet<PaymentBonus>();
            this.Store = new HashSet<Store>();
            this.Taxes = new HashSet<Taxes>();
        }
    
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
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentBonus> PaymentBonus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store> Store { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taxes> Taxes { get; set; }
    }
}
