using Core.Models.Abstracts;
using System;

namespace Models.Dtos
{
    public class ReservationDto : IEntity
    {
        public string IdReservation { get; set; }
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
        public byte ReservationType { get; set; }
        public string _Id { get => IdReservation; set => IdReservation = value; }
    }
}