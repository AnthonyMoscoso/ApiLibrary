using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IReceptionService : IServices<ReceptionDto>
    {
        IEnumerable<ReceptionDto> GetByDate(DateTime date);
        IEnumerable<ReceptionDto> GetByDate(DateTime date, int pag, int element);
        IEnumerable<ReceptionDto> GetByDate(DateTime dateStart, DateTime dateEnd);
        IEnumerable<ReceptionDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element);
        IEnumerable<ReceptionDto> GetByStore(string idStore);
        IEnumerable<ReceptionDto> GetByStore(string idStore, int pag, int element);
        IEnumerable<ReceptionDto> GetByStore(string idStore, DateTime date);
        IEnumerable<ReceptionDto> GetByStore(string idStore, DateTime date, int pag, int element);
        IEnumerable<ReceptionDto> GetByOrder(string idOrder);
        IEnumerable<ReceptionDto> GetByPurchase(string idPurchase);
    }
}
