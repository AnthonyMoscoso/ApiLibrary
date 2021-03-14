using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Books
{
    interface IBookTypeRepositorie : IRepositorie<BookType>
    {
        List<BookType> SearchByName(string text);
        List<BookType> SearchByName(string text, int pag, int element);
        BookType GetByName(string name);
    }
}
