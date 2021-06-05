using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Models.Repositories.Abstract
{
    public interface IStoreSaleRepository : IRepository<StoreSale>
    {


        #region GetByStore
        IEnumerable<StoreSale> GetByStore(string idStore);
        IEnumerable<StoreSale> GetByStore(string idStore, int pag, int element);
        IEnumerable<StoreSale> GetByStore(string idStore, DateTime date);
        IEnumerable<StoreSale> GetByStore(string idStore, DateTime date, int pag, int element);
        IEnumerable<StoreSale> GetByStore(string idStore, DateTime start, DateTime end);
        IEnumerable<StoreSale> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);
        #endregion

        #region GetByDate 
        IEnumerable<StoreSale> GetByDate(DateTime date);
        IEnumerable<StoreSale> GetByDate(DateTime date, int pag, int element);
        IEnumerable<StoreSale> GetByDate(DateTime start, DateTime end);
        IEnumerable<StoreSale> GetByDate(DateTime start, DateTime end, int pag, int element);

        #endregion


        #region GetByStatus 

        IEnumerable<StoreSale> GetByStatus(int status, string idStore);
        IEnumerable<StoreSale> GetByStatus(int status, string idStore, int pag, int element);
        #endregion
    }
}
