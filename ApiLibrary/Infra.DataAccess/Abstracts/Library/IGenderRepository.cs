using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IGenderRepository : IRepository<Gender>
    {
        IEnumerable<Gender> SearchByName(string text);
        IEnumerable<Gender> SearchByName(string text, int pag, int element);
    }
}
