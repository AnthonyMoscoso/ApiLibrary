using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{ 
     public interface IScheduleLineRepository : IRepository<ScheduleLine>
    {
        IEnumerable<ScheduleLine> GetBySchedule(string idSchedule);
        IEnumerable<ScheduleLine> GetBySchedule(string idSchedule,int month);
        IEnumerable<ScheduleLine> GetBySchedule(string idSchedule, int month,int day);
    }
}
