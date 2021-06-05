using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IReturnSaleService : IServices<ReturnSaleDto>
    {
        #region GetByMethod
        IEnumerable<ReturnSaleDto> GetByMethod(int RepaymentMethod);
        IEnumerable<ReturnSaleDto> GetByMethod(int RepaymentMethod, int pag, int element);
        IEnumerable<ReturnSaleDto> GetByMethod(int RepaymentMethod, string idStore);
        IEnumerable<ReturnSaleDto> GetByMethod(int RepaymentMethod, string idStore, int pag, int element);

        #endregion

        #region GetByMotive

        IEnumerable<ReturnSaleDto> GetByMotive(string motive);
        IEnumerable<ReturnSaleDto> GetByMotive(string motive, int pag, int element);
        IEnumerable<ReturnSaleDto> GetByMotive(string motive, string idStore);
        IEnumerable<ReturnSaleDto> GetByMotive(string motive, string idStore, int pag, int element);
        #endregion



        #region GetBySale 
        IEnumerable<ReturnSaleDto> GetBySale(string idSale);

        #endregion

        #region GetByDate 
        IEnumerable<ReturnSaleDto> GetByDate(DateTime date);
        IEnumerable<ReturnSaleDto> GetByDate(DateTime date, int pag, int element);
        IEnumerable<ReturnSaleDto> GetByDate(DateTime start, DateTime end);
        IEnumerable<ReturnSaleDto> GetByDate(DateTime start, DateTime end, int pag, int element);
        #endregion


        #region By WareHouse

        IEnumerable<ReturnSaleDto> GetByWareHouse(string idWareHouse);
        IEnumerable<ReturnSaleDto> GetByWareHouse(string idWareHouse, int pag, int element);
        IEnumerable<ReturnSaleDto> GetByWareHouse(string idWareHouse, DateTime start, DateTime end);
        IEnumerable<ReturnSaleDto> GetByWareHouse(string idWareHouse, DateTime start, DateTime end, int pag, int element);

        #endregion


        #region GetByStore
        IEnumerable<ReturnSaleDto> GetByStore(string idStore);
        IEnumerable<ReturnSaleDto> GetByStore(string idStore, int pag, int element);
        IEnumerable<ReturnSaleDto> GetByStore(string idStore, DateTime start, DateTime end);
        IEnumerable<ReturnSaleDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);
        #endregion
    }
}
