using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface ISaleRepository : IRepository <Sale>
    {
        #region GetByDate 
        IEnumerable<Sale> GetByDate(DateTime date);
        IEnumerable<Sale> GetByDate(DateTime date,int pag,int element);
        IEnumerable<Sale> GetByDate(DateTime start,DateTime end);
        IEnumerable<Sale> GetByDate(DateTime start, DateTime end,int pag,int element);

        #endregion

        

        #region GetByBuyer
        IEnumerable<Sale> GetByBuyer(string idBuyer);
        IEnumerable<Sale> GetByBuyer(string idBuyer,int pag,int element);
        IEnumerable<Sale> GetByBuyer(string idBuyer,DateTime date);
        IEnumerable<Sale> GetByBuyer(string idBuyer,DateTime date,int pag,int element);
        IEnumerable<Sale> GetByBuyer(string idBuyer,DateTime start,DateTime end);
        IEnumerable<Sale> GetByBuyer(string idBuyer,DateTime start,DateTime end,int pag,int element);
        #endregion

        #region GetBySaleStatus
        IEnumerable<Sale> GetBySaleStatus(int status);
        IEnumerable<Sale> GetBySaleStatus(int status, int pag, int element);
     

        #endregion

        #region GetByPayMethod
        IEnumerable<Sale> GetByPayMethod(int payMethod);
        IEnumerable<Sale> GetByPayMethod(int payMethod, int pag, int element);
      

        #endregion

      
    }
}
