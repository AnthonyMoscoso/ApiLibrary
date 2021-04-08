using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract
{
    interface IStoreSaleRepository : IRepository<StoreSale>
    {
        List<StoreSaleDto> GetByStatus(int status);
        List<StoreSaleDto> GetByStatus(int status, int pag, int element);
        List<StoreSaleDto> GetByStatus(int status, string idStore);
        List<StoreSaleDto> GetByStatus(int status, string idStore, int pag, int element);

        List<StoreSaleDto> GetByPayMethod(int payMethod);
        List<StoreSaleDto> GetByPayMethod(int payMethod, int pag, int element);
        List<StoreSaleDto> GetByPayMethod(int payMethod, string idStore);
        List<StoreSaleDto> GetByPayMethod(int payMethod, string idStore, int pag, int element);


        #region GetByStore
        List<StoreSaleDto> GetByStore(string idStore);
        List<StoreSaleDto> GetByStore(string idStore, int pag, int element);
        List<StoreSaleDto> GetByStore(string idStore, DateTime date);
        List<StoreSaleDto> GetByStore(string idStore, DateTime date, int pag, int element);
        List<StoreSaleDto> GetByStore(string idStore, DateTime start, DateTime end);
        List<StoreSaleDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);
        #endregion


        #region GetByBuyer
        List<StoreSaleDto> GetByBuyer(string idBuyer);
        List<StoreSaleDto> GetByBuyer(string idBuyer, int pag, int element);
        List<StoreSaleDto> GetByBuyer(string idBuyer, DateTime date);
        List<StoreSaleDto> GetByBuyer(string idBuyer, DateTime date, int pag, int element);
        List<StoreSaleDto> GetByBuyer(string idBuyer, DateTime start, DateTime end);
        List<StoreSaleDto> GetByBuyer(string idBuyer, DateTime start, DateTime end, int pag, int element);
        #endregion

        #region GetByDate 
        List<StoreSaleDto> GetByDate(DateTime date);
        List<StoreSaleDto> GetByDate(DateTime date, int pag, int element);
        List<StoreSaleDto> GetByDate(DateTime start, DateTime end);
        List<StoreSaleDto> GetByDate(DateTime start, DateTime end, int pag, int element);

        #endregion
    }
}
