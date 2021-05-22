using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Schedules
{
    public class ScheduleRepository : Repository<Schedule,ScheduleDto>, IScheduleRepository
    {
        public ScheduleRepository(string identificator="IdSchedule") : base(identificator)
        {
        }

        public List<ScheduleDto> GetByEmployee(string idEmployee)
        {
            var result = dbSet.Where(w => w.Employee.IdPerson.Equals(idEmployee)).ToList();
            return mapper.Map<List<ScheduleDto>>(result);
        }

        public List<ScheduleDto> GetByEmployee(string idEmployee, int year)
        {
            var result = dbSet.Where(w => w.Employee.IdPerson.Equals(idEmployee) && w.YearValue==year).ToList();
            return mapper.Map<List<ScheduleDto>>(result);
        }

      

        public new dynamic Delete(List<string> ids)
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

        public List<ScheduleDto> GetByEmployee(string idEmployee, int year, int month)
        {
            var result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year).ToList();
            result.ForEach(x => x.ScheduleLine = x.ScheduleLine.Where(s => s.MonthNum == month && s.IdSchedule.Equals(x.IdSchedule)).ToList());
            return mapper.Map<List<ScheduleDto>>(result);
        }

        public List<ScheduleDto> GetByEmployee(string idEmployee, int year, int month, int day)
        {
            var result = dbSet.Where(w => w.IdEmployee.Equals(idEmployee) && w.YearValue == year).ToList();
            result.ForEach(x => x.ScheduleLine = x.ScheduleLine.Where(s => s.MonthNum == month && s.IdSchedule.Equals(x.IdSchedule) && s.MonthDay==day).ToList());
            return mapper.Map<List<ScheduleDto>>(result);
        }
    }
}