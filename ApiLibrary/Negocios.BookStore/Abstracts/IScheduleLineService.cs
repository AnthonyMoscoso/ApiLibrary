using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IScheduleLineService: IServices<ScheduleLineDto>
    {
        IEnumerable<ScheduleLineDto> GetBySchedule(string idSchedule);
        IEnumerable<ScheduleLineDto> GetBySchedule(string idSchedule, int month);
        IEnumerable<ScheduleLineDto> GetBySchedule(string idSchedule, int month, int day);
    }
}
