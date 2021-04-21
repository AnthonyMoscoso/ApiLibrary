using BookStoreApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Dtos
{
    public class ReceptionOrderDto : ReceptionDto
    {
        public string IdOrder { get; set; }

        public OrderDto Orders { get; set; }
    }
}