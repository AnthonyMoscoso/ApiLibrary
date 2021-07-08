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
    public class ScheduleLineService : ServiceMapperBase<ScheduleLineDto, ScheduleLine>, IScheduleLineService
    {
        public ScheduleLineService(IRepository<ScheduleLine> repository) : base(repository)
        {
        }

        public IEnumerable<ScheduleLineDto> GetBySchedule(string idSchedule)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScheduleLineDto> GetBySchedule(string idSchedule, int month)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScheduleLineDto> GetBySchedule(string idSchedule, int month, int day)
        {
            throw new NotImplementedException();
        }
    }
}
