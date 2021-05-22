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
        List<StoreSaleDto> GetByStore(string idStore);
        List<StoreSaleDto> GetByStore(string idStore, int pag, int element);
        List<StoreSaleDto> GetByStore(string idStore, DateTime date);
        List<StoreSaleDto> GetByStore(string idStore, DateTime date, int pag, int element);
        List<StoreSaleDto> GetByStore(string idStore, DateTime start, DateTime end);
        List<StoreSaleDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);
        #endregion

        #region GetByDate 
        List<StoreSaleDto> GetByDate(DateTime date);
        List<StoreSaleDto> GetByDate(DateTime date, int pag, int element);
        List<StoreSaleDto> GetByDate(DateTime start, DateTime end);
        List<StoreSaleDto> GetByDate(DateTime start, DateTime end, int pag, int element);

        #endregion

        dynamic Insert(List<StoreSaleDto> list);
        dynamic Update(List<StoreSaleDto> list);
    }
}
