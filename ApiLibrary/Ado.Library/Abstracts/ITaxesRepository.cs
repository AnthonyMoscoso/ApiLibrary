using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{ 
    public interface ITaxesRepository : IRepository <Taxes>
    {
        List<Taxes> SearchByName(string text);
        List<Taxes> SearchByName(string text,int pag,int element);
        List<Taxes> GetByType(int type);
        List<Taxes> GetByType(int type, int pag, int element);
    }
}
