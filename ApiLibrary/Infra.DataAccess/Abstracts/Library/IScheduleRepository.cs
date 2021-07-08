using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
       IEnumerable<Schedule> GetByEmployee(string idEmployee);
       IEnumerable<Schedule> GetByEmployee(string idEmployee,int year);
       IEnumerable<Schedule> GetByEmployee(string idEmployee,int year,int month);
       IEnumerable<Schedule> GetByEmployee(string idEmployee, int year, int month,int day);

    }
}
