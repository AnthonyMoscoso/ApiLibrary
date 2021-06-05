using Models.Ado.Library;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.DBAccess.Ado;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Specifics
{
    public class OrderService : ServiceMapperBase<OrderDto, Orders>, IOrderService
    {
        public OrderService(IRepository<Orders> repository) : base(repository)
        {
        }

        public IEnumerable<OrderDto> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByDate(DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByStore(string idStore, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByStore(string idStore)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByStore(string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByWareHouse(string idWareHouse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            throw new NotImplementedException();
        }
    }
}
