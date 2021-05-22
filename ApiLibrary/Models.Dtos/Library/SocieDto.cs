using System;

namespace Models.Dtos
{
    public class SocieDto : PersonDto
    {
        public double Discount { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public Nullable<System.DateTime> DesactivateDate { get; set; }
    }
}