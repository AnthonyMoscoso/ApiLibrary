using Models.Ado.Library;
using Models.Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IReservationOnlineRepository : IRepository<ReservationOnline>
    {
        int Count(string idWareHouse);
        int Count(string idWareHouse,DateTime start, DateTime end);
        List<ReservationOnlineDto> GetReservations(string idWareHouse);

        dynamic Insert(List<ReservationOnlineDto>list);
        dynamic Update(List<ReservationOnlineDto> list);
        new dynamic Delete(List<string>ids);
    }
}
