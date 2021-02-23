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
        public BookRepositorie(string identificator="IdBook") : base(identificator)
        {
        }

        public List<Book> GetByAutor(string idAutor)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.IdAutor.Equals(idAutor))).ToList();
            return list;
        }

        public List<Book> GetByCategorie(string idCategory)
        {
            List<Book>list = dbSet.Where(w => w.IdType.Equals(idCategory) 
            || w.BookType.BookType2.IdFather.Equals(idCategory))
                .ToList();
            return list;
        }

        public List<Book> GetByGender(List<string> idGender)
        {
            var list = dbSet.Where(w=>w.Gender.Any(g=>g.IdGender.Any(s=>idGender.Contains(s.ToString())))).ToList();
            return list;
        }

        public List<Book> GetFromStore(string idStore)
        {
            var list = (from a in Context.Book
                                join s in Context.BookStore on a.IdBook equals s.IdBook
                                where s.IdStore == idStore
                        select a).ToList();


            return list;
        }

        public List<Book> SearchLikeAutorName(string text)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.AutorName.Contains(text))).ToList();
            return list;
        }
    }
}