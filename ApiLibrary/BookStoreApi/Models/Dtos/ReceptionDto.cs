using BookStoreApi.Models.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class ReceptionDto
    {
        public string IdReception { get; set; }
        public string IdEmployee { get; set; }
        public string IdStore { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }

        public virtual List<ReceptionLineDto> ReceptionLine { get; set; }
    }
}