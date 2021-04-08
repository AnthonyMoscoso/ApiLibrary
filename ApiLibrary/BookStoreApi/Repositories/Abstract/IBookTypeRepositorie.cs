using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Books
{
    interface IBookTypeRepositorie : IRepository<BookType>
    {
        List<BookTypeDto> SearchByName(string text);
        List<BookTypeDto> SearchByName(string text, int pag, int element);
        BookTypeDto GetByName(string name);
    }
}
