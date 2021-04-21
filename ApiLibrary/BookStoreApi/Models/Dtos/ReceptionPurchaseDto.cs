using BookStoreApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Dtos
{
    public class ReceptionPurchaseDto : ReceptionDto
    {
        public string IdPurchase { get; set; }
    }
}