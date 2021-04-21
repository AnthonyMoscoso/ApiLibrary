using BookStoreApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Dtos
{
    public class RegisterStoreDto : RegisterDto
    {
        public string IdStore { get; set; }
    }
}