using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IScheduleRepository : IRepository<Schedule>
    {
       List<ScheduleDto> GetByEmployee(string idEmployee);
       List<ScheduleDto> GetByEmployee(string idEmployee,int year);
       List<ScheduleDto> GetByEmployee(string idEmployee,int year,int month);
       List<ScheduleDto> GetByEmployee(string idEmployee, int year, int month,int day);

    }
}
