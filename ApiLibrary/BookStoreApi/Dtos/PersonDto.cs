using BookStoreApi.Models.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Request
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
        public List<Sale> Reservation { get; set; }
        public List<Reservation> Sale { get; set; }

        #endregion
    }
}