using BookStoreApi.Dtos;
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
    interface IBookRepository : IRepository<Book>
    {
        List<BookDto> GetByAutor(string idAutor);
        List<BookDto> GetByAutor(string idAutor,int pag,int element);
        List<BookDto> SearchByAutorName(string text);
        List<BookDto> SearchByAutorName(string text,int pag,int element);
        List<BookDto> GetByCategory(string idCategory);
        List<BookDto> GetByCategory(string idCategory,int pag,int element);
        List<BookDto> GetByGender(List<string>idGender);
        List<BookDto> GetByGender(List<string> idGender,int pag,int element);
        List<BookDto> GetByEditorial(string idEditorial);
        List<BookDto> GetByEditorial(string idEditorial,int pag, int element);
        List<BookDto> GetByEdition(string idEdition);
        List<BookDto> GetByEdition(string idEdition,int pag,int element);
        List<BookDto> SearchByName(string text);
        List<BookDto> SearchByName(string text,int pag,int element);
        


        dynamic RemoveImage(string idBook,string idImageFile);
        dynamic AddImage(string idBook, string idImageFile);
    }
}
