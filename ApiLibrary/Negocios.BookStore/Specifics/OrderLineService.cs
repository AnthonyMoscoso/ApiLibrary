using Ado.Library;
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

namespace Business.BookStoreServices.Specifics
{
    public class OrderLineService : ServiceMapperBase<OrderLineDto, OrderLine>, IOrderLineService
    {
        readonly new IOrderLineRepository _repository;
        public OrderLineService(IOrderLineRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<OrderLineDto> GetByOrder(string idOrder)
        {
            IEnumerable<OrderLine> search = _repository.GetByOrder(idOrder);
            return mapper.Map<IEnumerable<OrderLineDto>>(search);
        }
    }
}
