using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using Models.Ado.Library;
using Nucleo.Utilities.Enums;
using Nucleo.Utilities;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Persons
{
    public class EmployeeRepositorie : Repository<Employee,EmployeeDto>, IEmployeeRepositorie
    {
        readonly PersonRepository personRepositorie;
        public EmployeeRepositorie(string identificator = "IdEmployee") : base(identificator)
        {
            personRepositorie = new PersonRepository();
           
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
           List<Employee> employees = mapper.Map <List<Employee>>(list);
            return Insert(employees); 
        }

        public dynamic Update(List<EmployeeDto> list)
        {

           
               
                List<Person> people = mapper.Map<List<Person>>(list);
                personRepositorie.Update(people);
                foreach (EmployeeDto dto in list)
                {
                    Employee employee = mapper.Map<Employee>(dto);
                    dbSet.Attach(employee);
                    Context.Entry(employee).State = EntityState.Modified;
                    try
                    {
                        Context.SaveChanges();
                        MessageControl message = new MessageControl()
                        {

                        };
                        messages.Add(message);
                    }
                    catch (DbUpdateException e)
                    {
                        MessageControl message = new MessageControl()
                        {

                        };
                        messages.Add(message);
                    }
                    catch (SqlException e)
                    {
                        MessageControl message = new MessageControl()
                        {

                        };
                     messages.Add(message);
                    }
                }


                return messages;
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

        public dynamic Remove_Employee_ImageFile(string idEmployee, string idImageFile)
        {
            var employee = dbSet.Find(idEmployee);
            var file = Context.ImageFile.Find(idImageFile);
            MessageControl message = new MessageControl(); 
            if (employee!=null && file!=null)
            {
                var query = $"Delete from EmployeeImageFile where IdEmployee ='{employee.IdPerson}'";
                try
                {
                    Context.Database.ExecuteSqlCommand(query);
                    Context.SaveChanges();
                    message.Error = false;
                    message.Type = MessageType.Insert;
                    message.Code = MessageCode.correct;
                    message.Note = $"EmployeeImageFile with {Identificator} = {idEmployee} was delete ";
                }
                catch(DbUpdateException e)
                {
                    message.Error = true;
                    message.Type = MessageType.Exception;
                    message.Code = MessageCode.exception;
                    message.Note = $"{e.InnerException.InnerException.Message}";
                }
            }
            else if(employee == null && file!=null )
            {
                message.Error = true;
                message.Type = MessageType.Not_Found;
                message.Code = MessageCode.error;
                message.Note = $"{name} with  {Identificator} : {idEmployee} not was found";
                   
            }
            else if (file == null && employee!=null)
            {
                message.Error = true;
                message.Type = MessageType.Not_Found;
                message.Code = MessageCode.error;
                message.Note = $"file with  IdFile: {idImageFile} not was found";
            }
            else
            {
                message.Error = true;
                message.Type = MessageType.Not_Found;
                message.Code = MessageCode.error;
                message.Note = $"file with  IdFile: {idImageFile} not was found";
            }
            return message;
        }

        public dynamic Set_Employee_ImageFile(string idEmployee, string idImageFile)
        {
            var employee = dbSet.Find(idEmployee);
            var file =Context.ImageFile.Find(idImageFile);
            MessageControl message = new MessageControl();
            if (employee!=null && file!=null)
            {
                var query = $"Insert into EmployeeImageFile values('{employee.IdPerson}','{file.IdImageFile}');";
                try
                {
                    Context.Database.ExecuteSqlCommand(query);
                    Context.SaveChanges();
                    message.Error = false;
                    message.Type = MessageType.Insert;
                    message.Code = MessageCode.correct;
                    message.Note = $"EmployeeImageFile with = {idEmployee} was delete ";
                }
                catch (DbUpdateException e)
                {
                    message.Error = true;
                    message.Type = MessageType.Exception;
                    message.Code = MessageCode.exception;
                    message.Note = $"{e.InnerException.InnerException.Message}";
                }
            }
            else if (employee == null & file!=null)
            {
                message.Error = true;
                message.Type = MessageType.Not_Found;
                message.Code = MessageCode.error;
                message.Note = $"{name} with {Identificator} = {employee.IdPerson} not was found";
            }
            else if(file==null && employee != null)
            {
                message.Error = true;
                message.Type = MessageType.Not_Found;
                message.Code = MessageCode.error;
                message.Note = $"ImageFile with IdImage ={file.IdImageFile} not was found";
            }
            else
            {
                message.Error = true;
                message.Type = MessageType.Not_Found;
                message.Code = MessageCode.error;
                message.Note = $"ImageFile && Employe not was found";
            }
          
            return message;
        }
        #endregion
    }
}