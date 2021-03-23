using AutoMapper;
using BookStoreApi.Models.Library;
using BookStoreApi.Models.Request;
using BookStoreApi.Repositories.Abstract.Persons;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Persons
{
    public class EmployeeRepositorie : Repositorie<Employee>, IEmployeeRepositorie
    {
        public EmployeeRepositorie(string identificator = "IdEmployee") : base(identificator)
        {
        }
        #region Get

        public new List<EmployeeRequest> Get()
        {
            List<EmployeeRequest> list = new List<EmployeeRequest>();
                list = (from p in Context.Employee.Include("Person")
                        select new EmployeeRequest
                        {
                            IdPerson = p.IdPerson,
                            NamePerson = p.Person.NamePerson,
                            Email = p.Person.Email,
                            Phone = p.Person.Phone,
                            Pass = p.Person.Pass,
                            TypePerson = p.Person.TypePerson,
                            CreateDate  = p.LastUpdateDate,
                            LastUpdateDate = p.CreateDate,
                            StatusCode = p.StatusCode,
                            Dni = p.Person.Dni,
                            IdEmployee = p.IdEmployee,
                            IdBoss = p.IdBoss,
                            IdOccupation = p.IdOccupation,
                            StartDate = p.StartDate,
                            HireDate = p.HireDate,
                            DischargeDate = p.DischargeDate,
                            TypeStatus = p.TypeStatus,
                            Discount = p.Discount,
                            Occupation = p.Occupation,
                            SalePurchases = (List<Sale>)p.Person.Sale,
                            ReservationsDo = (List<Reservation>)p.Person.Reservation
                        }).ToList();
            
            return list;
        }
        public List<Employee> GetByBoss(string idBoss)
        {
            return dbSet.Where(w=>w.IdBoss.Equals(idBoss)).ToList();
        }

        public List<Employee> GetByBoss(string idBoss, int pag, int element)
        {
            return dbSet.Where(w => w.IdBoss.Equals(idBoss))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }

        public List<Employee> GetByDni(string dni)
        {
            return dbSet.Where(w=>w.Person.Dni.Equals(dni)).ToList();
        }

        public List<Employee> GetByHireDate(DateTime date)
        {
            return dbSet.Where(w=>w.HireDate.Day.Equals(date)).ToList();
        }

        public List<Employee> GetByHireDate(DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.HireDate.Day.Equals(date))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
    

        public List<Employee> GetByHireDateInStore(string idStore, DateTime date)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.HireDate.Date.Equals(date.Date)).ToList();
        }

        public List<Employee> GetByHireDateInStore(string idStore, DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.HireDate.Date.Equals(date.Date))
                .OrderBy(w=> w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }

        public List<Employee> GetByHireDateInWareHouse(string idWareHouse, DateTime date)
        {
            return dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && w.HireDate.Date.Equals(date.Date))
                .ToList();
        }

        public List<Employee> GetByHireDateInWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && w.HireDate.Date.Equals(date.Date))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }

        public List<Employee> GetByOccupation(string idOccupation)
        {
            return dbSet.Where(w=>w.IdOccupation.Equals(idOccupation)).ToList();
        }

        public List<Employee> GetByOccupation(string idOccupation, int pag, int element)
        {
            return dbSet.Where(w => w.IdOccupation.Equals(idOccupation))
                .OrderBy(w=> w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }

        public List<Employee> GetByOccupationInStore(string idOccupation, string idStore)
        {
            return dbSet.Where(w => w.IdOccupation.Equals(idOccupation) && w.Store.IdStore.Equals(idStore)).ToList() ;
        }

        public List<Employee> GetByOccupationInStore(string idOccupation, string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.IdOccupation.Equals(idOccupation) && w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }

        public List<Employee> GetByOccupationInWareHouse(string idOccupation, string idWareHouse)
        {
            return dbSet.Where(w=>w.IdOccupation.Equals(idOccupation) && w.WareHouse.IdWareHouse.Equals(idWareHouse)).ToList();
        }

        public List<Employee> GetByOccupationInWareHouse(string idOccupation, string idWareHouse, int pag, int element)
        {
            return dbSet.Where(w => w.IdOccupation.Equals(idOccupation) && w.WareHouse.IdWareHouse.Equals(idWareHouse))
                           .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Employee> GetByStartDate(DateTime date)
        {
            return dbSet.Where(w=>w.StartDate.Date.Equals(date.Date)).ToList();
        }

        public List<Employee> GetByStartDate(DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.StartDate.Date.Equals(date.Date))
                           .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Employee> GetByStartDateInStore(string idStore, DateTime date)
        {
            return dbSet.Where(w=>w.Store.IdStore.Equals(idStore) && w.StartDate.Date.Equals(date.Date)).ToList();
        }

        public List<Employee> GetByStartDateInStore(string idStore, DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.StartDate.Date.Equals(date.Date))
                           .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Employee> GetByStartDateInWareHouse(string idWareHouse, DateTime date)
        {
            return dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && w.StartDate.Date.Equals(date.Date)).ToList();
        }

        public List<Employee> GetByStartDateInWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && w.StartDate.Date.Equals(date.Date))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Employee> GetByStore(string idStore)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore)).ToList();
        }

        public List<Employee> GetByStore(string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.Store.IdStore.Equals(idStore))
                 .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Employee> GetByWareHouse(string idWareHouse)
        {
            return dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse)).ToList();
        }

        public List<Employee> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            return dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse))
                .OrderBy(w=>w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Employee> SearchByName(string name)
        {
            var list = dbSet.Where(e => (e.Person.NamePerson).Contains(name)).ToList();
            return list;
        }

        public List<Employee> SearchByName(string name, int pag, int element)
        {
            return dbSet.Where(e => (e.Person.NamePerson ).Contains(name))
                           .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList(); 
        }

        public List<Employee> SearchByNameInStore(string idStore, string name)
        {
            return dbSet.Where(e => (e.Person.NamePerson).Contains(name) && e.Store.IdStore.Equals(idStore)).ToList();
        }

        public List<Employee> SearchByNameInStore(string idStore, string name, int pag, int element)
        {
            return dbSet.Where(e => (e.Person.NamePerson ).Contains(name) && e.Store.IdStore.Equals(idStore))
                           .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Employee> SearchByNameInWareHouse(string idWareHouse, string name)
        {
            return dbSet.Where(e => (e.Person.NamePerson ).Contains(name) && e.WareHouse.IdWareHouse.Equals(idWareHouse)).ToList();
        }

        public List<Employee> SearchByNameInWareHouse(string idWareHouse, string name, int pag, int element)
        {
            return dbSet.Where(e => (e.Person.NamePerson).Contains(name) && e.WareHouse.IdWareHouse.Equals(idWareHouse))
                           .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion
        #region Insert 
        public dynamic Insert(EmployeeRequest employee)
        {
            try
            {
                Insert(mapper.Map<Employee>(employee));
                new Repositorie<Person>("IdPerson").Insert(mapper.Map<Person>(employee));
            }
            catch (SqlException)
            {

            }
            return null;
        }
        #endregion
    }
}