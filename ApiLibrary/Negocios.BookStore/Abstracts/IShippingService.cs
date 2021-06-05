using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IShippingService : IServices<ShippingDto>
    {
        #region GetByStatus
        IEnumerable<ShippingDto> GetByStatus(int status);
        IEnumerable<ShippingDto> GetByStatus(int status, int pag, int element);


        #endregion

        #region GetByArrivalDate
        IEnumerable<ShippingDto> GetByArrivalDate(DateTime date);
        IEnumerable<ShippingDto> GetByArrivalDate(DateTime date, int pag, int element);
        IEnumerable<ShippingDto> GetByArrivalDate(DateTime start, DateTime end);
        IEnumerable<ShippingDto> GetByArrivalDate(DateTime start, DateTime end, int pag, int element);
        #endregion

        #region GetByDeparture
        IEnumerable<ShippingDto> GetByDepartureDate(DateTime date);
        IEnumerable<ShippingDto> GetByDepartureDate(DateTime date, int pag, int element);
        IEnumerable<ShippingDto> GetByDepartureDate(DateTime start, DateTime end);
        IEnumerable<ShippingDto> GetByDepartureDate(DateTime start, DateTime end, int pag, int element);
        #endregion

        #region GetByAddress
        IEnumerable<ShippingDto> GetByRecipientAddress(string idAddrees);
        IEnumerable<ShippingDto> GetByRecipientAddress(string idAddrees, int pag, int element);
        IEnumerable<ShippingDto> GetByRecipientAddress(string idRecipient, int status);
        IEnumerable<ShippingDto> GetByRecipientAddress(string idRecipient, int status, int pag, int element);
        IEnumerable<ShippingDto> GetByExitAddress(string idAddress);
        IEnumerable<ShippingDto> GetByExitAddress(string idExitAddress, int status);
        IEnumerable<ShippingDto> GetByExitAddress(string idExitAddress, int status, int pag, int element);
        IEnumerable<ShippingDto> GetByExitAddress(string idAddress, int pag, int element);
        #endregion


        IEnumerable<ShippingDto> GetByBook(string idBook);
        IEnumerable<ShippingDto> GetByBook(string idBook, int pag, int element);
    }
}
