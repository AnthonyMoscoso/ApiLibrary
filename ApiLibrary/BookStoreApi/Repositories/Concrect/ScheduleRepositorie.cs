using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Schedules;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Schedules
{
    public class ScheduleRepositorie : Repositorie<Schedule>, IScheduleRepositorie
    {
        public ScheduleRepositorie(string identificator="IdSchedule") : base(identificator)
        {
        }

        public List<Schedule> GetByEmployee(string idEmployee)
        {
            return dbSet.Where(w => w.Employee.IdEmployee.Equals(idEmployee)).ToList();
        }

        public List<Schedule> GetByEmployee(string idEmployee, int year)
        {
            return dbSet.Where(w => w.Employee.IdEmployee.Equals(idEmployee) && w.YearValue==year).ToList();
        }

        public List<Schedule> GetByStore(string idStore)
        {
            return dbSet.Where(w=>w.Store.IdStore.Equals(idStore)).ToList();
        }

        public List<Schedule> GetByStore(string idStore, int year)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.YearValue == year).ToList();
        }

        public List<Schedule> GetByWareHouse(string idWareHouse)
        {
            return dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) ).ToList();
        }

        public List<Schedule> GetByWareHouse(string idWareHouse, int year)
        {
            return dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && w.YearValue == year).ToList();
        }
    }
}