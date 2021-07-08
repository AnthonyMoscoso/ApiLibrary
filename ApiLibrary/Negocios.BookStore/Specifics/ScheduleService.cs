using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class ScheduleService : ServiceMapperBase<ScheduleDto, Schedule>, IScheduleService
    {
        public ScheduleService(IScheduleRepository repository) : base(repository)
        {
        }

        public IEnumerable<ScheduleDto> GetByEmployee(string idEmployee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScheduleDto> GetByEmployee(string idEmployee, int year)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScheduleDto> GetByEmployee(string idEmployee, int year, int month)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScheduleDto> GetByEmployee(string idEmployee, int year, int month, int day)
        {
            throw new NotImplementedException();
        }
    }
}
