using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Schedules
{
    interface IScheduleRepository : IRepository<Schedule>
    {
       List<Schedule> GetByStore(string idStore);
       List<Schedule> GetByStore(string idStore,int year);
       List<Schedule> GetByWareHouse(string idWareHouse);
       List<Schedule> GetByWareHouse(string idWareHouse,int year);
       List<Schedule> GetByEmployee(string idEmployee);
       List<Schedule> GetByEmployee(string idEmployee,int year);
       
    }
}
