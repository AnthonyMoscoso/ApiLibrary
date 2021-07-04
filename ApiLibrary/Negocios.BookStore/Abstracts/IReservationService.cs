using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IReservationService : IServices<ReservationDto>
    {
        #region Count
        double CountByBook(string idBook);
        #endregion

        #region Book
        IEnumerable<ReservationDto> GetByBook(string idBook);
        IEnumerable<ReservationDto> GetByBook(string idBook, int pag, int element);

        #endregion

        #region Finalized 
        IEnumerable<ReservationDto> GetFinalized();
        IEnumerable<ReservationDto> GetFinalized(int pag, int element);

        #endregion

        #region Not Finalized 
        IEnumerable<ReservationDto> GetNotFinalized();
        IEnumerable<ReservationDto> GetNotFinalized(int pag, int element);

        #endregion

        #region Cancel
        IEnumerable<ReservationDto> GetCancel();
        IEnumerable<ReservationDto> GetCancel(int pag, int element);

        #endregion

        #region Finalized Date 
        IEnumerable<ReservationDto> GetByFinalizedDate(DateTime date);
        IEnumerable<ReservationDto> GetByFinalizedDate(DateTime date, int pag, int element);

        #endregion

        #region Date
        IEnumerable<ReservationDto> GetByDate(DateTime date);
        IEnumerable<ReservationDto> GetByDate(DateTime date, int pag, int element);
        IEnumerable<ReservationDto> GetByDate(DateTime start, DateTime end);
        IEnumerable<ReservationDto> GetByDate(DateTime start, DateTime end, int pag, int element);

        #endregion


        #region Client
        IEnumerable<ReservationDto> GetByClient(string idClient);
        IEnumerable<ReservationDto> GetByClient(string idClient, int pag, int element);
        IEnumerable<ReservationDto> GetByClient(string idClient, DateTime start, DateTime end);
        IEnumerable<ReservationDto> GetByClient(string idClient, DateTime start, DateTime end, int pag, int element);
        #endregion

    }
}
