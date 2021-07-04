using Models.Dtos;
using Models.Ado.Library;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IBookTypeRepository : IRepository<BookType>
    {
        IEnumerable<BookType> SearchByName(string text);
        IEnumerable<BookType> SearchByName(string text, int pag, int element);
        BookType GetByName(string name);
    }
}
