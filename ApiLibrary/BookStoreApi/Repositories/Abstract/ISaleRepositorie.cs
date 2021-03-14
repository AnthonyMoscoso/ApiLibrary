using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Sales
{
    interface ISaleRepositorie : IRepositorie <Sale>
    {
        #region GetByDate 
        List<Sale> GetByDate(DateTime date);
        List<Sale> GetByDate(DateTime date,int pag,int element);
        List<Sale> GetByDate(DateTime start,DateTime end);
        List<Sale> GetByDate(DateTime start, DateTime end,int pag,int element);

        #endregion

        #region GetByStore
        List<Sale> GetByStore(string idStore);
        List<Sale> GetByStore(string idStore,int pag,int element);
        List<Sale> GetByStore(string idStore,DateTime date);
        List<Sale> GetByStore(string idStore, DateTime date, int pag, int element);
        List<Sale> GetByStore(string idStore,DateTime start, DateTime end);
        List<Sale> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);
        #endregion

        #region GetByBuyer
        List<Sale> GetByBuyer(string idBuyer);
        List<Sale> GetByBuyer(string idBuyer,int pag,int element);
        List<Sale> GetByBuyer(string idBuyer,DateTime date);
        List<Sale> GetByBuyer(string idBuyer,DateTime date,int pag,int element);
        List<Sale> GetByBuyer(string idBuyer,DateTime start,DateTime end);
        List<Sale> GetByBuyer(string idBuyer,DateTime start,DateTime end,int pag,int element);
        #endregion

        #region GetBySaleStatus
        List<Sale> GetBySaleStatus(int status);
        List<Sale> GetBySaleStatus(int status, int pag, int element);
        List<Sale> GetBySaleStatus(int status, string idStore);
        List<Sale> GetBySaleStatus(int status,string idStore,int pag,int element);
        #endregion

        #region GetByPayMethod
        List<Sale> GetByPayMethod(int payMethod);
        List<Sale> GetByPayMethod(int payMethod, int pag, int element);
        List<Sale> GetByPayMethod(int payMethod,string idStore);
        List<Sale> GetByPayMethod(int payMethod,string idStore, int pag, int element);
        #endregion
    }
}
