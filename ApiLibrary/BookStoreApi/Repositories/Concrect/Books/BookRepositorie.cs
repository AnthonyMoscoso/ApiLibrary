using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Books
{
    public class BookRepositorie : Repositorie<Book>, IBookRepositorie
    {
        /// <summary>
        /// Metodo para obtener los libros de una tienda especifica 
        /// </summary>
        /// <param name="idStore"> id de la tienda </param>
        /// <returns></returns>
        public dynamic GetFromStore(string idStore)
        {
            var list = (from a in Context.Book
                                join s in Context.BookStore on a.IdBook equals s.IdBook
                                where s.IdStore == idStore
                        select a).ToList();


            return list;
        }
    }
}