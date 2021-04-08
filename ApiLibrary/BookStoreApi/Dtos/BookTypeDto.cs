﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class BookTypeDto
    {
        public string IdType { get; set; }
        public string IdFather { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    }
}