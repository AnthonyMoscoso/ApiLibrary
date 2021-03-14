using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Books;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Books
{
    public class BookTypeRepositorie : Repositorie<BookType>, IBookTypeRepositorie
    {
        public BookTypeRepositorie(string identificator= "IdType") : base(identificator)
        {

        }

        public BookType GetByName(string name)
        {
            return dbSet.Where(w => w.TypeName.Equals(name)).FirstOrDefault();
        }

        public List<BookType> SearchByName(string text)
        {
            return dbSet.Where(w => w.TypeName.Contains(text)).ToList();
        }

        public List<BookType> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(w => w.TypeName.Contains(text))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
        }
    }
}