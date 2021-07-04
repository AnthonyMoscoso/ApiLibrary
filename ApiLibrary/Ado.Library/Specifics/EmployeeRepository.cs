using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using Models.Ado.Library;
using Core.Utilities.Enums;
using Core.Utilities;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;

namespace Ado.Library.Specifics
{
    public class EmployeeRepository : AdoRepository<Employee>, IEmployeeRepository
    {
        readonly IPersonRepository _personRepositorie;
        public EmployeeRepository(BookStoreEntities context,string identificator="IdEmployee") : base(context,identificator)
        {
          
           
        }
        #region Get

        public IEnumerable<Employee> GetByBoss(string idBoss)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.IdBoss.Equals(idBoss)).ToList();
            return list;
        }

        public IEnumerable<Employee> GetByBoss(string idBoss, int pag, int element)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.IdBoss.Equals(idBoss))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();

            return list;
        }

        public Employee GetByDni(string dni)
        {
            Employee search= dbSet.Where(w => w.Person.Dni.Equals(dni)).SingleOrDefault();
            return search;
        }

        public IEnumerable<Employee> GetByHireDate(DateTime date)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.HireDate.Day.Equals(date));
            return list;
        }

        public IEnumerable<Employee> GetByHireDate(DateTime date, int pag, int element)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.HireDate.Day.Equals(date))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return list;
        }
    

        public IEnumerable<Employee> GetByStore(string idStore, DateTime date)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.HireDate.Date.Equals(date.Date));
            return list;
        }

        public IEnumerable<Employee> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.Store.IdStore.Equals(idStore) && w.HireDate.Date.Equals(date.Date))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return list ;
        }

        public IEnumerable<Employee> GetByWareHouse(string idWareHouse, DateTime date)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && w.HireDate.Date.Equals(date.Date))
                ;
            return list;
        }

        public IEnumerable<Employee> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && w.HireDate.Date.Equals(date.Date))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return list;
        }

        public IEnumerable<Employee> GetByOccupation(string idOccupation)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.IdOccupation.Equals(idOccupation));
            return list;
        }

        public IEnumerable<Employee> GetByOccupation(string idOccupation, int pag, int element)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.IdOccupation.Equals(idOccupation))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return list ;
        }

        public IEnumerable<Employee> GetByOccupationInStore(string idOccupation, string idStore)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.IdOccupation.Equals(idOccupation) && w.Store.IdStore.Equals(idStore));
            return list;
        }

        public IEnumerable<Employee> GetByOccupationInStore(string idOccupation, string idStore, int pag, int element)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.IdOccupation.Equals(idOccupation) && w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return list;
        }

        public IEnumerable<Employee> GetByOccupationInWareHouse(string idOccupation, string idWareHouse)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.IdOccupation.Equals(idOccupation) && w.WareHouse.IdWareHouse.Equals(idWareHouse));
            return list;
        }

        public IEnumerable<Employee> GetByOccupationInWareHouse(string idOccupation, string idWareHouse, int pag, int element)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.IdOccupation.Equals(idOccupation) && w.WareHouse.IdWareHouse.Equals(idWareHouse))
                           .OrderBy(w => w.HireDate)
                           .Skip((pag - 1) * element)
                           .Take(element)
                           ;
            return list ;
        }

        public IEnumerable<Employee> GetByStartDate(DateTime date)
        {
            IEnumerable<Employee> list = dbSet.Where(w => DbFunctions.TruncateTime(w.StartDate) == DbFunctions.TruncateTime(date));
            return list;
        }

        public IEnumerable<Employee> GetByStartDate(DateTime date, int pag, int element)
        {
            DateTime tomorrow = date.AddDays(1);
            IEnumerable<Employee> list = dbSet.Where(w => w.StartDate > date && date < tomorrow)
            .OrderBy(w => w.HireDate)
            .Skip((pag - 1) * element)
            .Take(element)
            ;
            return list;
        }

        public IEnumerable<Employee> GetByStartDateInStore(string idStore, DateTime date)
        {
            DateTime tomorrow = date.AddDays(1);
            IEnumerable<Employee> list = dbSet.Where(w => w.Store.IdStore.Equals(idStore) && (w.StartDate > date && date < tomorrow));
            return list;
        }

        public IEnumerable<Employee> GetByStartDateInStore(string idStore, DateTime date, int pag, int element)
        {
            DateTime tomorrow = date.AddDays(1);
            IEnumerable<Employee> list = dbSet.Where(w => w.Store.IdStore.Equals(idStore) && (w.StartDate > date && date < tomorrow))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return list;
        }

        public IEnumerable<Employee> GetByStartDateInWareHouse(string idWareHouse, DateTime date)
        {
            DateTime tomorrow = date.AddDays(1);
            IEnumerable<Employee> list = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && (w.StartDate > date && date < tomorrow));
            return list;
        }

        public IEnumerable<Employee> GetByStartDateInWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            DateTime tomorrow = date.AddDays(1);
            IEnumerable<Employee> list = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && (w.StartDate > date && date < tomorrow))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element);
            return list;
        }

        public IEnumerable<Employee> GetByStore(string idStore)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.Store.IdStore.Equals(idStore));
            return list ;
        }

        public IEnumerable<Employee> GetByStore(string idStore, int pag, int element)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.Store.IdStore.Equals(idStore))
                 .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element);
            return list; 
        }

        public IEnumerable<Employee> GetByWareHouse(string idWareHouse)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse));
            return list;
        }

        public IEnumerable<Employee> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            IEnumerable<Employee> list = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse))
                .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element); 
            return list;
        }

        public IEnumerable<Employee> SearchByName(string name)
        {
            IEnumerable<Employee> list = dbSet.Where(e => (e.Person.NamePerson).Contains(name));
            return list;
        }

        public IEnumerable<Employee> SearchByName(string name, int pag, int element)
        {
            IEnumerable<Employee> list = dbSet.Where(e => (e.Person.NamePerson).Contains(name))
                           .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element);
            return list; 
        }

        public IEnumerable<Employee> SearchByStore(string idStore, string name)
        {
            IEnumerable<Employee> list = dbSet.Where(e => (e.Person.NamePerson).Contains(name) && e.Store.IdStore.Equals(idStore));
            return list;
        }

        public IEnumerable<Employee> SearchByStore(string idStore, string name, int pag, int element)
        {
            IEnumerable<Employee> list = dbSet.Where(e => (e.Person.NamePerson).Contains(name) && e.Store.IdStore.Equals(idStore))
                           .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element);
            return list;
        }

        public IEnumerable<Employee> SearchByWareHouse(string idWareHouse, string name)
        {
            IEnumerable<Employee> list = dbSet.Where(e => (e.Person.NamePerson).Contains(name) && e.WareHouse.IdWareHouse.Equals(idWareHouse));
            return list;
        }

        public IEnumerable<Employee> SearchByWareHouse(string idWareHouse, string name, int pag, int element)
        {
            IEnumerable<Employee> list = dbSet.Where(e => (e.Person.NamePerson).Contains(name) && e.WareHouse.IdWareHouse.Equals(idWareHouse))
                           .OrderBy(w => w.HireDate)
                .Skip((pag - 1) * element).Take(element);
            return list;
        }
        #endregion
   

        public void Hire(EmployeeWorkPlace employeeWorkPlace)
        {
            string query;
            switch (employeeWorkPlace.Type)
            {
                case 1:
                    query = string.Format("Insert into EmployeeStore values ('{0}','{1}')",employeeWorkPlace.IdEmployee, employeeWorkPlace.IdOffice);
                    ExecuteQuery(query);
                    break;
                case 2:
                    query = string.Format("Insert into EmployeeWareHouse values ('{0}','{1}')", employeeWorkPlace.IdEmployee, employeeWorkPlace.IdOffice);
                    ExecuteQuery(query);
                    break;

            }
            
                
        }

        public void Fired(EmployeeWorkPlace employeeWorkPlace)
        {
            string query;
            switch (employeeWorkPlace.Type)
            {
                case 1:
                    query = $"Delete from EmployeeStore where idEmployee='{employeeWorkPlace.IdEmployee}' AND idStore='{employeeWorkPlace.IdOffice}'";
                    ExecuteQuery(query);
                    break;
                case 2:
                    query = string.Format("Delete from EmployeeWareHouse where idEmployee = '{0}' AND idWareHouse = '{1}'", employeeWorkPlace.IdEmployee, employeeWorkPlace.IdOffice);
                    ExecuteQuery(query);
                    break;

            }
     
        }

        public new dynamic Delete(IEnumerable<string> ids)
        {
            string message=string.Empty;
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search!=null)
                {

                    Person person = _personRepositorie.GetSingle(id);
                    if (person!=null)
                    {
                        _personRepositorie.Delete(id);
                    }

                }
                else
                {

                    _log.Write(string.Format("any employee was found with this id {0}", id));
                }
            }

            return Save();
           
        }

        /*public dynamic Remove_Employee_ImageFile(string idEmployee, string idImageFile)
        {
            var employee = dbSet.Find(idEmployee);
            var file = _Context.ImageFile.Find(idImageFile);
            MessageControl message = new MessageControl(); 
            if (employee!=null && file!=null)
            {
                var query = $"Delete from EmployeeImageFile where IdEmployee ='{employee.IdPerson}'";
                try
                {
                    _Context.Database.ExecuteSqlCommand(query);
                    _Context.SaveChanges();
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
            var file =_Context.ImageFile.Find(idImageFile);
            MessageControl message = new MessageControl();
            if (employee!=null && file!=null)
            {
                var query = $"Insert into EmployeeImageFile values('{employee.IdPerson}','{file.IdImageFile}');";
                try
                {
                    _Context.Database.ExecuteSqlCommand(query);
                    _Context.SaveChanges();
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
        }*/
  
    }
}