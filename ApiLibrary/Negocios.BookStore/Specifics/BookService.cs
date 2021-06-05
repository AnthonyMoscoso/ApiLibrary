using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Ado.Library.Specifics;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.Services.Abstracts;
using Nucleo.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocios.BookStoreServices.Specifics
{
    public class BookService : ServiceMapperBase<BookDto, Book>, IBookService
    {
        readonly new IBookRepository _repository = new BookRepository(new BookStoreEntities());

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
            IEnumerable<Book> search = _repository.GetByAutor(idAutor);
            return mapper.Map<IEnumerable<BookDto>>(search);
        }

        public IEnumerable<BookDto> GetByAutor(string idAutor, int pag, int element)
        {
            IEnumerable<Book> search = _repository.Get(x => x.Autor.Any(y => y.IdAutor.Equals(idAutor))).Skip((pag - 1) * element).Take(element);
            return mapper.Map<IEnumerable<BookDto>>(search);
        }

        public IEnumerable<BookDto> GetByCategory(string idCategory)
        {
            IEnumerable<Book> search = _repository.Get(x => x.IdType.Equals(idCategory) || x.BookType.IdFather.Equals(idCategory));
            return mapper.Map<IEnumerable<BookDto>>(search);
        }

        public IEnumerable<BookDto> GetByCategory(string idCategory, int pag, int element)
        {
            IEnumerable<Book> search = _repository.Get(x => x.IdType.Equals(idCategory) || x.BookType.IdFather.Equals(idCategory)).Skip((pag - 1) * element).Take(element);
            return mapper.Map<IEnumerable<BookDto>>(search);
        }

        public IEnumerable<BookDto> GetByEdition(string idEdition)
        {
            return Map(_repository.Get(w=> w.IdEdition.Equals(idEdition)));
        }

        public IEnumerable<BookDto> GetByEdition(string idEdition, int pag, int element)
        {
            return Map(_repository.Get(w => w.IdEdition.Equals(idEdition)).Take((pag-1)*element).Take(element));
        }

        public IEnumerable<BookDto> GetByEditorial(string idEditorial)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookDto> GetByEditorial(string idEditorial, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookDto> GetByGender(List<string> idGender)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookDto> GetByGender(List<string> idGender, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public dynamic RemoveImage(string idBookDto, string idImageFile)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookDto> SearchByAutorName(string text)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookDto> SearchByAutorName(string text, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookDto> SearchByName(string text)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookDto> SearchByName(string text, int pag, int element)
        {
            throw new NotImplementedException();
        }



        public new dynamic Insert(IEnumerable<BookDto> list)
        {
            List<string> querys = new List<string>();

           /* foreach (BookDto b in list)
            {

                if (b.Autor.Count > 0)
                {
                    IEnumerable<AutorDto> book_autors = b.Autor;

                    foreach (AutorDto autor in book_autors)
                    {
                        Autor search = _Context.Set<Autor>().Find(autor);
                        if (search != null)
                        {
                            b.Autor.Remove(autor);
                            string query = $"Insert into BookAutor values ('{b.IdBook}','{ autor.IdAutor}')";
                            querys.Add(query);
                        }
                    }
                }
                if (b.Gender.Count > 0)
                {

                    IEnumerable<GenderDto> book_genders = b.Gender;
                    foreach (GenderDto gender in book_genders)
                    {
                        Gender search = _Context.Set<Gender>().Find(gender.IdGender);
                        if (search != null)
                        {
                            b.Gender.Remove(gender);
                            string query = $"Insert into BookGender values('{b.IdBook}','{gender.IdGender}')";
                            querys.Add(query);
                        }
                    }
                }

                Book book = mapper.Map<Book>(b);
                _repository.Insert(book);
                AddBookToStore(book);
                AddBookToWareHouse(book);
                querys.ForEach(query => _repository.SqlQuery(query));
                _repository.Save();





            }
           */


            return messages;

        }

        public new dynamic Update(IEnumerable<BookDto> list)
        {
            foreach (BookDto entity in list)
            {
                Book book = mapper.Map<Book>(entity);
                _repository.Update(book);
                UpdateBookAutors(book);
                UpdateBookGenders(book);
                UpdatePrice(book);
            }
            return _repository.Save();


        }



        private void AddBookToStore(Book b)
        {
           /* IEnumerable<Store> stores = _Context.Set<Store>();
            foreach (Store store in stores)
            {
                BookStore bookStore = new BookStore()
                {
                    IdBookStore = IdGenerator.GetNewId(),
                    IdBook = b.IdBook,
                    BookPrice = b.Price,
                    Stock = 0,
                    IdStore = store.IdStore
                };
                _Context.Set<BookStore>().Add(bookStore);
            }*/
        }

        private void AddBookToWareHouse(Book b)
        {
          /*  IEnumerable<WareHouse> wareHouses = _Context.Set<WareHouse>();
            foreach (WareHouse ware in wareHouses)
            {
                WareHouseBook wareHouseBook = new WareHouseBook()
                {
                    IdWareHouse = ware.IdWareHouse,
                    IdBook = b.IdBook,
                    IdWareHouseBook = IdGenerator.GetNewId(),
                    Stock = 0,

                };
                _Context.Set<WareHouseBook>().Add(wareHouseBook);
            }*/
        }

        private void UpdatePrice(Book entity)
        {
          /*  List<BookStore> bookStores = _Context.Set<BookStore>().Where(w => w.IdBook.Equals(entity.IdBook)).ToList();
            bookStores.ForEach(e => e.BookPrice = entity.Price);
        //    _bookStoreRepository.Update(bookStores);
          */
        }

        public new dynamic Delete(IEnumerable<string> ids)
        {

            foreach (string id in ids)
            {
                Book search = _repository.Get(id);
                if (search != null)
                {
                    if (!HasConnections(search.IdBook))
                    {

                       /* var query = $"Delete from BookAutor where IdBook='{search.IdBook}';";
                        _repository.SqlQuery(query);
                        _repository.Delete(search.IdBook);
                        _Context.Set<BookStore>().RemoveRange(_Context.Set<BookStore>().Where(w => w.IdBook.Equals(id)));
                        _Context.Set<WareHouseBook>().RemoveRange(_Context.Set<WareHouseBook>().Where(w => w.IdBook.Equals(id)));
                        DeleteBookAutors(search.Autor.ToList(), search);
                        DeleteBookGenders(search.Gender.ToList(), search);
                        _repository.Delete(search.IdBook);

                        */
                    }
                    else
                    {
                        return messages;
                    }
                }
                else
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Nucleo.Utilities.Enums.MessageCode.exception,
                        Error = true,
                        Type = Nucleo.Utilities.Enums.MessageType.Exception,
                        Note = $"any {name} was found with this Id :{id}"
                    };
                    messages.Add(message);
                }
            }
            return messages;
        }


        private bool HasConnections(string id)
        {
            int n = 0;
            n += HasSales(id) ? 1 : 0;
            n += HasReservations(id) ? 1 : 0;
            n += HasOrders(id) ? 1 : 0;
            n += HasPurchase(id) ? 1 : 0;
            n += HasShippings(id) ? 1 : 0;
            return n > 0;
        }

        private bool HasSales(string id)
        {
           /* bool exists = _Context.Set<SaleLine>().Where(w => w.IdBook.Equals(id)) != null;
            if (exists)
            {
                MessageControl message = new MessageControl()
                {
                    Code = Nucleo.Utilities.Enums.MessageCode.correct,
                    Error = false,
                    Type = Nucleo.Utilities.Enums.MessageType.Delete,
                    Note = $"{name} with Id :{id} have Sales"
                };
                messages.Add(message);
            }*/
            return true;
        }

        private bool HasReservations(string id)
        {
            /*bool exists = _Context.Set<Reservation>().Where(w => w.IdBook.Equals(id)).ToList() != null;
            if (exists)
            {
                MessageControl message = new MessageControl()
                {
                    Code = Nucleo.Utilities.Enums.MessageCode.correct,
                    Error = false,
                    Type = Nucleo.Utilities.Enums.MessageType.Delete,
                    Note = $"{name} with Id :{id} have Reservations"
                };
                messages.Add(message);
            }
            return exists*/ return true;
        }

        private bool HasOrders(string id)
        {
          /*  bool exists = _Context.Set<OrderLine>().Where(w => w.IdBook.Equals(id)).ToList() != null;
            if (exists)
            {
                MessageControl message = new MessageControl()
                {
                    Code = Nucleo.Utilities.Enums.MessageCode.correct,
                    Error = false,
                    Type = Nucleo.Utilities.Enums.MessageType.Delete,
                    Note = $"{name} with Id :{id} have Orders"
                };
                messages.Add(message);
            }*/
            return true;
        }

        private bool HasPurchase(string id)
        {
         /*   bool exists = _Context.Set<PurchaseLine>().Where(W => W.IdBook.Equals(id)).ToList() != null;
            if (exists)
            {
                MessageControl message = new MessageControl()
                {
                    Code = Nucleo.Utilities.Enums.MessageCode.correct,
                    Error = false,
                    Type = Nucleo.Utilities.Enums.MessageType.Delete,
                    Note = $"{name} with Id:{id} have Purchases"
                };
                messages.Add(message);
            }
          */
            return true;
        }

        private bool HasShippings(string id)
        {
          /*  bool exists = _Context.Set<Book>().Where(w => w.IdBook.Equals(id)).ToList() != null;
            if (exists)
            {
                MessageControl message = new MessageControl()
                {
                    Code = Nucleo.Utilities.Enums.MessageCode.correct,
                    Error = false,
                    Type = Nucleo.Utilities.Enums.MessageType.Delete,
                    Note = $"{name} with Id :{id} have Shippings"
                };
                messages.Add(message);
            }
          */
            return true;
        }
        private void UpdateBookAutors(Book entity)
        {
          /*  IEnumerable<Autor> autorsDb = _Context.Set<Autor>().Where(w => w.Book.Any(b => b.IdBook.Equals(entity.IdBook)));
            /* var DataBaseDto = mapper.Map<List<AutorDto>>(autorsDb);*/
            //DeleteBookAutors(autorsDb, entity);*/
            /*CreateBookAutors(entity, DataBaseDto);*/
        }

        private void UpdateBookGenders(Book entity)
        {
          //  IEnumerable<Gender> genersDb = _Context.Set<Gender>().Where(w => w.Book.Any(b => b.IdBook.Equals(entity.IdBook)));
         /*   DeleteBookGenders(genersDb, entity);
            CreateBookGenders(genersDb, entity);*/
        }

        private void DeleteBookGenders(IEnumerable<Gender> list, Book entity)
        {/*
            if (list.Count>0)
            {
                List<GenderDto> genderFromDB = mapper.Map<List<GenderDto>>(list);
                List<GenderDto> genderDtos = mapper.Map<List<GenderDto>>(entity.Gender);
                foreach (GenderDto gender in genderFromDB)
                {
                    if (!genderDtos.Contains(gender))
                    {
                        list.Remove(mapper.Map<Gender>(gender));
                        var query = string.Format("Delete from BookGender where IdBook='{0}' AND IdGender='{1}' ;", entity.IdBook,gender.IdGender );
                        Context.Database.ExecuteSqlCommand(query);
                    }
                }
                Save();
            }*/
        }

        private void CreateBookGenders(IEnumerable<Gender> list, Book entity)
        {/*
            if (list.Count>0)
            {
                List<GenderDto> genderFromDB = mapper.Map<List<GenderDto>>(list);
                List<GenderDto> genderDtos = mapper.Map<List<GenderDto>>(entity.Gender);
                foreach (GenderDto dto in genderDtos)
                {
                    if (!genderFromDB.Contains(dto))
                    {
                        var query = string.Format("Insert into BookGender values('{0}','{1}')", entity.IdBook,dto.IdGender);
                        Context.Database.ExecuteSqlCommand(query);
                    }
                }
            }
            else if (entity.Gender.Count>0)
            {
                foreach (Gender gender in entity.Gender)
                {
                    var query = string.Format("Insert into BookGender values('{0}','{1}')", entity.IdBook,gender.IdGender );
                    Context.Database.ExecuteSqlCommand(query);
                }

            }
            Save();*/
        }

        private void DeleteBookAutors(IEnumerable<Autor> list, Book entity)
        {
            /*
            if (list.Count > 0)
            {

                List<AutorDto> AutorDtoDb = mapper.Map<List<AutorDto>>(list);
                List<AutorDto> AutorDtos = mapper.Map<List<AutorDto>>(entity.Autor);
                foreach (AutorDto e in AutorDtoDb)
                {
                    if (!AutorDtos.Contains(e))
                    {
                        list.Remove(mapper.Map<Autor>(e));
                        var query = string.Format("Delete from BookAutor where IdBook='{0}' AND IdAutor='{1}' ;", entity.IdBook, e.IdAutor);
                        Context.Database.ExecuteSqlCommand(query);
                    }
                }
                Save();
            }*/
        }

        /*   private void CreateBookAutors(Book entity, List<AutorDto> DataBaseDto)
           {
               /*
               if (entity.Autor.Count>0)
               {
                   var dto = mapper.Map<BookDto>(entity);
                   if (DataBaseDto.Count>0)
                   {
                       foreach (AutorDto autorDto in dto.Autor)
                       {
                           if (!DataBaseDto.Contains(autorDto))
                           {
                               var query = string.Format("Insert into BookAutor values('{0}','{1}')", entity.IdBook, autorDto.IdAutor);
                               Context.Database.ExecuteSqlCommand(query);
                           }
                       }
                       Save();
                   }
                   else
                   {
                       foreach (Autor e in entity.Autor)
                       {
                           var query = string.Format("Insert into BookAutor values ('{0}','{1}'); ", entity.IdBook, e.IdAutor);
                           Context.Database.ExecuteSqlCommand(query);
                       }
                       Save();
                   }

               }
           }*/



    }
}
