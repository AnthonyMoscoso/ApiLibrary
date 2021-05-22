using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IOccupationRepositorie : IRepository<Occupation>
    {
        List<Occupation> SearchByName(string text);
        List<Occupation> SearchByName(string text,int pag,int element);
    }
}
