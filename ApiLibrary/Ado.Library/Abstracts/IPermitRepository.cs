using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IPermitRepository : IRepository<Permit>
    {
        List<Permit> SearchByName(string text);
        List<Permit> SearchByName(string text,int pag,int element);
    }
}
