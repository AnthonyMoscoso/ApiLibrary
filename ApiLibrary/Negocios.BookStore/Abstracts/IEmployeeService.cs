using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IEmployeeService : IServices<EmployeeDto>
    {
        IEnumerable<EmployeeDto> GetByStore(string idStore);
        IEnumerable<EmployeeDto> GetByStore(string idStore, int pag, int element);
        IEnumerable<EmployeeDto> GetByWareHouse(string idWareHouse);
        IEnumerable<EmployeeDto> GetByWareHouse(string idWareHouse, int pag, int element);
        IEnumerable<EmployeeDto> SearchByName(string name);
        IEnumerable<EmployeeDto> SearchByName(string name, int pag, int element);
        IEnumerable<EmployeeDto> SearchByStore(string idStore, string name);
        IEnumerable<EmployeeDto> SearchByStore(string idStore, string name, int pag, int element);
        IEnumerable<EmployeeDto> SearchByWareHouse(string idWareHouse, string name);
        IEnumerable<EmployeeDto> SearchByWareHouse(string idWareHouse, string name, int pag, int element);
        EmployeeDto GetByDni(string dni);
        IEnumerable<EmployeeDto> GetByBoss(string idBoss);
        IEnumerable<EmployeeDto> GetByBoss(string idBoss, int pag, int element);
        IEnumerable<EmployeeDto> GetByHireDate(DateTime date);
        IEnumerable<EmployeeDto> GetByHireDate(DateTime date, int pag, int element);
        IEnumerable<EmployeeDto> GetByStore(string idStore, DateTime date);
        IEnumerable<EmployeeDto> GetByStore(string idStore, DateTime date, int pag, int element);
        IEnumerable<EmployeeDto> GetByWareHouse(string idWareHouse, DateTime date);
        IEnumerable<EmployeeDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element);
        IEnumerable<EmployeeDto> GetByStartDate(DateTime date);
        IEnumerable<EmployeeDto> GetByStartDate(DateTime date, int pag, int element);
        IEnumerable<EmployeeDto> GetByStartDateInStore(string idStore, DateTime date);
        IEnumerable<EmployeeDto> GetByStartDateInStore(string idStore, DateTime date, int pag, int element);
        IEnumerable<EmployeeDto> GetByStartDateInWareHouse(string idWareHouse, DateTime date);
        IEnumerable<EmployeeDto> GetByStartDateInWareHouse(string idWareHouse, DateTime date, int pag, int element);
        IEnumerable<EmployeeDto> GetByOccupation(string idOccupation);
        IEnumerable<EmployeeDto> GetByOccupation(string idOccupation, int pag, int element);
        IEnumerable<EmployeeDto> GetByOccupationInStore(string idOccupation, string idStore);
        IEnumerable<EmployeeDto> GetByOccupationInStore(string idOccupation, string idStore, int pag, int element);
        IEnumerable<EmployeeDto> GetByOccupationInWareHouse(string idOccupation, string idWareHouse);
        IEnumerable<EmployeeDto> GetByOccupationInWareHouse(string idOccupation, string idWareHouse, int pag, int element);
        dynamic Hire(EmployeeWorkPlace employeeWorkPlace);
        dynamic Fired(EmployeeWorkPlace employeeWorkPlace);
        new dynamic Insert(IEnumerable<EmployeeDto> list);
        new dynamic Update(IEnumerable<EmployeeDto> list);

        dynamic Remove_Employee_ImageFile(string idEmployee, string idImageFile);
        dynamic Set_Employee_ImageFile(string idEmployee, string idImageFile);
    }
}
