using Models.Ado.Library;
using Models.Dtos;
using Core.DBAccess.Ado;
using System.Collections.Generic;

namespace Ado.Library
{
    public interface IAutorRepository : IRepository<Autor>
    {
        IEnumerable<Autor> SearchByName(string text);
        IEnumerable<Autor> SearchByName(string text,int pag,int element);
        Autor GetByName(string name);
        bool ExistName(string name);
      
    }
}
