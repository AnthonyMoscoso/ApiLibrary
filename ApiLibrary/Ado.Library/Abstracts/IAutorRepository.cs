using Models.Ado.Library;
using Models.Dtos;
using Nucleo.DBAccess.Ado;
using System.Collections.Generic;

namespace Ado.Library
{
    public interface IAutorRepository : IRepository<Autor>
    {
        List<AutorDto> SearchByName(string text);
        List<AutorDto> SearchByName(string text,int pag,int element);
        AutorDto GetByName(string name);
        bool ExistName(string name);
      
    }
}
