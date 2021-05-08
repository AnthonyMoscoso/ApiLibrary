using BookStoreApi.Models.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect
{
    public class ReservationOnlineRepository : Repository<ReservationOnline, ReservationOnlineDto> ,IReservationOnlineRepository
    {
        public ReservationOnlineRepository(string identificator="IdReservation") : base(identificator)
        {
        }

        public int Count(string idWareHouse)
        {
            return dbSet.Count(w => w.IdWareHouse.Equals(idWareHouse));
        }

        public int Count(string idWareHouse, DateTime start, DateTime end)
        {
            return dbSet.Count(w=> w.IdWareHouse.Equals(idWareHouse) 
            && DbFunctions.TruncateTime(start)>= w.Reservation.CreateDate
            && DbFunctions.TruncateTime(end)<= w.Reservation.FinishReservationDate.Value);
        }

        public List<ReservationOnlineDto> GetReservations(string idWareHouse)
        {
            var result = dbSet.Where(w => w.IdWareHouse.Equals(idWareHouse)).ToList();
            return mapper.Map<List<ReservationOnlineDto>>(result);
        }
    }
}