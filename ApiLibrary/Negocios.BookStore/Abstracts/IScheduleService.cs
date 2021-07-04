using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IScheduleService : IServices<ScheduleDto>
    {
        IEnumerable<ScheduleDto> GetByEmployee(string idEmployee);
        IEnumerable<ScheduleDto> GetByEmployee(string idEmployee, int year);
        IEnumerable<ScheduleDto> GetByEmployee(string idEmployee, int year, int month);
        IEnumerable<ScheduleDto> GetByEmployee(string idEmployee, int year, int month, int day);
    }
}
