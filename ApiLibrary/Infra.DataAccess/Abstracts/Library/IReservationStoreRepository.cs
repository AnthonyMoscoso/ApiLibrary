using Models.Ado.Library;
using System;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IReservationStoreRepository : IRepository<ReservationStore>
    {

        #region GetByStore
        IEnumerable<ReservationStore> GetByStore(string idStore);
        IEnumerable<ReservationStore> GetByStore(string idStore, int pag, int element);

        IEnumerable<ReservationStore> GetByStore(string idStore, DateTime start,DateTime end);
        IEnumerable<ReservationStore> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);

        int Count(string idStore);
        int Count(string idStore, DateTime start, DateTime end);

        
        #endregion

    }
}
