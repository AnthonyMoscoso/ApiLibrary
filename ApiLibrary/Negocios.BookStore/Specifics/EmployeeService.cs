using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using Ado.Library.Specifics;

namespace Negocios.BookStoreServices.Abstracts
{
    public class EmployeeService : ServiceMapperBase<EmployeeDto, Employee>, IEmployeeService
    {
        new readonly IEmployeeRepository _repository ;
        public EmployeeService(EmployeeRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public dynamic Fired(EmployeeWorkPlace EmployeeDtoWorkPlace)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByBoss(string idBoss)
        {
            return mapper.Map<IEnumerable<EmployeeDto>>(_repository.GetByBoss(idBoss));
        }

        public IEnumerable<EmployeeDto> GetByBoss(string idBoss, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public EmployeeDto GetByDni(string dni)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByHireDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByHireDate(DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByOccupation(string idOccupation)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByOccupation(string idOccupation, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByOccupationInStore(string idOccupation, string idStore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByOccupationInStore(string idOccupation, string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByOccupationInWareHouse(string idOccupation, string idWareHouse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByOccupationInWareHouse(string idOccupation, string idWareHouse, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByStartDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByStartDate(DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByStartDateInStore(string idStore, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByStartDateInStore(string idStore, DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByStartDateInWareHouse(string idWareHouse, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByStartDateInWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByStore(string idStore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByStore(string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByStore(string idStore, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByWareHouse(string idWareHouse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByWareHouse(string idWareHouse, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public dynamic Hire(EmployeeWorkPlace EmployeeDtoWorkPlace)
        {
            throw new NotImplementedException();
        }

        public dynamic Remove_Employee_ImageFile(string idEmployeeDto, string idImageFile)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> SearchByName(string name, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> SearchByStore(string idStore, string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> SearchByStore(string idStore, string name, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> SearchByWareHouse(string idWareHouse, string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeDto> SearchByWareHouse(string idWareHouse, string name, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public dynamic Set_Employee_ImageFile(string idEmployeeDto, string idImageFile)
        {
            throw new NotImplementedException();
        }
    }
}
