﻿using BookStoreApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Dtos
{
    public class ReservationStoreDto : ReservationDto
    {
        public string IdStore { get; set; }
        public string IdEmployee { get; set; }
        public string IdStoreSale { get; set; }
    }
}