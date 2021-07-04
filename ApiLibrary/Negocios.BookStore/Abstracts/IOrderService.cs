using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IOrderService : IServices<OrderDto>
    {
        IEnumerable<OrderDto> GetByDate(DateTime date);
        IEnumerable<OrderDto> GetByDate(DateTime date, int pag, int element);
        IEnumerable<OrderDto> GetByDate(DateTime dateStart, DateTime dateEnd);
        IEnumerable<OrderDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element);
        IEnumerable<OrderDto> GetByStore(string idStore, DateTime date);
        IEnumerable<OrderDto> GetByStore(string idStore, DateTime date, int pag, int element);
        IEnumerable<OrderDto> GetByStore(string idStore);
        IEnumerable<OrderDto> GetByStore(string idStore, int pag, int element);
        IEnumerable<OrderDto> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd);
        IEnumerable<OrderDto> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element);
        IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, DateTime date);
        IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element);
        IEnumerable<OrderDto> GetByWareHouse(string idWareHouse);
        IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, int pag, int element);
        IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd);
        IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element);
    }
}
