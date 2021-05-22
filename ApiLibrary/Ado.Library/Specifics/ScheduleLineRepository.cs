using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Schedules
{
    public class ScheduleLineRepository : Repository<ScheduleLine,ScheduleLineDto>, IScheduleLineRepository
    {
        public ScheduleLineRepository(string identificator="IdScheduleLine") : base(identificator)
        {
        }

        public List<ScheduleLineDto> GetBySchedule(string idSchedule)
        {
            var result = dbSet.Where(w=>w.IdSchedule.Equals(idSchedule)).ToList();
            return mapper.Map<List<ScheduleLineDto>>(result);
        }

        public List<ScheduleLineDto> GetBySchedule(string idSchedule, int month)
        {
            var result = dbSet.Where(w => w.IdSchedule.Equals(idSchedule) && w.MonthNum == month ).ToList();
            return mapper.Map<List<ScheduleLineDto>>(result);
        }

        public List<ScheduleLineDto> GetBySchedule(string idSchedule, int month, int day)
        {
            var result = dbSet.Where(w => w.IdSchedule.Equals(idSchedule) && w.MonthNum == month && w.MonthDay == day ).ToList();
            return mapper.Map<List<ScheduleLineDto>>(result);
        }
    }
}