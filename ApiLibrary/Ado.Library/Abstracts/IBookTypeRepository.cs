using Models.Dtos;
using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IBookTypeRepository : IRepository<BookType>
    {
        List<BookTypeDto> SearchByName(string text);
        List<BookTypeDto> SearchByName(string text, int pag, int element);
        BookTypeDto GetByName(string name);
    }
}
