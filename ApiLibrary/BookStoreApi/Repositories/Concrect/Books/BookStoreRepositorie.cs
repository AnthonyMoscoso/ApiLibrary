using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Books;
using LibraryApiRest.Repositories.Abstract;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Books
{
    public class BookStoreRepositorie : Repositorie<BookStore>,IBookStoreRepositorie
    {
        public BookStoreRepositorie(string identificator="IdBookStore") : base(identificator)
        {
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="idBook"></param>
        /// <param name="idStore"></param>
        /// <returns></returns>
        public int GetStock(string idBook, string idStore)
        {
            int stock = dbSet.Where(w => w.IdBook == idBook && w.IdStore ==idStore).SingleOrDefault().Stock;
            return stock;
        }
    }
}