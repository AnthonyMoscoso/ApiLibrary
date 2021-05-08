using BookStoreApi.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Models.Utilities
{
    public class MessageControl
    {
    
        public MessageCode Code { get; set; }
        public MessageType Type { get; set; }
        public bool Error { get; set; }
        public string Note { get; set; }

    }
}