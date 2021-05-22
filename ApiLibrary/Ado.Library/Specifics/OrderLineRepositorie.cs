using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;

using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Models.Repositories.Concrect.Order
{
    public class OrderLineRepositorie : Repository<OrderLine,OrderLineDto>, IOrderLineRepositorie
    {
        public OrderLineRepositorie(string identificator="IdOrderLine") : base(identificator)
        {
        }

        public List<OrderLine> GetByOrder(string idOrder)
        {
            return dbSet.Where(w=>w.IdOrder.Equals(idOrder)).ToList();
        }
    }
}