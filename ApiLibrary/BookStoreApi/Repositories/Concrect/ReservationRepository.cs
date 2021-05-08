using BookStoreApi.Dtos;
using BookStoreApi.Enums;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Reservations;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Reservations
{
    public class ReservationRepository : Repository<Reservation,ReservationDto>, IReservationRepository
    {
        public ReservationRepository(string identificator="IdReservation") : base(identificator)
        {
        }

        #region Count

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

        public List<ReservationDto> GetByBook(string idBook, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdBook.Equals(idBook))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

        #endregion

        #region Get By Date
        public List<ReservationDto> GetByDate(DateTime date)
        {
            var result = dbSet.Where(w =>DbFunctions.TruncateTime( w.CreateDate)== DbFunctions.TruncateTime(date)).ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

        public List<ReservationDto> GetByDate(DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date))
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }
        public List<ReservationDto> GetByDate(DateTime start, DateTime end)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(start ) 
            && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(end)
            && DbFunctions.TruncateTime (w.FinishReservationDate) <= DbFunctions.TruncateTime(end)
            && DbFunctions.TruncateTime(w.FinishReservationDate) >= DbFunctions.TruncateTime(start))
                .ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

        public List<ReservationDto> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            var result = dbSet.Where(w => DbFunctions.TruncateTime( w.CreateDate) >= DbFunctions.TruncateTime( start) 
            && DbFunctions.TruncateTime( w.CreateDate) <= DbFunctions.TruncateTime(end)
            && DbFunctions.TruncateTime(w.FinishReservationDate) <= DbFunctions.TruncateTime(end)
            && DbFunctions.TruncateTime(w.FinishReservationDate) >= DbFunctions.TruncateTime(start))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }




        #endregion

      

        #region Get By Finalized Date
        public List<ReservationDto> GetByFinalizedDate(DateTime date)
        {
            var result = dbSet.Where(w => w.FinishReservationDate.Value.Date <date.Date).ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

        public List<ReservationDto> GetByFinalizedDate(DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => w.FinishReservationDate.Value.Date< date.Date)
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }
        

    
        #endregion

        #region Cancel 
        public List<ReservationDto> GetCancel()
        {
            var result = dbSet.Where(w=> w.ReservationStatus==(int)ReservationStatus.Cancel).ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

        public List<ReservationDto> GetCancel(int pag, int element)
        {
            var result = dbSet.Where(w=>w.ReservationStatus==(int)ReservationStatus.Cancel)
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

      

        #endregion

        #region Finalized 
        public List<ReservationDto> GetFinalized()
        {
            var result = dbSet.Where(w => w.FinishReservationDate.Value <= DateTime.Now).ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

        public List<ReservationDto> GetFinalized(int pag, int element)
        {
            var result = dbSet.Where(w => w.FinishReservationDate.Value <= DateTime.Now)
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

   
        #endregion

        #region Not Finalized 
        public List<ReservationDto> GetNotFinalized()
        {
            var result = dbSet.Where(w => w.FinishReservationDate.Value.Date > DateTime.Now.Date
            || !w.FinishReservationDate.HasValue
            ).ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

        public List<ReservationDto> GetNotFinalized(int pag, int element)
        {
            var result = dbSet.Where(w => w.FinishReservationDate.Value.Date > DateTime.Now.Date 
            || !w.FinishReservationDate.HasValue)
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

        public List<ReservationDto> GetByClient(string idClient)
        {
            var result = dbSet.Where(w => w.Person.IdPerson.Equals(idClient)).ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

        public List<ReservationDto> GetByClient(string idClient, int pag, int element)
        {
            var result = dbSet.Where(w => w.Person.IdPerson.Equals(idClient))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }

        public List<ReservationDto> GetByClient(string idClient, DateTime start, DateTime end)
        {
            var result = dbSet.Where(w =>
            w.Person.IdPerson.Equals(idClient)
            && (DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(start)
            && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(end))
            && (DbFunctions.TruncateTime(w.FinishReservationDate.Value) >= DbFunctions.TruncateTime(start)
            && DbFunctions.TruncateTime(w.FinishReservationDate.Value) <= DbFunctions.TruncateTime(end)))
                .ToList(); 
            return mapper.Map<List<ReservationDto>>(result);
        }

        public List<ReservationDto> GetByClient(string idClient, DateTime start, DateTime end, int pag, int element)
        {
            var result = dbSet.Where(w =>
          w.Person.IdPerson.Equals(idClient)
          && (DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(start)
          && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(end))
          && (DbFunctions.TruncateTime(w.FinishReservationDate.Value) >= DbFunctions.TruncateTime(start)
          && DbFunctions.TruncateTime(w.FinishReservationDate.Value) <= DbFunctions.TruncateTime(end)))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ReservationDto>>(result);
        }


        #endregion
    }
}