using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface ISaleService : IServices<SaleDto>
    {
        #region GetByDate 
        IEnumerable<SaleDto> GetByDate(DateTime date);
        IEnumerable<SaleDto> GetByDate(DateTime date, int pag, int element);
        IEnumerable<SaleDto> GetByDate(DateTime start, DateTime end);
        IEnumerable<SaleDto> GetByDate(DateTime start, DateTime end, int pag, int element);

        #endregion



        #region GetByBuyer
        IEnumerable<SaleDto> GetByBuyer(string idBuyer);
        IEnumerable<SaleDto> GetByBuyer(string idBuyer, int pag, int element);
        IEnumerable<SaleDto> GetByBuyer(string idBuyer, DateTime date);
        IEnumerable<SaleDto> GetByBuyer(string idBuyer, DateTime date, int pag, int element);
        IEnumerable<SaleDto> GetByBuyer(string idBuyer, DateTime start, DateTime end);
        IEnumerable<SaleDto> GetByBuyer(string idBuyer, DateTime start, DateTime end, int pag, int element);
        #endregion

        #region GetBySaleStatus
        IEnumerable<SaleDto> GetBySaleStatus(int status);
        IEnumerable<SaleDto> GetBySaleStatus(int status, int pag, int element);


        #endregion

        #region GetByPayMethod
        IEnumerable<SaleDto> GetByPayMethod(int payMethod);
        IEnumerable<SaleDto> GetByPayMethod(int payMethod, int pag, int element);


        #endregion

    }
}
