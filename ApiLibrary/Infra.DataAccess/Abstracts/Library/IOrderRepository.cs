using Models.Ado.Library;
using Models.Dtos;
using System;
using Core.DBAccess.Ado;
using System.Collections.Generic;

namespace Ado.Library
{
    public interface IOrderRepository : IRepository<Orders>
    {
 
        IEnumerable<Orders> GetByDate(DateTime date);
        IEnumerable<Orders> GetByDate(DateTime date,int pag,int element);
        IEnumerable<Orders> GetByDate(DateTime dateStart, DateTime dateEnd);
        IEnumerable<Orders> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element);
        IEnumerable<Orders> GetByStore(string idStore,DateTime date);
        IEnumerable<Orders> GetByStore(string idStore, DateTime date,int pag,int element);
        IEnumerable<Orders> GetByStore(string idStore);
        IEnumerable<Orders> GetByStore(string idStore, int pag, int element);
        IEnumerable<Orders> GetByStore(string idStore,DateTime dateStart, DateTime dateEnd);
        IEnumerable<Orders> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element);

        IEnumerable<Orders> GetByWareHouse(string idWareHouse, DateTime date);
        IEnumerable<Orders> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element);
        IEnumerable<Orders> GetByWareHouse(string idWareHouse);
        IEnumerable<Orders> GetByWareHouse(string idWareHouse, int pag, int element);
        IEnumerable<Orders> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd);
        IEnumerable<Orders> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element);
    }
   
}
