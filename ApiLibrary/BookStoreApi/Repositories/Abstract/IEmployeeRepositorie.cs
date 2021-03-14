using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Persons
{
    interface IEmployeeRepositorie : IRepositorie <Employee>
    {
        List<Employee> GetByStore(string idStore);
        List<Employee> GetByStore(string idStore,int pag,int element);
        List<Employee> GetByWareHouse(string idWareHouse);
        List<Employee> GetByWareHouse(string idWareHouse,int pag,int element);
        List<Employee> SearchByName(string name);
        List<Employee> SearchByName(string name,int pag,int element);
        List<Employee> SearchByNameInStore(string idStore,string name);
        List<Employee> SearchByNameInStore(string idStore, string name,int pag,int element);
        List<Employee> SearchByNameInWareHouse(string idWareHouse, string name);
        List<Employee> SearchByNameInWareHouse(string idWareHouse, string name,int pag,int element);
        List<Employee> GetByDni(string dni);
        List<Employee> GetByBoss(string idBoss);
        List<Employee> GetByBoss(string idBoss,int pag,int element);
        List<Employee> GetByHireDate(DateTime date);
        List<Employee> GetByHireDate(DateTime date,int pag,int element);
        List<Employee> GetByHireDateInStore( string idStore, DateTime date);
        List<Employee> GetByHireDateInStore(string idStore, DateTime date,int pag,int element);
        List<Employee> GetByHireDateInWareHouse(string idWareHouse, DateTime date);
        List<Employee> GetByHireDateInWareHouse(string idWareHouse, DateTime date,int pag,int element);
        List<Employee> GetByStartDate(DateTime date);
        List<Employee> GetByStartDate(DateTime date,int pag,int element);
        List<Employee> GetByStartDateInStore(string idStore ,DateTime date);
        List<Employee> GetByStartDateInStore(string idStore, DateTime date,int pag,int element);
        List<Employee> GetByStartDateInWareHouse(string idWareHouse, DateTime date);
        List<Employee> GetByStartDateInWareHouse(string idWareHouse, DateTime date,int pag,int element);
        List<Employee> GetByOccupation(string idOccupation);
        List<Employee> GetByOccupation(string idOccupation,int pag,int element);
        List<Employee> GetByOccupationInStore(string idOccupation, string idStore);
        List<Employee> GetByOccupationInStore(string idOccupation, string idStore,int pag,int element);
        List<Employee> GetByOccupationInWareHouse(string idOccupation, string idWareHouse);
        List<Employee> GetByOccupationInWareHouse(string idOccupation, string idWareHouse,int pag,int element);
    }
}
