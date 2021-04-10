using BookStoreApi.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class StoreSaleDto : SaleDto
    {
        public string IdStore { get; set; }
        public string IdSeller { get; set; }
        public  EmployeeDto Employee { get; set; }
    }
}