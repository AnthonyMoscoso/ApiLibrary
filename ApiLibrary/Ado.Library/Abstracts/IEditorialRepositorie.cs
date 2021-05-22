using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IEditorialRepositorie : IRepository<Editorial>
    {
        List<Editorial>SearchByName(string text);
        List<Editorial> SearchByName(string text,int pag,int element);
    }
}
