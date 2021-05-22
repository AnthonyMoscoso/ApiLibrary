
using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.Models.Dtos
{
    public class ReturnOnlineDto : ReturnSaleDto
    {
        public string IdWareHouse { get; set; }
    }
}