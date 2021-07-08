using Models.Ado.Library;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IEditorialRepository : IRepository<Editorial>
    {
        IEnumerable<Editorial> SearchByName(string text);
        IEnumerable<Editorial> SearchByName(string text, int pag, int element);
    }
}
