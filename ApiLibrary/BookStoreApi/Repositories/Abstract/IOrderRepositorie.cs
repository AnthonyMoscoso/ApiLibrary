using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract
{
    interface IOrderRepositorie : IRepositorie<Orders>
    {
        List<Orders> GetByStore(string idStore);
        List<Orders> GetByStore(string idStore,int pag,int element);
        List<Orders> GetByDate(DateTime date);
        List<Orders> GetByDate(DateTime date,int pag,int element);
        List<Orders> GetByStore(string idStore,DateTime date);
        List<Orders> GetByStore(string idStore, DateTime date,int pag,int element);
        List<Orders> GetByDate(DateTime dateStart, DateTime dateEnd );
        List<Orders> GetByDate(DateTime dateStart, DateTime dateEnd,int pag,int element);
        List<Orders> GetByStore(string idStore,DateTime dateStart, DateTime dateEnd);
        List<Orders> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element);
    }
   
}
