using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IEditionRepository : IRepository<Edition>
    {
        IEnumerable<Edition> SearchByName(string text);

        IEnumerable<Edition> SearchByName(string text, int pag, int element);
    }
}
