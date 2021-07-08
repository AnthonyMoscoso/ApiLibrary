using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Ado.Library.Specifics;
using Business.BookStoreServices.Abstracts;

using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using Core.Utilities.Enums;
using Core.Services.Abstracts;
using Logger.Repository.Specifics;
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class BookService : ServiceMapperBase<BookDto, Book>, IBookService
    {


        public BookService(IBookRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public dynamic AddImage(string idBookDto, string idImageFile)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookDto> GetByAutor(string idAutor)
        {
            IEnumerable<Book> search = _repository.Get(w=> w.Autor.Any(a=> a.IdAutor.Equals(idAutor)));
            return mapper.Map<IEnumerable<BookDto>>(search);
        }

        public IEnumerable<BookDto> GetByAutor(string idAutor, int pag, int element)
        {
            IEnumerable<Book> search = _repository.Get(x => x.Autor.Any(y => y.IdAutor.Equals(idAutor))).OrderBy(w=> w.CreateDate).Skip((pag - 1) * element).Take(element);
            return mapper.Map<IEnumerable<BookDto>>(search);
        }

        public IEnumerable<BookDto> GetByCategory(string idCategory)
        {
            IEnumerable<Book> search = _repository.Get(x => x.IdType.Equals(idCategory) || x.BookType.IdFather.Equals(idCategory));
            return mapper.Map<IEnumerable<BookDto>>(search);
        }

        public IEnumerable<BookDto> GetByCategory(string idCategory, int pag, int element)
        {
            IEnumerable<Book> search = _repository.Get(x => x.IdType.Equals(idCategory) || x.BookType.IdFather.Equals(idCategory)).OrderBy(x=> x.BookType.TypeName).Skip((pag - 1) * element).Take(element);
            return mapper.Map<IEnumerable<BookDto>>(search);
        }

        public IEnumerable<BookDto> GetByEdition(string idEdition)
        {
            IEnumerable<Book> result = _repository.Get(w => w.IdEdition.Equals(idEdition));
            return mapper.Map<IEnumerable<BookDto>>(result);
        }

        public IEnumerable<BookDto> GetByEdition(string idEdition, int pag, int element)
        {
            IEnumerable<Book> result =(_repository.Get(w => w.IdEdition.Equals(idEdition)).OrderBy(w=> w.Edition.EditionName).Take((pag-1)*element).Take(element));
            return mapper.Map<IEnumerable<BookDto>>(result);
        }

        public IEnumerable<BookDto> GetByEditorial(string idEditorial)
        {
            IEnumerable<Book> result = _repository.Get(w=> w.BookEditorial.Any(e => e.IdEditorial.Equals(idEditorial)));
            return mapper.Map<IEnumerable<BookDto>>(result);
        }

        public IEnumerable<BookDto> GetByEditorial(string idEditorial, int pag, int element)
        {
            IEnumerable<Book> result = _repository.Get(w => w.BookEditorial.Any(e => e.IdEditorial.Equals(idEditorial))).OrderBy(w=> w.CreateDate).Skip((pag - 1) * element).Take(element);
            return mapper.Map<IEnumerable<BookDto>>(result);
        }

        public IEnumerable<BookDto> GetByGender(List<string> idGender)
        {
            IEnumerable<Book> result = _repository.Get(w=> w.Gender.Any(g => g.IdGender.Equals(idGender)));
            return mapper.Map<IEnumerable<BookDto>>(result);
        }

        public IEnumerable<BookDto> GetByGender(List<string> idGender, int pag, int element)
        {
            IEnumerable<Book> result = _repository.Get(w => w.Gender.Any(g => g.IdGender.Equals(idGender))).OrderBy(w=> w.Gender.OrderBy( g=> g.GenderName)).Skip((pag-1)).Take(element);
            return mapper.Map<IEnumerable<BookDto>>(result);
        }

        public dynamic RemoveImage(string idBookDto, string idImageFile)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookDto> SearchByAutorName(string text)
        {
            IEnumerable<Book> result = _repository.Get(w => w.Autor.Any(a=> a.AutorName.Contains(text)));
            return mapper.Map<IEnumerable<BookDto>>(result);
        }

        public IEnumerable<BookDto> SearchByAutorName(string text, int pag, int element)
        {
            IEnumerable<Book> result = _repository.Get(w => w.Autor.Any(a => a.AutorName.Contains(text))).OrderBy(w=> w.Autor.OrderBy(a=> a.AutorName)).Skip((pag - 1) * element).Take(element); 
            return mapper.Map<IEnumerable<BookDto>>(result);
        }

        public IEnumerable<BookDto> SearchByName(string text)
        {
            IEnumerable<Book> result = _repository.Get(w=> w.BookTittle.Contains(text));
            return mapper.Map<IEnumerable<BookDto>>(result);
        }

        public IEnumerable<BookDto> SearchByName(string text, int pag, int element)
        {
            IEnumerable<Book> result = _repository.Get(w => w.BookTittle.Contains(text)).OrderBy(w=> w.BookTittle).Skip((pag-1)*element).Take(element);
            return mapper.Map<IEnumerable<BookDto>>(result);
        }




        public new dynamic Update(IEnumerable<BookDto> list)
        {
            return "hola";
            foreach (BookDto entity in list)
            {
                Book book = mapper.Map<Book>(entity);
                _repository.Update(book);
               /* UpdateBookAutors(book);
                UpdateBookGenders(book);
                UpdatePrice(book);*/
            }
             return _repository.Save();


        }




      
    }
}
