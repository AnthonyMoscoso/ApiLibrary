using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IEmployeeRepository : IRepository <Employee>
    {
        IEnumerable<Employee> GetByStore(string idStore);
        IEnumerable<Employee> GetByStore(string idStore,int pag,int element);
        IEnumerable<Employee> GetByWareHouse(string idWareHouse);
        IEnumerable<Employee> GetByWareHouse(string idWareHouse,int pag,int element);
        IEnumerable<Employee> SearchByName(string name);
        IEnumerable<Employee> SearchByName(string name,int pag,int element);
        IEnumerable<Employee> SearchByStore(string idStore,string name);
        IEnumerable<Employee> SearchByStore(string idStore, string name,int pag,int element);
        IEnumerable<Employee> SearchByWareHouse(string idWareHouse, string name);
        IEnumerable<Employee> SearchByWareHouse(string idWareHouse, string name,int pag,int element);
        Employee GetByDni(string dni);
        IEnumerable<Employee> GetByBoss(string idBoss);
        IEnumerable<Employee> GetByBoss(string idBoss,int pag,int element);
        IEnumerable<Employee> GetByHireDate(DateTime date);
        IEnumerable<Employee> GetByHireDate(DateTime date,int pag,int element);
        IEnumerable<Employee> GetByStore( string idStore, DateTime date);
        IEnumerable<Employee> GetByStore(string idStore, DateTime date,int pag,int element);
        IEnumerable<Employee> GetByWareHouse(string idWareHouse, DateTime date);
        IEnumerable<Employee> GetByWareHouse(string idWareHouse, DateTime date,int pag,int element);
        IEnumerable<Employee> GetByStartDate(DateTime date);
        IEnumerable<Employee> GetByStartDate(DateTime date,int pag,int element);
        IEnumerable<Employee> GetByStartDateInStore(string idStore ,DateTime date);
        IEnumerable<Employee> GetByStartDateInStore(string idStore, DateTime date,int pag,int element);
        IEnumerable<Employee> GetByStartDateInWareHouse(string idWareHouse, DateTime date);
        IEnumerable<Employee> GetByStartDateInWareHouse(string idWareHouse, DateTime date,int pag,int element);
        IEnumerable<Employee> GetByOccupation(string idOccupation);
        IEnumerable<Employee> GetByOccupation(string idOccupation,int pag,int element);
        IEnumerable<Employee> GetByOccupationInStore(string idOccupation, string idStore);
        IEnumerable<Employee> GetByOccupationInStore(string idOccupation, string idStore,int pag,int element);
        IEnumerable<Employee> GetByOccupationInWareHouse(string idOccupation, string idWareHouse);
        IEnumerable<Employee> GetByOccupationInWareHouse(string idOccupation, string idWareHouse,int pag,int element);
        void Hire(EmployeeWorkPlace employeeWorkPlace);
        void Fired(EmployeeWorkPlace employeeWorkPlace);
        new dynamic Insert(IEnumerable<Employee> list);
        new dynamic Update(IEnumerable<Employee> list);

       /* dynamic Remove_Employee_ImageFile(string idEmployee,string idImageFile);
        dynamic Set_Employee_ImageFile(string idEmployee,string idImageFile);*/
    }
}
