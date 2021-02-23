using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Schedules;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Schedules
{
    public class ScheduleLineRepositorie : Repositorie<ScheduleLine>, IScheduleLineRepositorie
    {
        public ScheduleLineRepositorie(string identificator="IdScheduleLine") : base(identificator)
        {
        }
    }
}