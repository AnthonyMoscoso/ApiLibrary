using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Ado.Library
{
    public interface IBookRepository : IRepository<Book>
    {
       
        IEnumerable<Book> GetByAutor(string idAutor);
        IEnumerable<Book> GetByAutor(string idAutor,int pag,int element);
        IEnumerable<Book> SearchByAutorName(string text);
        IEnumerable<Book> SearchByAutorName(string text,int pag,int element);
        IEnumerable<Book> GetByCategory(string idCategory);
        IEnumerable<Book> GetByCategory(string idCategory,int pag,int element);
        IEnumerable<Book> GetByGender(List<string>idGender);
        IEnumerable<Book> GetByGender(List<string> idGender,int pag,int element);
        IEnumerable<Book> GetByEditorial(string idEditorial);
        IEnumerable<Book> GetByEditorial(string idEditorial,int pag, int element);
        IEnumerable<Book> GetByEdition(string idEdition);
        IEnumerable<Book> GetByEdition(string idEdition,int pag,int element);
        IEnumerable<Book> SearchByName(string text);
        IEnumerable<Book> SearchByName(string text,int pag,int element);
        



    }
}
