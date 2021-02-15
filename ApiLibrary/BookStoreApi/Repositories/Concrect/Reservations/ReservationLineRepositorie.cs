using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Reservations;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Reservations
{
    public class ReservationLineRepositorie : Repositorie<ReservationLine>, IReservationLineRepositorie
    {
    }
}