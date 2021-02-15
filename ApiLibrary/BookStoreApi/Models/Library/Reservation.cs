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
    
    public partial class Reservation : IEntidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            this.ReservationLine = new HashSet<ReservationLine>();
            
        }
    
        public string IdReservation { get; set; }
        public string IdStore { get; set; }
        public string IdEmployee { get; set; }
        public string IdBuyer { get; set; }
        public int ReservationStatus { get; set; }
        public Nullable<System.DateTime> FinishReservationDate { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Person Person { get; set; }
        public virtual Store Store { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationLine> ReservationLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public string Id { get => IdReservation; set => IdReservation=value; }
    }
}
