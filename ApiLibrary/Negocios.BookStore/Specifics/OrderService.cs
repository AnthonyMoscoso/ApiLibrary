using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ado.Library;
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class OrderService : ServiceMapperBase<OrderDto, Orders>, IOrderService
    {
        readonly new IOrderRepository _repository;
        public OrderService(IOrderRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<OrderDto> GetByDate(DateTime date)
        {
            IEnumerable<Orders> result = _repository.GetByDate(date);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByDate(DateTime date, int pag, int element)
        {
            IEnumerable<Orders> result = _repository.GetByDate(date);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            IEnumerable<Orders> result = _repository.GetByDate(dateStart,dateEnd);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            IEnumerable<Orders> result = _repository.GetByDate(dateStart,dateEnd,pag,element);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByStore(string idStore, DateTime date)
        {
            IEnumerable<Orders> result = _repository.GetByStore(idStore,date);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            IEnumerable<Orders> result = _repository.GetByStore(idStore,date,pag,element);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByStore(string idStore)
        {
            IEnumerable<Orders> result = _repository.GetByStore(idStore);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByStore(string idStore, int pag, int element)
        {
            IEnumerable<Orders> result = _repository.GetByStore(idStore,pag,element);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd)
        {
            IEnumerable<Orders> result = _repository.GetByStore(idStore,dateStart,dateEnd);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            IEnumerable<Orders> result = _repository.GetByStore(idStore,dateStart,dateEnd,pag,element);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, DateTime date)
        {
            IEnumerable<Orders> result = _repository.GetByWareHouse(idWareHouse,date);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            IEnumerable<Orders> result = _repository.GetByWareHouse(idWareHouse,date,pag,element);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByWareHouse(string idWareHouse)
        {
            IEnumerable<Orders> result = _repository.GetByWareHouse(idWareHouse);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            IEnumerable<Orders> result = _repository.GetByWareHouse(idWareHouse,pag,element);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd)
        {
            IEnumerable<Orders> result = _repository.GetByWareHouse(idWareHouse,dateStart,dateEnd);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }

        public IEnumerable<OrderDto> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            IEnumerable<Orders> result = _repository.GetByWareHouse(idWareHouse,dateStart,dateEnd,pag,element);
            return mapper.Map<IEnumerable<OrderDto>>(result);
        }
    }
}
