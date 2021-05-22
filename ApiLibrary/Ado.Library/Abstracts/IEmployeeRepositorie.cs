using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IEmployeeRepositorie : IRepository <Employee>
    {
        List<EmployeeDto> GetByStore(string idStore);
        List<EmployeeDto> GetByStore(string idStore,int pag,int element);
        List<EmployeeDto> GetByWareHouse(string idWareHouse);
        List<EmployeeDto> GetByWareHouse(string idWareHouse,int pag,int element);
        List<EmployeeDto> SearchByName(string name);
        List<EmployeeDto> SearchByName(string name,int pag,int element);
        List<EmployeeDto> SearchByStore(string idStore,string name);
        List<EmployeeDto> SearchByStore(string idStore, string name,int pag,int element);
        List<EmployeeDto> SearchByWareHouse(string idWareHouse, string name);
        List<EmployeeDto> SearchByWareHouse(string idWareHouse, string name,int pag,int element);
        EmployeeDto GetByDni(string dni);
        List<EmployeeDto> GetByBoss(string idBoss);
        List<EmployeeDto> GetByBoss(string idBoss,int pag,int element);
        List<EmployeeDto> GetByHireDate(DateTime date);
        List<EmployeeDto> GetByHireDate(DateTime date,int pag,int element);
        List<EmployeeDto> GetByStore( string idStore, DateTime date);
        List<EmployeeDto> GetByStore(string idStore, DateTime date,int pag,int element);
        List<EmployeeDto> GetByWareHouse(string idWareHouse, DateTime date);
        List<EmployeeDto> GetByWareHouse(string idWareHouse, DateTime date,int pag,int element);
        List<EmployeeDto> GetByStartDate(DateTime date);
        List<EmployeeDto> GetByStartDate(DateTime date,int pag,int element);
        List<EmployeeDto> GetByStartDateInStore(string idStore ,DateTime date);
        List<EmployeeDto> GetByStartDateInStore(string idStore, DateTime date,int pag,int element);
        List<EmployeeDto> GetByStartDateInWareHouse(string idWareHouse, DateTime date);
        List<EmployeeDto> GetByStartDateInWareHouse(string idWareHouse, DateTime date,int pag,int element);
        List<EmployeeDto> GetByOccupation(string idOccupation);
        List<EmployeeDto> GetByOccupation(string idOccupation,int pag,int element);
        List<EmployeeDto> GetByOccupationInStore(string idOccupation, string idStore);
        List<EmployeeDto> GetByOccupationInStore(string idOccupation, string idStore,int pag,int element);
        List<EmployeeDto> GetByOccupationInWareHouse(string idOccupation, string idWareHouse);
        List<EmployeeDto> GetByOccupationInWareHouse(string idOccupation, string idWareHouse,int pag,int element);
        dynamic Hire(EmployeeWorkPlace employeeWorkPlace);
        dynamic Fired(EmployeeWorkPlace employeeWorkPlace);
        dynamic Insert(List<EmployeeDto> list);
        dynamic Update(List<EmployeeDto> list);

        dynamic Remove_Employee_ImageFile(string idEmployee,string idImageFile);
        dynamic Set_Employee_ImageFile(string idEmployee,string idImageFile);
    }
}
