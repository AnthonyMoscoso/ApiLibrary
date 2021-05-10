using BookStoreApi.Models.Dtos;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract
{
    interface IReservationOnlineRepository : IRepository<ReservationOnline>
    {
        int Count(string idWareHouse);
        int Count(string idWareHouse,DateTime start, DateTime end);
        List<ReservationOnlineDto> GetReservations(string idWareHouse);

        dynamic Insert(List<ReservationOnlineDto>list);
        dynamic Update(List<ReservationOnlineDto> list);
        new dynamic Delete(List<string>ids);
    }
}
