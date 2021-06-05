using Models.Ado.Library;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IReservationOnlineRepository : IRepository<ReservationOnline>
    {
        int Count(string idWareHouse);
        int Count(string idWareHouse,DateTime start, DateTime end);
        IEnumerable<ReservationOnline> GetReservations(string idWareHouse);
    }
}
