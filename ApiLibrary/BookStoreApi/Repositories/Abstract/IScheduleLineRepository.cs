using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Schedules
{
    interface IScheduleLineRepository : IRepository<ScheduleLine>
    {
        List<ScheduleLineDto> GetBySchedule(string idSchedule);
        List<ScheduleLineDto> GetBySchedule(string idSchedule,int month);
        List<ScheduleLineDto> GetBySchedule(string idSchedule, int month,int day);
    }
}
