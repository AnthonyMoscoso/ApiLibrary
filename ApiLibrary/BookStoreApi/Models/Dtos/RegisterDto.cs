using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class RegisterDto
    {
        public string IdRegister { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public List<RegisterLineDto> RegisterLine { get; set; }
    }
}