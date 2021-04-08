using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Returns
{
    interface IReturnSaleRepositorie : IRepository<ReturnSale>
    {
        #region GetByMethod
        List<ReturnSale> GetByMethod(int RepaymentMethod);
        List<ReturnSale> GetByMethod(int RepaymentMethod, int pag,int element);
        List<ReturnSale> GetByMethod(int RepaymentMethod,string idStore);
        List<ReturnSale> GetByMethod(int RepaymentMethod,string idStore,int pag,int element);

        #endregion

        #region GetByMotive

        List<ReturnSale> GetByMotive(string motive);
        List<ReturnSale> GetByMotive(string motive,int pag, int element);
        List<ReturnSale> GetByMotive(string motive, string idStore);
        List<ReturnSale> GetByMotive(string motive, string idStore, int pag, int element);
        #endregion

        #region GetByStore
        List<ReturnSale> GetByStore(string idStore);
        List<ReturnSale> GetByStore(string idStore,int pag,int element);
        #endregion

        #region GetBySale 
        List<ReturnSale> GetBySale(string idSale);

        #endregion

        #region GetByDate 
        List<ReturnSale> GetByDate(DateTime date);
        List<ReturnSale> GetByDate(DateTime date,int pag,int element);
        List<ReturnSale> GetByDate(DateTime start,DateTime end);
        List<ReturnSale> GetByDate(DateTime start, DateTime end, int pag, int element);
        #endregion
    }
}
