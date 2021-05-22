using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IShippingRepository : IRepository<Shipping>
    {
        #region GetByStatus
        List<ShippingDto> GetByStatus(int status);
        List<ShippingDto> GetByStatus(int status,int pag,int element);
   
    
        #endregion

        #region GetByArrivalDate
        List<ShippingDto> GetByArrivalDate(DateTime date);
        List<ShippingDto> GetByArrivalDate(DateTime date,int pag,int element);
        List<ShippingDto> GetByArrivalDate(DateTime start, DateTime end);
        List<ShippingDto> GetByArrivalDate(DateTime start,DateTime end,int pag, int element);
        #endregion

        #region GetByDeparture
        List<ShippingDto> GetByDepartureDate(DateTime date);
        List<ShippingDto> GetByDepartureDate(DateTime date,int pag,int element);
        List<ShippingDto> GetByDepartureDate(DateTime start, DateTime end);
        List<ShippingDto> GetByDepartureDate(DateTime start, DateTime end, int pag, int element);
        #endregion

        #region GetByAddress
        List<ShippingDto> GetByRecipientAddress(string idAddrees);
        List<ShippingDto> GetByRecipientAddress(string idAddrees,int pag,int element);
        List<ShippingDto> GetByRecipientAddress( string idRecipient, int status);
        List<ShippingDto> GetByRecipientAddress( string idRecipient, int status, int pag, int element);
        List<ShippingDto> GetByExitAddress(string idAddress);
        List<ShippingDto> GetByExitAddress( string idExitAddress, int status);
        List<ShippingDto> GetByExitAddress( string idExitAddress, int status, int pag, int element);
        List<ShippingDto> GetByExitAddress(string idAddress,int pag,int element);
        #endregion


        List<ShippingDto> GetByBook(string idBook);
        List<ShippingDto> GetByBook(string idBook,int pag,int element);
    }
}
