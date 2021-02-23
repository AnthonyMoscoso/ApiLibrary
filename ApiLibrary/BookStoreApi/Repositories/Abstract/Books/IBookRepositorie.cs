using BookStoreApi.Models.Library;
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
        List<Book> GetFromStore(string idStore);
        List<Book> GetByAutor(string idAutor);
        List<Book> SearchLikeAutorName(string text);
        List<Book> GetByCategorie(string idCategory);
        List<Book> GetByGender(List<string>idGender);

        
    }
}
