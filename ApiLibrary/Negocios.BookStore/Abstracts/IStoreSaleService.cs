using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IStoreSaleService : IServices<StoreSaleDto>
    {
        #region GetByStore
        IEnumerable<StoreSaleDto> GetByStore(string idStore);
        IEnumerable<StoreSaleDto> GetByStore(string idStore, int pag, int element);
        IEnumerable<StoreSaleDto> GetByStore(string idStore, DateTime date);
        IEnumerable<StoreSaleDto> GetByStore(string idStore, DateTime date, int pag, int element);
        IEnumerable<StoreSaleDto> GetByStore(string idStore, DateTime start, DateTime end);
        IEnumerable<StoreSaleDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);
        #endregion

        #region GetByDate 
        IEnumerable<StoreSaleDto> GetByDate(DateTime date);
        IEnumerable<StoreSaleDto> GetByDate(DateTime date, int pag, int element);
        IEnumerable<StoreSaleDto> GetByDate(DateTime start, DateTime end);
        IEnumerable<StoreSaleDto> GetByDate(DateTime start, DateTime end, int pag, int element);

        #endregion


        #region GetByStatus 

        IEnumerable<StoreSaleDto> GetByStatus(int status, string idStore);
        IEnumerable<StoreSaleDto> GetByStatus(int status, string idStore, int pag, int element);
        #endregion
    }
}
