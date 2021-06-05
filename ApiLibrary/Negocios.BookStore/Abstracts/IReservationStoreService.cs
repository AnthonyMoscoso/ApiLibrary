using Models.Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IReservationStoreService : IServices<ReservationStoreDto>
    {
        IEnumerable<ReservationStoreDto> GetByStore(string idStore);
        IEnumerable<ReservationStoreDto> GetByStore(string idStore, int pag, int element);

        IEnumerable<ReservationStoreDto> GetByStore(string idStore, DateTime start, DateTime end);
        IEnumerable<ReservationStoreDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);

        int Count(string idStore);
        int Count(string idStore, DateTime start, DateTime end);
    }
}
