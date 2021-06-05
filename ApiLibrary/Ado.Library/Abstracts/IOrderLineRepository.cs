using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IOrderLineRepository : IRepository<OrderLine>
    {
        IEnumerable<OrderLine> GetByOrder(string idOrder);
    }
}
