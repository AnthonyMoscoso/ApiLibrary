using Models.Ado.Library;
using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;

using Nucleo.Utilities;
using BookStoreApi.Utilities.Enums;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
     

        new BookStoreEntities _Context { get  ; set ; }

        public BookRepository(BookStoreEntities context, string identificator="IdBook") : base(context,identificator)
        {
        }

        #region Autor
        public IEnumerable<Book> GetByAutor(string idAutor)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.IdAutor.Equals(idAutor)));
            return list;
        }

        public IEnumerable<Book> GetByAutor(string idAutor, int pag, int element)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.IdAutor.Equals(idAutor)))
                .OrderBy(w => w.BookTittle)
                .Skip((pag - 1) * element)
                .Take(element);
            return list;
        }

        #endregion

        #region Category
        public IEnumerable<Book> GetByCategory(string idCategory)
        {
            List<Book>list = dbSet.Where(w => w.IdType.Equals(idCategory) 
            || w.BookType.BookType2.IdFather.Equals(idCategory))
                .ToList();
            return list;
        }

        public IEnumerable<Book> GetByCategory(string idCategory, int pag, int element)
        {
            List<Book> list = dbSet.Where(w => w.IdType.Equals(idCategory) || w.BookType.BookType2.IdFather.Equals(idCategory))
               .OrderBy(w=>w.BookTittle)
               .Skip((pag-1)*element)
               .Take(element).ToList();
            return list;
        }

        #endregion

        #region Edition
        public IEnumerable<Book> GetByEdition(string idEdition)
        {
            var list = dbSet.Where(w => w.IdEdition.Equals(idEdition)).ToList();
            return list;
        }

        public IEnumerable<Book> GetByEdition(string idEdition, int pag, int element)
        {
            var list = dbSet.Where(w => w.IdEdition.Equals(idEdition))
                 .OrderBy(w => w.BookTittle)
                 .Skip((pag - 1) * element).Take(element)
                 .ToList();
            return list;
        }

        #endregion

        #region Editorial
        public IEnumerable<Book> GetByEditorial(string idEditorial)
        {
            var list = dbSet.Where(w => w.BookEditorial.Any(e => e.IdEditorial.Equals(idEditorial))).ToList();
            return list;
        }

        public IEnumerable<Book> GetByEditorial(string idEditorial, int pag, int element)
        {
            var list = dbSet.Where(w => w.BookEditorial.Any(e => e.IdEditorial.Equals(idEditorial)))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return list;
        }

        #endregion

        #region gender
        public IEnumerable<Book> GetByGender(List<string> idGeners)
        {
            var list = dbSet.Where(w => w.Gender.Any(g => idGeners.Any(y=> y.Equals(g.IdGender)))).ToList();
            return list;
        }

        public IEnumerable<Book> GetByGender(List<string> idGenders, int pag, int element)
        {
            var list = dbSet.Where(w => w.Gender.Any(g => idGenders.Any(y => y.Equals(g.IdGender))))
                 .OrderBy(w => w.BookTittle)
                 .Skip((pag - 1) * element).Take(element)
                 .ToList();
            return list;
        }

        #endregion


        #region Search By Name
        public IEnumerable<Book> SearchByName(string text)
        {
            var list = dbSet.Where(w => w.BookTittle.Contains(text)).ToList();
            return list;
        }
        public IEnumerable<Book> SearchByName(string text,int pag,int element)
        {
            var list = dbSet.Where(w => w.BookTittle.Contains(text))
                .OrderBy(w => w.BookTittle)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return list;
        }

        #endregion


        #region Search By Autor Name
        public IEnumerable<Book> SearchByAutorName(string text)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.AutorName.Contains(text))).ToList();
            return list;
        }

        public IEnumerable<Book> SearchByAutorName(string text, int pag, int element)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.AutorName.Contains(text)))
                 .OrderBy(w => w.BookTittle)
                 .Skip((pag - 1) * element).Take(element).
                 ToList();
            return list;
        }
        #endregion


       
    }
}