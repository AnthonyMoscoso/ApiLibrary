using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Reservations
{
    interface IReservationRepository : IRepository <Reservation>
    {
        #region Count
        double GetCountBook(string idBook);
        #endregion

        #region Book
        List<ReservationDto> GetByBook(string idBook);
        List<ReservationDto> GetByBook(string idBook,int pag,int element);

        #endregion

        #region Finalized 
        List<ReservationDto> GetFinalized();
        List<ReservationDto> GetFinalized(int pag,int element);
        
        #endregion

        #region Not Finalized 
        List<ReservationDto> GetNotFinalized();
        List<ReservationDto> GetNotFinalized(int pag,int element);
       
        #endregion

        #region Cancel
        List<ReservationDto> GetCancel();
        List<ReservationDto> GetCancel(int pag,int element);
        
        #endregion

        #region Finalized Date 
        List<ReservationDto> GetByFinalizedDate(DateTime date);
        List<ReservationDto> GetByFinalizedDate(DateTime date,int pag,int element);
        
        #endregion

        #region Date
        List<ReservationDto> GetByDate(DateTime date);
        List<ReservationDto> GetByDate(DateTime date,int pag,int element);
        List<ReservationDto> GetByDate(DateTime start,DateTime end);
        List<ReservationDto> GetByDate(DateTime start, DateTime end,int pag,int element);

        #endregion


        #region Client
        List<ReservationDto> GetByClient(string idClient);
        List<ReservationDto> GetByClient(string idClient,int pag, int element);
        List<ReservationDto> GetByClient(string idClient,DateTime start,DateTime end);
        List<ReservationDto> GetByClient(string idClient, DateTime start, DateTime end, int pag, int element);
        #endregion

        #region Count
        
        #endregion
    }
}

