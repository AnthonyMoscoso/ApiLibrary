using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{ 
    public interface ITaxesRepository : IRepository <Taxes>
    {
        IEnumerable<Taxes> SearchByName(string text);
        IEnumerable<Taxes> SearchByName(string text,int pag,int element);
        IEnumerable<Taxes> GetByType(int type);
        IEnumerable<Taxes> GetByType(int type, int pag, int element);
    }
}
