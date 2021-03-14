using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Reservations
{
    interface IReservationRepositorie : IRepositorie <Reservation>
    {
        #region Count
        double GetCountBook(string idBook);
        double GetCountBook(string idBook,string idStore);
        #endregion

        #region Book
        List<Reservation> GetByBook(string idBook);
        List<Reservation> GetByBook(string idBook,string idStore);
        List<Reservation> GetByBook(string idBook,int pag,int element);
        List<Reservation> GetByBook(string idBook, string idStore, int pag, int element);

        #endregion

        #region GetByStore
        List<Reservation> GetByStore(string idStore);
        List<Reservation> GetByStore(string idStore,int pag,int element);
        List<Reservation> GetByStore( string idStore,DateTime date);
        List<Reservation> GetByStore( string idStore,DateTime date, int pag, int element);
        #endregion

        #region Finalized 
        List<Reservation> GetFinalized();
        List<Reservation> GetFinalized(int pag,int element);
        List<Reservation> GetFinalized( string idStore);
        List<Reservation> GetFinalized(string idStore,int pag, int element);
        #endregion

        #region Not Finalized 
        List<Reservation> GetNotFinalized();
        List<Reservation> GetNotFinalized(int pag,int element);
        List<Reservation> GetNotFinalized(string idStore);
        List<Reservation> GetNotFinalized(string idStore,int pag,int element);
        #endregion

        #region Cancel
        List<Reservation> GetCancel();
        List<Reservation> GetCancel(int pag,int element);
        List<Reservation> GetCancel(string idStore);
        List<Reservation> GetCancel(string idStore,int pag,int element);
        #endregion

        #region Finalized Date 
        List<Reservation> GetByFinalizedDate(DateTime date);
        List<Reservation> GetByFinalizedDate(DateTime date,int pag,int element);
        List<Reservation> GetByFinalizedDate(DateTime date,string idStore);
        List<Reservation> GetByFinalizedDate(DateTime date,string idStore, int pag,int element);
        #endregion

        #region Date
        List<Reservation> GetByDate(DateTime date);
        List<Reservation> GetByDate(DateTime date,int pag,int element);
        List<Reservation> GetByDate(DateTime start,DateTime end);
        List<Reservation> GetByDate(DateTime start, DateTime end,int pag,int element);
        List<Reservation> GetByDate(DateTime start, DateTime end,string idStore);
        List<Reservation> GetByDate(DateTime start, DateTime end, string idStore,int pag,int element);
        #endregion
    }
}
