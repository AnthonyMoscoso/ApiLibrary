using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IShippingRepository : IRepository<Shipping>
    {
        #region GetByStatus
        IEnumerable<Shipping> GetByStatus(int status);
        IEnumerable<Shipping> GetByStatus(int status,int pag,int element);
   
    
        #endregion

        #region GetByArrivalDate
        IEnumerable<Shipping> GetByArrivalDate(DateTime date);
        IEnumerable<Shipping> GetByArrivalDate(DateTime date,int pag,int element);
        IEnumerable<Shipping> GetByArrivalDate(DateTime start, DateTime end);
        IEnumerable<Shipping> GetByArrivalDate(DateTime start,DateTime end,int pag, int element);
        #endregion

        #region GetByDeparture
        IEnumerable<Shipping> GetByDepartureDate(DateTime date);
        IEnumerable<Shipping> GetByDepartureDate(DateTime date,int pag,int element);
        IEnumerable<Shipping> GetByDepartureDate(DateTime start, DateTime end);
        IEnumerable<Shipping> GetByDepartureDate(DateTime start, DateTime end, int pag, int element);
        #endregion

        #region GetByAddress
        IEnumerable<Shipping> GetByRecipientAddress(string idAddrees);
        IEnumerable<Shipping> GetByRecipientAddress(string idAddrees,int pag,int element);
        IEnumerable<Shipping> GetByRecipientAddress( string idRecipient, int status);
        IEnumerable<Shipping> GetByRecipientAddress( string idRecipient, int status, int pag, int element);
        IEnumerable<Shipping> GetByExitAddress(string idAddress);
        IEnumerable<Shipping> GetByExitAddress( string idExitAddress, int status);
        IEnumerable<Shipping> GetByExitAddress( string idExitAddress, int status, int pag, int element);
        IEnumerable<Shipping> GetByExitAddress(string idAddress,int pag,int element);
        #endregion


        IEnumerable<Shipping> GetByBook(string idBook);
        IEnumerable<Shipping> GetByBook(string idBook,int pag,int element);
    }
}
