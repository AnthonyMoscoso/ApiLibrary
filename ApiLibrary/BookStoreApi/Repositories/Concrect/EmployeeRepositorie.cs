﻿using AutoMapper;
using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Models.Request;
using BookStoreApi.Repositories.Abstract.Persons;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Persons
{
    public class EmployeeRepositorie : Repository<Employee,EmployeeDto>, IEmployeeRepositorie
    {
        readonly PersonRepositorie personRepositorie;
        public EmployeeRepositorie(string identificator = "IdEmployee") : base(identificator)
        {
            personRepositorie = new PersonRepositorie();
        }
        #region Get

        public List<EmployeeDto> GetByBoss(string idBoss)
        {
            List<Employee> list = dbSet.Where(w => w.IdBoss.Equals(idBoss)).ToList();
            return mapper.Map<List<EmployeeDto>>(list);
        }

        public List<EmployeeDto> GetByBoss(string idBoss, int pag, int element)
        {
            List<Employee> list = dbSet.Where(w => w.IdBoss.Equals(idBoss))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();

            return mapper.Map<List<EmployeeDto>>(list);
        }

        public EmployeeDto GetByDni(string dni)
        {
            EmployeeDto list = mapper.Map<EmployeeDto>(dbSet.Where(w => w.Person.Dni.Equals(dni)).SingleOrDefault());
            return list;
        }

        public List<EmployeeDto> GetByHireDate(DateTime date)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.HireDate.Day.Equals(date)).ToList());
            return list;
        }

        public List<EmployeeDto> GetByHireDate(DateTime date, int pag, int element)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.HireDate.Day.Equals(date))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList());
            return list;
        }
    

        public List<EmployeeDto> GetByStore(string idStore, DateTime date)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.HireDate.Date.Equals(date.Date)).ToList());
            return list;
        }

        public List<EmployeeDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.HireDate.Date.Equals(date.Date))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList());
            return list ;
        }

        public List<EmployeeDto> GetByWareHouse(string idWareHouse, DateTime date)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && w.HireDate.Date.Equals(date.Date))
                .ToList());
            return list;
        }

        public List<EmployeeDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && w.HireDate.Date.Equals(date.Date))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList());
            return list;
        }

        public List<EmployeeDto> GetByOccupation(string idOccupation)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.IdOccupation.Equals(idOccupation)).ToList());
            return list;
        }

        public List<EmployeeDto> GetByOccupation(string idOccupation, int pag, int element)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.IdOccupation.Equals(idOccupation))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList());
            return list ;
        }

        public List<EmployeeDto> GetByOccupationInStore(string idOccupation, string idStore)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.IdOccupation.Equals(idOccupation) && w.Store.IdStore.Equals(idStore)).ToList());
            return list;
        }

        public List<EmployeeDto> GetByOccupationInStore(string idOccupation, string idStore, int pag, int element)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.IdOccupation.Equals(idOccupation) && w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList());
            return list;
        }

        public List<EmployeeDto> GetByOccupationInWareHouse(string idOccupation, string idWareHouse)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.IdOccupation.Equals(idOccupation) && w.WareHouse.IdWareHouse.Equals(idWareHouse)).ToList());
            return list;
        }

        public List<EmployeeDto> GetByOccupationInWareHouse(string idOccupation, string idWareHouse, int pag, int element)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.IdOccupation.Equals(idOccupation) && w.WareHouse.IdWareHouse.Equals(idWareHouse))
                           .OrderBy(w => w.HireDate)
                           .Skip((pag - 1) * element)
                           .Take(element)
                           .ToList());
            return list ;
        }

        public List<EmployeeDto> GetByStartDate(DateTime date)
        {
            DateTime tomorrow = date.AddDays(1);
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.StartDate > date && date < tomorrow)).ToList();
            return list;
        }

        public List<EmployeeDto> GetByStartDate(DateTime date, int pag, int element)
        {
            DateTime tomorrow = date.AddDays(1);
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.StartDate > date && date < tomorrow)
            .OrderBy(w => w.HireDate)
            .Skip((pag - 1) * element)
            .Take(element)
            .ToList());
            return list;
        }

        public List<EmployeeDto> GetByStartDateInStore(string idStore, DateTime date)
        {
            DateTime tomorrow = date.AddDays(1);
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.Store.IdStore.Equals(idStore) && (w.StartDate > date && date < tomorrow)).ToList());
            return list;
        }

        public List<EmployeeDto> GetByStartDateInStore(string idStore, DateTime date, int pag, int element)
        {
            DateTime tomorrow = date.AddDays(1);
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.Store.IdStore.Equals(idStore) && (w.StartDate > date && date < tomorrow))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList());
            return list;
        }

        public List<EmployeeDto> GetByStartDateInWareHouse(string idWareHouse, DateTime date)
        {
            DateTime tomorrow = date.AddDays(1);
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && (w.StartDate > date && date < tomorrow)).ToList());
            return list;
        }

        public List<EmployeeDto> GetByStartDateInWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            DateTime tomorrow = date.AddDays(1);
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && (w.StartDate > date && date < tomorrow))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList());
            return list;
        }

        public List<EmployeeDto> GetByStore(string idStore)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.Store.IdStore.Equals(idStore)).ToList());
            return list ;
        }

        public List<EmployeeDto> GetByStore(string idStore, int pag, int element)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.Store.IdStore.Equals(idStore))
                 .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList());
            return list; 
        }

        public List<EmployeeDto> GetByWareHouse(string idWareHouse)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse)).ToList());
            return list;
        }

        public List<EmployeeDto> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList()); 
            return list;
        }

        public List<EmployeeDto> SearchByName(string name)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(e => (e.Person.NamePerson).Contains(name)).ToList());
            return list;
        }

        public List<EmployeeDto> SearchByName(string name, int pag, int element)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(e => (e.Person.NamePerson).Contains(name))
                           .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList());
            return list; 
        }

        public List<EmployeeDto> SearchByStore(string idStore, string name)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(e => (e.Person.NamePerson).Contains(name) && e.Store.IdStore.Equals(idStore)).ToList());
            return list;
        }

        public List<EmployeeDto> SearchByStore(string idStore, string name, int pag, int element)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(e => (e.Person.NamePerson).Contains(name) && e.Store.IdStore.Equals(idStore))
                           .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList());
            return list;
        }

        public List<EmployeeDto> SearchByWareHouse(string idWareHouse, string name)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(e => (e.Person.NamePerson).Contains(name) && e.WareHouse.IdWareHouse.Equals(idWareHouse)).ToList());
            return list;
        }

        public List<EmployeeDto> SearchByWareHouse(string idWareHouse, string name, int pag, int element)
        {
            List<EmployeeDto> list = mapper.Map<List<EmployeeDto>>(dbSet.Where(e => (e.Person.NamePerson).Contains(name) && e.WareHouse.IdWareHouse.Equals(idWareHouse))
                           .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element).ToList());
            return list;
        }
        #endregion
        #region Insert 
        public dynamic  Insert(List<EmployeeDto> list)
        {
            try
            {
                List<Employee> employees = mapper.Map <List<Employee>>(list);
                return Insert(employees);
            }
            catch (SqlException)
            {

            }
            return null;
        }

        public dynamic Update(List<EmployeeDto> list)
        {
            string message = "";
            try
            {
                List<Person> people = mapper.Map<List<Person>>(list);
                message += personRepositorie.Update(people);
                foreach (EmployeeDto dto in list)
                {
                    Employee employee = mapper.Map<Employee>(dto);
                    dbSet.Attach(employee);
                    Context.Entry(employee).State = EntityState.Modified;
                    message += Save();


                }
               
            }
            catch (SqlException)
            {

            }
            return message;
        }

        public dynamic Hire(EmployeeWorkPlace employeeWorkPlace)
        {
            string query;
            switch (employeeWorkPlace.Type)
            {
                case 1:
                    query = string.Format("Insert into EmployeeStore values ('{0}','{1}')",employeeWorkPlace.IdEmployee, employeeWorkPlace.IdOffice);
                    Context.Database.ExecuteSqlCommand(query);
                    break;
                case 2:
                    query = string.Format("Insert into EmployeeWareHouse values ('{0}','{1}')", employeeWorkPlace.IdEmployee, employeeWorkPlace.IdOffice);
                    Context.Database.ExecuteSqlCommand(query);
                    break;

            }
            return Save();
                
        }

        public dynamic Fired(EmployeeWorkPlace employeeWorkPlace)
        {
            string query;
            switch (employeeWorkPlace.Type)
            {
                case 1:
                    query = string.Format("Delete from EmployeeStore where idEmployee='{0}' AND idStore='{1}'", employeeWorkPlace.IdEmployee, employeeWorkPlace.IdOffice);
                    Context.Database.ExecuteSqlCommand(query);
                    break;
                case 2:
                    query = string.Format("Delete from EmployeeWareHouse where idEmployee = '{0}' AND idWareHouse = '{1}'", employeeWorkPlace.IdEmployee, employeeWorkPlace.IdOffice);
                    Context.Database.ExecuteSqlCommand(query);
                    break;

            }
            return Save();
        }

        public new dynamic Delete(List<string> ids)
        {
            string message="";
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search!=null)
                {
                    
                    Person person = Context.Person.Find(id);
                    Context.Person.Remove(person);
                    dbSet.Remove(search);
                    message+= Save();
                }
                else
                {
                    message += string.Format("any employee was found with this id {0}",id); ;
                }
            }
            return message;
        }
        #endregion
    }
}