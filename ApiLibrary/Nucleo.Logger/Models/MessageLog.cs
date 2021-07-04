﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Logger.Models
{
    public class MessageLog
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }

    }
}