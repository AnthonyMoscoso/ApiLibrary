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
    
    public partial class ReservationStore
    {
        public string IdReservation { get; set; }
        public string IdStore { get; set; }
        public string IdEmployee { get; set; }
        public string IdStoreSale { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual Store Store { get; set; }
        public virtual StoreSale StoreSale { get; set; }
    }
}
