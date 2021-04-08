using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Request
{
    public class EmployeeDto : PersonDto
    {
        #region Atributes 
        public string IdBoss { get; set; }
        public string IdOccupation{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public int? TypeStatus { get; set; }
        public double Discount { get; set; }
        #endregion


        public OccupationDto Occupation { get; set; }

        #region Methods
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                PersonDto x = (PersonDto)obj;
                return (IdPerson == x.IdPerson);
            }
        }
        public override int GetHashCode()
        {
            return IdPerson.GetHashCode();
        }
        #endregion
    }
}