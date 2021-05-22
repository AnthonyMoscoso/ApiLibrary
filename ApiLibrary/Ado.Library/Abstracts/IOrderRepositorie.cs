using Models.Ado.Library;
using Models.Dtos;
using System;
using Nucleo.DBAccess.Ado;
using System.Collections.Generic;

namespace Ado.Library
{
    public interface IOrderRepositorie : IRepository<Orders>
    {
 
        List<OrderDto> GetByDate(DateTime date);
        List<OrderDto> GetByDate(DateTime date,int pag,int element);
        List<OrderDto> GetByDate(DateTime dateStart, DateTime dateEnd);
        List<OrderDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element);
        List<OrderDto> GetByStore(string idStore,DateTime date);
        List<OrderDto> GetByStore(string idStore, DateTime date,int pag,int element);
        List<OrderDto> GetByStore(string idStore);
        List<OrderDto> GetByStore(string idStore, int pag, int element);
        List<OrderDto> GetByStore(string idStore,DateTime dateStart, DateTime dateEnd);
        List<OrderDto> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element);

        List<OrderDto> GetByWareHouse(string idWareHouse, DateTime date);
        List<OrderDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element);
        List<OrderDto> GetByWareHouse(string idWareHouse);
        List<OrderDto> GetByWareHouse(string idWareHouse, int pag, int element);
        List<OrderDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd);
        List<OrderDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element);
    }
   
}
