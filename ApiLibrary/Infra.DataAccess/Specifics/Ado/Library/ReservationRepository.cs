using Models.Ado.Library;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Core.DBAccess.Ado;
using Nucleo.Utilities.Enums;

namespace Ado.Library.Specifics
{
    public class ReservationRepository : AdoRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(BookStoreEntities context, string identificator="IdReservation") : base(context,identificator)
        {
        }

        #region Count

        public double CountByBook(string idBook)
        {
            return dbSet.Count(w => w.IdBook.Equals(idBook));
        }
        #endregion

        #region Get By Book
        public IEnumerable<Reservation> GetByBook(string idBook)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.IdBook.Equals(idBook));
            return result;
        }

        public IEnumerable<Reservation> GetByBook(string idBook, int pag, int element)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.IdBook.Equals(idBook))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return result;
        }

        #endregion

        #region Get By Date
        public IEnumerable<Reservation> GetByDate(DateTime date)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date));
            return (result);
        }

        public IEnumerable<Reservation> GetByDate(DateTime date, int pag, int element)
        {
            IQueryable<Reservation> result = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)).Skip((pag - 1) * element).Take(element);
            return (result);
        }
        public IEnumerable<Reservation> GetByDate(DateTime start, DateTime end)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(start) && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(end) && DbFunctions.TruncateTime(w.FinishReservationDate) <= DbFunctions.TruncateTime(end) && DbFunctions.TruncateTime(w.FinishReservationDate) >= DbFunctions.TruncateTime(start));
            return (result);
        }

        public IEnumerable<Reservation> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(start) && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(end) && DbFunctions.TruncateTime(w.FinishReservationDate) <= DbFunctions.TruncateTime(end) && DbFunctions.TruncateTime(w.FinishReservationDate) >= DbFunctions.TruncateTime(start)).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
            return (result);
        }




        #endregion



        #region Get By Finalized Date
        public IEnumerable<Reservation> GetByFinalizedDate(DateTime date)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.FinishReservationDate.Value.Date < date.Date);
            return (result);
        }

        public IEnumerable<Reservation> GetByFinalizedDate(DateTime date, int pag, int element)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.FinishReservationDate.Value.Date < date.Date).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
            return (result);
        }



        #endregion

        #region Cancel 
        public IEnumerable<Reservation> GetCancel()
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.ReservationStatus == (int)ReservationStatus.Cancel);
            return (result);
        }

        public IEnumerable<Reservation> GetCancel(int pag, int element)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.ReservationStatus == (int)ReservationStatus.Cancel).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
            return (result);
        }



        #endregion

        #region Finalized 
        public IEnumerable<Reservation> GetFinalized()
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.FinishReservationDate.Value <= DateTime.Now);
            return (result);
        }

        public IEnumerable<Reservation> GetFinalized(int pag, int element)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.FinishReservationDate.Value <= DateTime.Now).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
            return (result);
        }


        #endregion

        #region Not Finalized 
        public IEnumerable<Reservation> GetNotFinalized()
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.FinishReservationDate.Value.Date > DateTime.Now.Date || !w.FinishReservationDate.HasValue);
            return (result);
        }

        public IEnumerable<Reservation> GetNotFinalized(int pag, int element)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.FinishReservationDate.Value.Date > DateTime.Now.Date || !w.FinishReservationDate.HasValue).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
            return (result);
        }

        public IEnumerable<Reservation> GetByClient(string idClient)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.Person.IdPerson.Equals(idClient));
            return (result);
        }

        public IEnumerable<Reservation> GetByClient(string idClient, int pag, int element)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.Person.IdPerson.Equals(idClient)).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
            return (result);
        }

        public IEnumerable<Reservation> GetByClient(string idClient, DateTime start, DateTime end)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.Person.IdPerson.Equals(idClient) && (DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(start) && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(end)) && (DbFunctions.TruncateTime(w.FinishReservationDate.Value) >= DbFunctions.TruncateTime(start) && DbFunctions.TruncateTime(w.FinishReservationDate.Value) <= DbFunctions.TruncateTime(end)));
            return (result);
        }

        public IEnumerable<Reservation> GetByClient(string idClient, DateTime start, DateTime end, int pag, int element)
        {
            IEnumerable<Reservation> result = dbSet.Where(w => w.Person.IdPerson.Equals(idClient) && (DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(start) && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(end)) && (DbFunctions.TruncateTime(w.FinishReservationDate.Value) >= DbFunctions.TruncateTime(start) && DbFunctions.TruncateTime(w.FinishReservationDate.Value) <= DbFunctions.TruncateTime(end))).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
            return (result);
        }


        #endregion
    }
}