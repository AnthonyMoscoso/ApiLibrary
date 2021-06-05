using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IReservationRepository : IRepository <Reservation>
    {
        #region Count
        double CountByBook(string idBook);
        #endregion

        #region Book
        IEnumerable<Reservation> GetByBook(string idBook);
        IEnumerable<Reservation> GetByBook(string idBook,int pag,int element);

        #endregion

        #region Finalized 
        IEnumerable<Reservation> GetFinalized();
        IEnumerable<Reservation> GetFinalized(int pag,int element);
        
        #endregion

        #region Not Finalized 
        IEnumerable<Reservation> GetNotFinalized();
        IEnumerable<Reservation> GetNotFinalized(int pag,int element);
       
        #endregion

        #region Cancel
        IEnumerable<Reservation> GetCancel();
        IEnumerable<Reservation> GetCancel(int pag,int element);
        
        #endregion

        #region Finalized Date 
        IEnumerable<Reservation> GetByFinalizedDate(DateTime date);
        IEnumerable<Reservation> GetByFinalizedDate(DateTime date,int pag,int element);
        
        #endregion

        #region Date
        IEnumerable<Reservation> GetByDate(DateTime date);
        IEnumerable<Reservation> GetByDate(DateTime date,int pag,int element);
        IEnumerable<Reservation> GetByDate(DateTime start,DateTime end);
        IEnumerable<Reservation> GetByDate(DateTime start, DateTime end,int pag,int element);

        #endregion


        #region Client
        IEnumerable<Reservation> GetByClient(string idClient);
        IEnumerable<Reservation> GetByClient(string idClient,int pag, int element);
        IEnumerable<Reservation> GetByClient(string idClient,DateTime start,DateTime end);
        IEnumerable<Reservation> GetByClient(string idClient, DateTime start, DateTime end, int pag, int element);
        #endregion


    }
}

