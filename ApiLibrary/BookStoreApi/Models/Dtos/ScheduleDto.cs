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
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string IdEmployee { get; set; }

        public List<ScheduleLineDto> ScheduleLine { get; set; }
    }
}