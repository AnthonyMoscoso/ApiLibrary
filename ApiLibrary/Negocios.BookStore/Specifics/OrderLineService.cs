using Ado.Library;
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
    public class OrderLineService : ServiceMapperBase<OrderLineDto, OrderLine>, IOrderLineService
    {
        public OrderLineService(IOrderLineRepository repository) : base(repository)
        {
        }

        public IEnumerable<OrderLineDto> GetByOrder(string idOrder)
        {
            IEnumerable<OrderLine> search = _repository.Get(w => w.IdOrder.Equals(idOrder));
            return mapper.Map<IEnumerable<OrderLineDto>>(search);
        }
    }
}
