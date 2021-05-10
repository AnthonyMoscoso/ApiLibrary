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
    interface IReservationStoreRepository : IRepository<ReservationStore>
    {

        #region GetByStore
        List<ReservationStoreDto> GetByStore(string idStore);
        List<ReservationStoreDto> GetByStore(string idStore, int pag, int element);

        List<ReservationStoreDto> GetByStore(string idStore, DateTime start,DateTime end);
        List<ReservationStoreDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);

        int Count(string idStore);
        int Count(string idStore, DateTime start, DateTime end);

        dynamic Insert(List<ReservationStoreDto>list);
        dynamic Update(List<ReservationStoreDto>list);
        new  dynamic Delete(List<string>ids);
        #endregion

    }
}
