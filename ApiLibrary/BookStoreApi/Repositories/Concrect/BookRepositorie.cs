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

        public List<Book> GetByAutor(string idAutor, int pag, int element)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.IdAutor.Equals(idAutor)))
                .OrderBy(w => w.BookTittle)
                .Skip((pag - 1) * element)
                .Take(element).ToList();
            return list;
        }

        public List<Book> GetByCategorie(string idCategory)
        {
            List<Book>list = dbSet.Where(w => w.IdType.Equals(idCategory) 
            || w.BookType.BookType2.IdFather.Equals(idCategory))
                .ToList();
            return list;
        }

        public List<Book> GetByCategorie(string idCategory, int pag, int element)
        {
            List<Book> list = dbSet.Where(w => w.IdType.Equals(idCategory)
            || w.BookType.BookType2.IdFather.Equals(idCategory))
               .OrderBy(w=>w.BookTittle)
               .Skip((pag-1)*element)
               .Take(element).ToList();
            return list;
        }

        public List<Book> GetByEdition(string idEdition)
        {
            var list = dbSet.Where(w => w.IdEdition.Equals(idEdition)).ToList();
            return list;
        }

        public List<Book> GetByEdition(string idEdition, int pag, int element)
        {
            var list = dbSet.Where(w => w.IdEdition.Equals(idEdition))
                 .OrderBy(w => w.BookTittle)
                 .Skip((pag - 1) * element).Take(element)
                 .ToList();
            return list;
        }

        public List<Book> GetByEditorial(string idEditorial)
        {
            var list = (from a in Context.Book
                        join s in Context.BookEditorial on a.IdBook equals s.IdBook
                        where s.IdEditorial.Equals(idEditorial)
                        select a).ToList();
            return list;
        }

        public List<Book> GetByEditorial(string idEditorial, int pag, int element)
        {
            var list = (from a in Context.Book
                        join s in Context.BookEditorial on a.IdBook equals s.IdBook
                        where s.IdEditorial.Equals(idEditorial)
                        select a)
                         .OrderBy(w => w.BookTittle)
                         .Skip((pag - 1) * element).Take(element)
                         .ToList();
            return list;
        }

        public List<Book> GetByGender(List<string> idGender)
        {
            var list = dbSet.Where(w=>w.Gender.Any(g=>g.IdGender.Any(s=>idGender.Contains(s.ToString())))).ToList();
            return list;
        }

        public List<Book> GetByGender(List<string> idGender, int pag, int element)
        {
            var list = dbSet.Where(w => w.Gender.Any(g => g.IdGender.Any(s => idGender.Contains(s.ToString()))))
                 .OrderBy(w => w.BookTittle)
                 .Skip((pag - 1) * element).Take(element)
                 .ToList();
            return list;
        }



        public List<Book> SearchByName(string text)
        {
            return dbSet.Where(w => w.BookTittle.Contains(text)).ToList();
        }

        public List<Book> SearchByAutorName(string text)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.AutorName.Contains(text))).ToList();
            return list;
        }

        public List<Book> SearchByAutorName(string text, int pag, int element)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.AutorName.Contains(text)))
                 .OrderBy(w => w.BookTittle)
                 .Skip((pag - 1) * element).Take(element).
                 ToList();
            return list;
        }
    }
}