using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Registers
{
    interface IRegisterRepositorie : IRepositorie<Register>
    {
        List<Register> GetByDate(DateTime date);
        List<Register> GetByDate(DateTime date, int pag, int element);
        List<Register> GetByDate(DateTime dateStart, DateTime dateEnd);
        List<Register> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element);
        List<Register> GetByStore(string idStore);
        List<Register> GetByStore(string idStore, int pag, int element);
        List<Register> GetByStore(string idStore, DateTime date, int pag, int element);
        List<Register> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element);
        List<Register> GetByWareHouse(string idWareHouse);
        List<Register> GetByWareHouse(string idWareHouse,int pag,int element);
        List<Register> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element);
        List<Register> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element);

    }
}
