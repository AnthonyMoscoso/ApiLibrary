using BookStoreApi.Models.Library;
using BookStoreApi.Models.Request;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract
{
    interface IBookRepositorie : IRepositorie<Book>
    {
        List<Book> GetByAutor(string idAutor);
        List<Book> GetByAutor(string idAutor,int pag,int element);
        List<Book> SearchByAutorName(string text);
        List<Book> SearchByAutorName(string text,int pag,int element);
        List<Book> GetByCategory(string idCategory);
        List<Book> GetByCategory(string idCategory,int pag,int element);
        List<Book> GetByGender(List<string>idGender);
        List<Book> GetByGender(List<string> idGender,int pag,int element);
        List<Book> GetByEditorial(string idEditorial);
        List<Book> GetByEditorial(string idEditorial,int pag, int element);
        List<Book> GetByEdition(string idEdition);
        List<Book> GetByEdition(string idEdition,int pag,int element);
        List<Book> SearchByName(string text);

        List<BookStoreRequest> Store(string idStore,int pag,int element);
    }
}
