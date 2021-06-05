using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IRolRepository : IRepository<Rol>
    {
        IEnumerable<Rol> SearchByName(string text);
        IEnumerable<Rol> SearchByName(string text,int pag,int element);
    }
}
