using BookStoreApi.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class RegisterLineDto
    {
        public string IdRegisterLine { get; set; }
        public string IdRegister { get; set; }
        public string IdEmployee { get; set; }
        public Nullable<System.TimeSpan> EnterHour { get; set; }
        public Nullable<System.TimeSpan> ExitHour { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }

    }
}