using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IRegisterService : IServices<RegisterDto>
    {
        IEnumerable<RegisterDto> GetByDate(DateTime date);
        IEnumerable<RegisterDto> GetByDate(DateTime date, int pag, int element);
        IEnumerable<RegisterDto> GetByDate(DateTime dateStart, DateTime dateEnd);
        IEnumerable<RegisterDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element);

        #region By Store
        IEnumerable<RegisterDto> GetByStore(string idStore);
        IEnumerable<RegisterDto> GetByStore(string idStore, int pag, int element);
        IEnumerable<RegisterDto> GetByStore(string idStore, DateTime date);
        IEnumerable<RegisterDto> GetByStore(string idStore, DateTime date, int pag, int element);
        IEnumerable<RegisterDto> GetByStore(string idStore, DateTime start, DateTime end);
        IEnumerable<RegisterDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element);

        #endregion

        #region By WareHouse 
        IEnumerable<RegisterDto> GetByWareHouse(string idWareHouse);
        IEnumerable<RegisterDto> GetByWareHouse(string idWareHouse, int pag, int element);
        IEnumerable<RegisterDto> GetByWareHouse(string idWareHouse, DateTime date);
        IEnumerable<RegisterDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element);
        IEnumerable<RegisterDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd);
        IEnumerable<RegisterDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element);
        #endregion
    }
}
