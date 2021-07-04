using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IRegisterRepository : IRepository<Register>
    {
        IEnumerable<Register> GetByDate(DateTime date);
        IEnumerable<Register> GetByDate(DateTime date, int pag, int element);
        IEnumerable<Register> GetByDate(DateTime dateStart, DateTime dateEnd);
        IEnumerable<Register> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element);

        #region By Store
        IEnumerable<Register> GetByStore(string idStore);
        IEnumerable<Register> GetByStore(string idStore, int pag, int element);
        IEnumerable<Register> GetByStore(string idStore, DateTime date);
        IEnumerable<Register> GetByStore(string idStore, DateTime date, int pag, int element);
        IEnumerable<Register> GetByStore(string idStore, DateTime start, DateTime end);
        IEnumerable<Register> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);

        #endregion

        #region By WareHouse 
        IEnumerable<Register> GetByWareHouse(string idWareHouse);
        IEnumerable<Register> GetByWareHouse(string idWareHouse, int pag, int element);
        IEnumerable<Register> GetByWareHouse(string idWareHouse, DateTime date);
        IEnumerable<Register> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element);
        IEnumerable<Register> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd);
        IEnumerable<Register> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element);
        #endregion



    }
}
