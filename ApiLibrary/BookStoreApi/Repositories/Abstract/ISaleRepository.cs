using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Sales
{
    interface ISaleRepository : IRepository <Sale>
    {
        #region GetByDate 
        List<SaleDto> GetByDate(DateTime date);
        List<SaleDto> GetByDate(DateTime date,int pag,int element);
        List<SaleDto> GetByDate(DateTime start,DateTime end);
        List<SaleDto> GetByDate(DateTime start, DateTime end,int pag,int element);

        #endregion

        

        #region GetByBuyer
        List<SaleDto> GetByBuyer(string idBuyer);
        List<SaleDto> GetByBuyer(string idBuyer,int pag,int element);
        List<SaleDto> GetByBuyer(string idBuyer,DateTime date);
        List<SaleDto> GetByBuyer(string idBuyer,DateTime date,int pag,int element);
        List<SaleDto> GetByBuyer(string idBuyer,DateTime start,DateTime end);
        List<SaleDto> GetByBuyer(string idBuyer,DateTime start,DateTime end,int pag,int element);
        #endregion

        #region GetBySaleStatus
        List<SaleDto> GetBySaleStatus(int status);
        List<SaleDto> GetBySaleStatus(int status, int pag, int element);
        List<SaleDto> GetBySaleStatus(int status, string idStore);
        List<SaleDto> GetBySaleStatus(int status, string idStore, int pag, int element);

        #endregion

        #region GetByPayMethod
        List<SaleDto> GetByPayMethod(int payMethod);
        List<SaleDto> GetByPayMethod(int payMethod, int pag, int element);
        List<SaleDto> GetByPayMethod(int payMethod,string idStore);
        List<SaleDto> GetByPayMethod(int payMethod, string idStore, int pag, int element);

        #endregion

      
    }
}
