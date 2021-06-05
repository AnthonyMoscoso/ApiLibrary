using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IBookService : IServices<BookDto>
    {
        IEnumerable<BookDto> GetByAutor(string idAutor);
        IEnumerable<BookDto> GetByAutor(string idAutor, int pag, int element);
        IEnumerable<BookDto> SearchByAutorName(string text);
        IEnumerable<BookDto> SearchByAutorName(string text, int pag, int element);
        IEnumerable<BookDto> GetByCategory(string idCategory);
        IEnumerable<BookDto> GetByCategory(string idCategory, int pag, int element);
        IEnumerable<BookDto> GetByGender(List<string> idGender);
        IEnumerable<BookDto> GetByGender(List<string> idGender, int pag, int element);
        IEnumerable<BookDto> GetByEditorial(string idEditorial);
        IEnumerable<BookDto> GetByEditorial(string idEditorial, int pag, int element);
        IEnumerable<BookDto> GetByEdition(string idEdition);
        IEnumerable<BookDto> GetByEdition(string idEdition, int pag, int element);
        IEnumerable<BookDto> SearchByName(string text);
        IEnumerable<BookDto> SearchByName(string text, int pag, int element);

        dynamic RemoveImage(string idBookDto, string idImageFile);
        dynamic AddImage(string idBookDto, string idImageFile);
    }
}
