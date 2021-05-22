using Models.Ado.Library;
using Models.Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;


namespace Ado.Library
{
    public interface IRegisterWareHouseRepository : IRepository<Register>
    {
        new List<RegisterWareHouseDto> Get();
        List<RegisterWareHouseDto> GetByWareHouse(string idWareHouse);
        List<RegisterWareHouseDto> GetByWareHouse(string idWareHouse, int pag, int element);
        List<RegisterWareHouseDto> GetByWareHouse(string idWareHouse, DateTime date);
        List<RegisterWareHouseDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element);
        List<RegisterWareHouseDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd);
        List<RegisterWareHouseDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element);

        dynamic Insert(List<RegisterWareHouseDto> list);
        dynamic Update(List<RegisterWareHouseDto> list);
    }
}
