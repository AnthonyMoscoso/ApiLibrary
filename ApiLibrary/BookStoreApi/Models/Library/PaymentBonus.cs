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
    using LibraryApiRest.Models.Abstract;
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentBonus : IEntidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentBonus()
        {
            this.Employee = new HashSet<Employee>();
            this.Occupation = new HashSet<Occupation>();
            this.PayRoll = new HashSet<PayRoll>();
        }
    
        public string IdPaymentBonus { get; set; }
        public string BonusTittle { get; set; }
        public int BonusType { get; set; }
        public double BonusValue { get; set; }
        public string BonusDescription { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Occupation> Occupation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayRoll> PayRoll { get; set; }
        public string Id { get => IdPaymentBonus; set => IdPaymentBonus=value; }
    }
}
