using BookStoreApi.Models.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Request
{
    public class EmployeeRequest : PersonRequest
    {
        public string IdEmployee { get; set; }
        public string IdBoss { get; set; }
        public string IdOccupation{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public int? TypeStatus { get; set; }
        public double Discount { get; set; }

      
        public Occupation Occupation { get; set; }

    }
}