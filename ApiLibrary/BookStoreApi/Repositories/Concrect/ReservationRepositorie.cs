using BookStoreApi.Dtos;
using BookStoreApi.Enums;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Reservations;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Reservations
{
    public class ReservationRepositorie : Repository<Reservation,ReservationDto>, IReservationRepositorie
    {
        public ReservationRepositorie(string identificator="IdReservation") : base(identificator)
        {
        }

        #region Count
        public double GetCountBook(string idBook, string idStore)
        {
            return dbSet.Count(w => w.IdBook.Equals(idBook) && w.IdStore.Equals(idStore));

        }

        public double GetCountBook(string idBook)
        {
            return dbSet.Count(w => w.IdBook.Equals(idBook));
        }
        #endregion

        #region Get By Book
        public List<ReservationDto> GetByBook(string idBook)
        {
            var result = dbSet.Where(w => w.IdBook.Equals(idBook)).ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

        public List<Reservation> GetByBook(string idBook, int pag, int element)
        {
            return dbSet.Where(w => w.IdBook.Equals(idBook))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Reservation> GetByBook(string idBook, string idStore)
        {
            return dbSet.Where(w => w.IdBook.Equals(idBook) && w.IdStore.Equals(idStore)).ToList();
        }

        public List<Reservation> GetByBook(string idBook, string idStore, int pag, int element)
        {

            return dbSet.Where(w => w.IdBook.Equals(idBook) && w.IdStore.Equals(idStore))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion

        #region Get By Date
        public List<Reservation> GetByDate(DateTime date)
        {
            return dbSet.Where(w => w.CreateDate.Date.Equals(date.Date)).ToList();
        }

        public List<Reservation> GetByDate(DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate.Date.Equals(date.Date)).Skip((pag - 1) * element).Take(element).ToList();
        }
        public List<Reservation> GetByDate(DateTime start, DateTime end)
        {
            return dbSet.Where(w => (w.CreateDate.Date >= start.Date && w.CreateDate.Date <= end.Date) ||
            (w.FinishReservationDate.Value.Date >= start.Date && w.FinishReservationDate.Value.Date <= end.Date)).ToList();
        }

        public List<Reservation> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            return dbSet.Where(w => (w.CreateDate.Date >= start.Date && w.CreateDate.Date <= end.Date) ||
           (w.FinishReservationDate.Value.Date >= start.Date && w.FinishReservationDate.Value.Date <= end.Date))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        public List<Reservation> GetByDate(DateTime start, DateTime end, string idStore)
        {
            return dbSet.Where(w => (w.CreateDate.Date >= start.Date && w.CreateDate.Date <= end.Date) ||
            (w.FinishReservationDate.Value.Date >= start.Date && w.FinishReservationDate.Value.Date <= end.Date) && w.IdStore.Equals(idStore)).ToList();
        }

        public List<Reservation> GetByDate(DateTime start, DateTime end, string idStore, int pag, int element)
        {
            return dbSet.Where(w => (w.CreateDate.Date >= start.Date && w.CreateDate.Date <= end.Date) ||
          (w.FinishReservationDate.Value.Date >= start.Date && w.FinishReservationDate.Value.Date <= end.Date) && w.IdStore.Equals(idStore))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        #endregion

        #region Get By Store
        public List<Reservation> GetByStore(string idStore)
        {
            return dbSet.Where(w => w.IdStore.Equals(idStore)).ToList();
        }

        public List<Reservation> GetByStore(string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.IdStore.Equals(idStore))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
        public List<Reservation> GetByStore(string idStore, DateTime date)
        {
            return dbSet.Where(w => w.CreateDate.Date.Equals(date.Date) && w.IdStore.Equals(idStore)).ToList();
        }

        public List<Reservation> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.CreateDate.Date.Equals(date.Date) && w.IdStore.Equals(idStore))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion

        #region Get By Finalized Date
        public List<Reservation> GetByFinalizedDate(DateTime date)
        {
            return dbSet.Where(w => w.FinishReservationDate.Value.Date <date.Date).ToList();
        }

        public List<Reservation> GetByFinalizedDate(DateTime date, int pag, int element)
        {
            return dbSet.Where(w => w.FinishReservationDate.Value.Date< date.Date)
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        

        public List<Reservation> GetByFinalizedDate( DateTime date, string idStore)
        {
            return dbSet.Where(w => w.FinishReservationDate.Value.Date < date.Date && w.IdStore.Equals(idStore)).ToList();
        }

        public List<Reservation> GetByFinalizedDate( DateTime date, string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.FinishReservationDate.Value.Date < date.Date && w.IdStore.Equals(idStore))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion

        #region Cancel 
        public List<Reservation> GetCancel()
        {
            return dbSet.Where(w=> w.ReservationStatus==(int)ReservationStatus.Cancel).ToList();
        }

        public List<Reservation> GetCancel(int pag, int element)
        {
            return dbSet.Where(w=>w.ReservationStatus==(int)ReservationStatus.Cancel)
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Reservation> GetCancel(string idStore)
        {
            return dbSet.Where(w => w.ReservationStatus == (int)ReservationStatus.Cancel && w.IdStore.Equals(idStore)).ToList();
        }

        public List<Reservation> GetCancel(string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.ReservationStatus == (int)ReservationStatus.Cancel && w.IdStore.Equals(idStore))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        #endregion

        #region Finalized 
        public List<Reservation> GetFinalized()
        {
            return dbSet.Where(w => w.FinishReservationDate.Value <= DateTime.Now).ToList();
        }

        public List<Reservation> GetFinalized(int pag, int element)
        {
            return dbSet.Where(w => w.FinishReservationDate.Value <= DateTime.Now)
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Reservation> GetFinalized(string idStore)
        {
            return dbSet.Where(w => w.FinishReservationDate.Value.Date <= DateTime.Now.Date).ToList();
        }

        public List<Reservation> GetFinalized(string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.FinishReservationDate.Value.Date <= DateTime.Now.Date)
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion

        #region Not Finalized 
        public List<Reservation> GetNotFinalized()
        {
            return dbSet.Where(w => w.FinishReservationDate.Value.Date > DateTime.Now.Date).ToList();
        }

        public List<Reservation> GetNotFinalized(int pag, int element)
        {
            return dbSet.Where(w => w.FinishReservationDate.Value.Date > DateTime.Now.Date)
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Reservation> GetNotFinalized(string idStore)
        {
            return dbSet.Where(w => w.FinishReservationDate.Value.Date > DateTime.Now.Date && w.IdStore.Equals(idStore)).ToList();
        }

        public List<Reservation> GetNotFinalized(string idStore, int pag, int element)
        {
            return dbSet.Where(w => w.FinishReservationDate.Value.Date > DateTime.Now.Date && w.IdStore.Equals(idStore))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }
        #endregion
    }
}