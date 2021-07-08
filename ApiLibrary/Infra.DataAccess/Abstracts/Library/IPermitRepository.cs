using Models.Ado.Library;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IPermitRepository : IRepository<Permit>
    {
        IEnumerable<Permit> SearchByName(string text);
        IEnumerable<Permit> SearchByName(string text, int pag, int element);
    }
}
