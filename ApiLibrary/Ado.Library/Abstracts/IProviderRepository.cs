using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IProviderRepository : IRepository<Providers>
    {
        IEnumerable<Providers> SearchByName(string text);
        IEnumerable<Providers> SearchByName(string text, int pag, int element);
    }
}
