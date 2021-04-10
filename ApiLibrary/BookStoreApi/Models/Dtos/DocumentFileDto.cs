using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class DocumentFileDto
    {
        public string IdDocument { get; set; }
        public string DocumentDir { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string Note { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    }
}