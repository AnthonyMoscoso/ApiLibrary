using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{ 
     public interface IScheduleLineRepository : IRepository<ScheduleLine>
    {
        List<ScheduleLineDto> GetBySchedule(string idSchedule);
        List<ScheduleLineDto> GetBySchedule(string idSchedule,int month);
        List<ScheduleLineDto> GetBySchedule(string idSchedule, int month,int day);
    }
}
