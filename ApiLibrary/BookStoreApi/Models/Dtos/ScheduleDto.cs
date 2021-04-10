using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Dtos
{
    public class ScheduleDto
    {
        public string IdSchedule { get; set; }
        public int YearValue { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    }
}