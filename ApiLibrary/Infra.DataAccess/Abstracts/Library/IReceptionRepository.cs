using Models.Ado.Library;
using System;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IReceptionRepository : IRepository<Reception>
    {
        IEnumerable<Reception> GetByDate(DateTime date);
        IEnumerable<Reception> GetByDate(DateTime date,int pag,int element);
        IEnumerable<Reception> GetByDate(DateTime dateStart,DateTime dateEnd);
        IEnumerable<Reception> GetByDate(DateTime dateStart, DateTime dateEnd,int pag, int element);
        IEnumerable<Reception> GetByStore(string idStore);
        IEnumerable<Reception> GetByStore(string idStore,int pag,int element);
        IEnumerable<Reception> GetByStore(string idStore, DateTime date);
        IEnumerable<Reception> GetByStore(string idStore,DateTime date,int pag,int element);
        IEnumerable<Reception> GetByOrder(string idOrder);
        IEnumerable<Reception> GetByPurchase(string idPurchase);
    }
}
