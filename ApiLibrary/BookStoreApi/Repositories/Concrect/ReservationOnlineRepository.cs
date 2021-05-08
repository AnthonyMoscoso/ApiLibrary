using BookStoreApi.Models.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect
{
    public class ReservationOnlineRepository : Repository<ReservationOnline, ReservationOnlineDto> ,IReservationOnlineRepository
    {
        public ReservationOnlineRepository(string identificator="IdReservation") : base(identificator)
        {
        }
    }
}