using Models.Ado.Library;
using Models.Models.Dtos;
using System;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IReservationStoreRepository : IRepository<ReservationStore>
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
