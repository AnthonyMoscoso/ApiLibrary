using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;


namespace Ado.Library.Specifics
{
    public class ScheduleRepository : AdoRepository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(BookStoreEntities context,  string identificator = "IdSchedule") : base(context, identificator)
        {
        }

        public IEnumerable<Schedule> GetByEmployee(string idEmployee)
        {
             IEnumerable<Schedule> result = dbSet.Where(w => w.Employee.IdPerson.Equals(idEmployee));
            return (result);
        }

        public IEnumerable<Schedule> GetByEmployee(string idEmployee, int year)
        {
             IEnumerable<Schedule> result = dbSet.Where(w => w.Employee.IdPerson.Equals(idEmployee) && w.YearValue==year);
            return (result);
        }

      

        public new dynamic Delete(IEnumerable<string> ids)
        {
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search!=null)
                {
                    if (search.ScheduleLine.Count>0)
                    {

                    }
                    else
                    {

                    }
                }
            }
            return null;
        }

        public IEnumerable<Schedule> GetByEmployee(string idEmployee, int year, int month)
        {
            List<Schedule> result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year).ToList();
            result.ForEach(x => x.ScheduleLine = x.ScheduleLine.Where(s => s.MonthNum == month && s.IdSchedule.Equals(x.IdSchedule)).ToList());
            return (result);
        }

        public IEnumerable<Schedule> GetByEmployee(string idEmployee, int year, int month, int day)
        {
            List<Schedule>  result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year).ToList();
            result.ForEach(x => x.ScheduleLine = x.ScheduleLine.Where(s => s.MonthNum == month && s.IdSchedule.Equals(x.IdSchedule) && s.MonthDay==day).ToList());
            return (result);
        }
    }
}