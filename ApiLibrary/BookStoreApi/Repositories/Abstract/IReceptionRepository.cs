using BookStoreApi.Dtos;
using BookStoreApi.Models.Dtos;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Receptions
{
    interface IReceptionRepository : IRepository<Reception>
    {
        List<ReceptionDto> GetByDate(DateTime date);
        List<ReceptionDto> GetByDate(DateTime date,int pag,int element);
        List<ReceptionDto> GetByDate(DateTime dateStart,DateTime dateEnd);
        List<ReceptionDto> GetByDate(DateTime dateStart, DateTime dateEnd,int pag, int element);
        List<ReceptionDto> GetByStore(string idStore);
        List<ReceptionDto> GetByStore(string idStore,int pag,int element);
        List<ReceptionDto> GetByStore(string idStore, DateTime date);
        List<ReceptionDto> GetByStore(string idStore,DateTime date,int pag,int element);

        List<ReceptionOrderDto> GetByOrder(string idOrder);
        List<ReceptionPurchaseDto> GetByPurchase(string idPurchase);
    }
}
