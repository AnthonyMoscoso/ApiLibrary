using BookStoreApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Dtos
{
    public class ReservationOnlineDto : ReservationDto
    {
        public string IdWareHouse { get; set; }
        public string IdOnlineSale { get; set; }
    }
}