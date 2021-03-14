using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Shippings
{
    interface IShippingRepositorie : IRepositorie<Shipping>
    {
        #region GetByStatus
        List<Shipping> GetByStatus(int status);
        List<Shipping> GetByStatus(int status,int pag,int element);
   
    
        #endregion

        #region GetByArrivalDate
        List<Shipping> GetByArrivalDate(DateTime date);
        List<Shipping> GetByArrivalDate(DateTime date,int pag,int element);
        List<Shipping> GetByArrivalDate(DateTime start, DateTime end);
        List<Shipping> GetByArrivalDate(DateTime start,DateTime end,int pag, int element);
        #endregion

        #region GetByDeparture
        List<Shipping> GetByDepartureDate(DateTime date);
        List<Shipping> GetByDepartureDate(DateTime date,int pag,int element);
        List<Shipping> GetByDepartureDate(DateTime start, DateTime end);
        List<Shipping> GetByDepartureDate(DateTime start, DateTime end, int pag, int element);
        #endregion

        #region GetByAddress
        List<Shipping> GetByRecipientAddress(string idAddrees);
        List<Shipping> GetByRecipientAddress(string idAddrees,int pag,int element);
        List<Shipping> GetByRecipientAddress( string idRecipient, int status);
        List<Shipping> GetByRecipientAddress( string idRecipient, int status, int pag, int element);
        List<Shipping> GetByExitAddress(string idAddress);
        List<Shipping> GetByExitAddress( string idExitAddress, int status);
        List<Shipping> GetByExitAddress( string idExitAddress, int status, int pag, int element);
        List<Shipping> GetByExitAddress(string idAddress,int pag,int element);
        #endregion


        List<Shipping> GetByBook(string idBook);
        List<Shipping> GetByBook(string idBook,int pag,int element);
    }
}
