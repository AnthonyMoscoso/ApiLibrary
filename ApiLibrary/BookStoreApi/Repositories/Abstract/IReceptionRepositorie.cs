using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Receptions
{
    interface IReceptionRepositorie : IRepositorie<Reception>
    {
        List<Reception> GetByDate(DateTime date);
        List<Reception> GetByDate(DateTime date,int pag,int element);
        List<Reception> GetByDate(DateTime dateStart,DateTime dateEnd);
        List<Reception> GetByDate(DateTime dateStart, DateTime dateEnd,int pag, int element);
        List<Reception> GetByStore(string idStore);
        List<Reception> GetByStore(string idStore,int pag,int element);
        List<Reception> GetByStore(string idStore, DateTime date);
        List<Reception> GetByStore(string idStore,DateTime date,int pag,int element);


    }
}
