using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IReturnSaleRepository : IRepository<ReturnSale>
    {
        #region GetByMethod
        List<ReturnSaleDto> GetByMethod(int RepaymentMethod);
        List<ReturnSaleDto> GetByMethod(int RepaymentMethod, int pag, int element);
        List<ReturnSaleDto> GetByMethod(int RepaymentMethod, string idStore);
        List<ReturnSaleDto> GetByMethod(int RepaymentMethod, string idStore, int pag, int element);

        #endregion

        #region GetByMotive

        List<ReturnSaleDto> GetByMotive(string motive);
        List<ReturnSaleDto> GetByMotive(string motive, int pag, int element);
        List<ReturnSaleDto> GetByMotive(string motive, string idStore);
        List<ReturnSaleDto> GetByMotive(string motive, string idStore, int pag, int element);
        #endregion



        #region GetBySale 
        List<ReturnSaleDto> GetBySale(string idSale);

        #endregion

        #region GetByDate 
        List<ReturnSaleDto> GetByDate(DateTime date);
        List<ReturnSaleDto> GetByDate(DateTime date, int pag, int element);
        List<ReturnSaleDto> GetByDate(DateTime start, DateTime end);
        List<ReturnSaleDto> GetByDate(DateTime start, DateTime end, int pag, int element);
        #endregion


        #region By WareHouse

        IList<ReturnSaleDto> GetByWareHouse(string idWareHouse);
        IList<ReturnSaleDto> GetByWareHouse(string idWareHouse, int pag, int element);
        IList<ReturnSaleDto> GetByWareHouse(string idWareHouse, DateTime start, DateTime end);
        IList<ReturnSaleDto> GetByWareHouse(string idWareHouse, DateTime start, DateTime end, int pag, int element);

        #endregion


        #region GetByStore
        IList<ReturnSaleDto> GetByStore(string idStore);
        IList<ReturnSaleDto> GetByStore(string idStore, int pag, int element);
        IList<ReturnSaleDto> GetByStore(string idStore, DateTime start, DateTime end);
        IList<ReturnSaleDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);
        #endregion


        #region Insert - Update - Delete

        dynamic Insert(IList<ReturnSaleDto> list);
        dynamic Update(IList<ReturnSaleDto> list);

        new dynamic Delete(List<string>ids);
        #endregion

    }
}
