using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class RolDto
    {
        public string IdRol { get; set; }
        public string RolName { get; set; }
        public string RolDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    }
}