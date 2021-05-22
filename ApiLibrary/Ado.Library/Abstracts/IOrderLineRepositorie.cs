using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IOrderLineRepositorie : IRepository<OrderLine>
    {
        List<OrderLine> GetByOrder(string idOrder);
    }
}
