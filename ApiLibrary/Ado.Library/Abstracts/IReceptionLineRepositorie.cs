using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IReceptionLineRepositorie: IRepository<ReceptionLine>
    {
        List<ReceptionLine> GetByReception(string idReception);
    }
}
