using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IReturnSaleRepository : IRepository<ReturnSale>
    {
        #region GetByMethod
        IEnumerable<ReturnSale> GetByMethod(int RepaymentMethod);
        IEnumerable<ReturnSale> GetByMethod(int RepaymentMethod, int pag, int element);
        IEnumerable<ReturnSale> GetByMethod(int RepaymentMethod, string idStore);
        IEnumerable<ReturnSale> GetByMethod(int RepaymentMethod, string idStore, int pag, int element);

        #endregion

        #region GetByMotive

        IEnumerable<ReturnSale> GetByMotive(string motive);
        IEnumerable<ReturnSale> GetByMotive(string motive, int pag, int element);
        IEnumerable<ReturnSale> GetByMotive(string motive, string idStore);
        IEnumerable<ReturnSale> GetByMotive(string motive, string idStore, int pag, int element);
        #endregion



        #region GetBySale 
        IEnumerable<ReturnSale> GetBySale(string idSale);

        #endregion

        #region GetByDate 
        IEnumerable<ReturnSale> GetByDate(DateTime date);
        IEnumerable<ReturnSale> GetByDate(DateTime date, int pag, int element);
        IEnumerable<ReturnSale> GetByDate(DateTime start, DateTime end);
        IEnumerable<ReturnSale> GetByDate(DateTime start, DateTime end, int pag, int element);
        #endregion


        #region By WareHouse

        IEnumerable<ReturnSale> GetByWareHouse(string idWareHouse);
        IEnumerable<ReturnSale> GetByWareHouse(string idWareHouse, int pag, int element);
        IEnumerable<ReturnSale> GetByWareHouse(string idWareHouse, DateTime start, DateTime end);
        IEnumerable<ReturnSale> GetByWareHouse(string idWareHouse, DateTime start, DateTime end, int pag, int element);

        #endregion


        #region GetByStore
        IEnumerable<ReturnSale> GetByStore(string idStore);
        IEnumerable<ReturnSale> GetByStore(string idStore, int pag, int element);
        IEnumerable<ReturnSale> GetByStore(string idStore, DateTime start, DateTime end);
        IEnumerable<ReturnSale> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);
        #endregion


        #region Insert - Update - Delete

        new dynamic Delete(IEnumerable<string>ids);
        #endregion

    }
}
