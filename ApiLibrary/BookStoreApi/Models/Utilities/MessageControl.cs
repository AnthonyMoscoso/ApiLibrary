using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Utilities
{
    public class MessageControl
    {
    
        public int Code { get; set; }
        public string Type { get; set; }
        public bool Error { get; set; }
        public string Note { get; set; }

    }
}