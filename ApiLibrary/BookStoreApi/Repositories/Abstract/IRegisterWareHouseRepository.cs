using BookStoreApi.Models.Dtos;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract
{
    interface IRegisterWareHouseRepository : IRepository<Register>
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
