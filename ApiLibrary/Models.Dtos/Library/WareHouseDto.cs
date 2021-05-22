using System.Collections.Generic;

namespace Models.Dtos
{
    public class WareHouseDto
    {
        public string IdWareHouse { get; set; }
        public string IdDirection { get; set; }
        public string WareHouseName { get; set; }
        public string WareHouseDescription { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }


        public virtual List<EmployeeDto> Employee { get; set; }
    }
}