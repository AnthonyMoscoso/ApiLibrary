using Models.Dtos;
using System;
using System.Collections.Generic;


namespace Models.Dtos
{
    public class PersonDto
    {
        public string IdPerson { get; set; }
        public string NamePerson { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Pass { get; set; }
        public int TypePerson { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string Dni { get; set; }

        #region Connections
        public List<SaleDto> Reservation { get; set; }
        public List<ReservationDto> Sale { get; set; }

        #endregion
    }
}