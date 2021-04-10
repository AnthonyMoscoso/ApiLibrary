using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Schedules;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Schedules
{
    public class ScheduleRepositorie : Repository<Schedule,ScheduleDto>, IScheduleRepositorie
    {
        public ScheduleRepositorie(string identificator="IdSchedule") : base(identificator)
        {
        }

        public List<Schedule> GetByEmployee(string idEmployee)
        {
            return dbSet.Where(w => w.Employee.IdPerson.Equals(idEmployee)).ToList();
        }

        public List<Schedule> GetByEmployee(string idEmployee, int year)
        {
            return dbSet.Where(w => w.Employee.IdPerson.Equals(idEmployee) && w.YearValue==year).ToList();
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

    }
}