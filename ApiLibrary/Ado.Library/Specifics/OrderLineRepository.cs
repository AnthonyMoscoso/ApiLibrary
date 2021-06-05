using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;

using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{
    public class OrderLineRepository : Repository<OrderLine>, IOrderLineRepository
    {
        public OrderLineRepository(BookStoreEntities context,string identificator="IdOrderLine") : base(context,identificator)
        {
        }

        public IEnumerable<OrderLine> GetByOrder(string idOrder)
        {
            return dbSet.Where(w=>w.IdOrder.Equals(idOrder));
        }
    }
}