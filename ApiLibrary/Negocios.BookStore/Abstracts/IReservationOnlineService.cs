using Models.Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IReservationOnlineService : IServices<ReservationOnlineDto>
    {
        int Count(string idWareHouse);
        int Count(string idWareHouse, DateTime start, DateTime end);
        IEnumerable<ReservationOnlineDto> GetReservations(string idWareHouse);
    }
}
