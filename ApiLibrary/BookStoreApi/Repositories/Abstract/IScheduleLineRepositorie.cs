using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Schedules
{
    interface IScheduleLineRepositorie : IRepository<ScheduleLine>
    {
        List<ScheduleLine> GetBySchedule(string idSchedule);
        List<ScheduleLine> GetBySchedule(string idSchedule,int month);
    }
}
