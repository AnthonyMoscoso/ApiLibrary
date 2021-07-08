using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;


namespace Ado.Library.Specifics
{
    public class ScheduleLineRepository : AdoRepository<ScheduleLine>, IScheduleLineRepository
    {
        public ScheduleLineRepository(BookStoreEntities context, string identificator="IdScheduleLine") : base(context,identificator)
        {
        }

        public IEnumerable<ScheduleLine> GetBySchedule(string idSchedule)
        {
            var result = dbSet.Where(w=>w.IdSchedule.Equals(idSchedule)).ToList();
            return (result);
        }

        public IEnumerable<ScheduleLine> GetBySchedule(string idSchedule, int month)
        {
            var result = dbSet.Where(w => w.IdSchedule.Equals(idSchedule) && w.MonthNum == month ).ToList();
            return (result);
        }

        public IEnumerable<ScheduleLine> GetBySchedule(string idSchedule, int month, int day)
        {
            var result = dbSet.Where(w => w.IdSchedule.Equals(idSchedule) && w.MonthNum == month && w.MonthDay == day ).ToList();
            return (result);
        }
    }
}