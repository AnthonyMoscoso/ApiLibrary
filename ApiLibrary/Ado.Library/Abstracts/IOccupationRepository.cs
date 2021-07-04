using Models.Ado.Library;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IOccupationRepository : IRepository<Occupation>
    {
        IEnumerable<Occupation> SearchByName(string text);
        IEnumerable<Occupation> SearchByName(string text, int pag, int element);
    }
}
