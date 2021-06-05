using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IReceptionLineRepository : IRepository<ReceptionLine>
    {
        IEnumerable<ReceptionLine> GetByReception(string idReception);
    }
}
