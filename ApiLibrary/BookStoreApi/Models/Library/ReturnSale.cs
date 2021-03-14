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
    
    public partial class ReturnSale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReturnSale()
        {
            this.ReturnLine = new HashSet<ReturnLine>();
        }
    
        public string IdReturn { get; set; }
        public string IdSale { get; set; }
        public double Repayment { get; set; }
        public int RepaymentMethod { get; set; }
        public int RepaymentStatus { get; set; }
        public string ReturnMotive { get; set; }
        public string ReturnDescription { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnLine> ReturnLine { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual Store Store { get; set; }
        public virtual WareHouse WareHouse { get; set; }
    }
}