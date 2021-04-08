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
    
    public partial class Reservation
    {
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
        public string IdBook { get; set; }
        public int Quantity { get; set; }
        public double BookReservationPrice { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Person Person { get; set; }
        public virtual Store Store { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
