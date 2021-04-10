using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class ReservationDto
    {
        public string IdReservation { get; set; }
        public string IdStore { get; set; }
        public string IdEmployee { get; set; }
        public string IdBuyer { get; set; }
        public int ReservationStatus { get; set; }
        public DateTime? FinishReservationDate { get; set; }
        public string Note { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string IdBook { get; set; }
        public int Quantity { get; set; }
        public double BookReservationPrice { get; set; }
    }
}