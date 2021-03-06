﻿using Core.Models.Abstracts;
using System.Collections.Generic;

namespace Models.Dtos
{
    public class ScheduleDto : IEntity
    {
        public string IdSchedule { get; set; }
        public int YearValue { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
        public string IdEmployee { get; set; }

        public List<ScheduleLineDto> ScheduleLine { get; set; }
        public string _Id { get => IdSchedule; set => IdSchedule = value; }
    }
}