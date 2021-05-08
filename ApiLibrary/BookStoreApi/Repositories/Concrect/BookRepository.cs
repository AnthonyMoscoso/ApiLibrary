using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Models.Request;
using BookStoreApi.Repositories.Abstract;
using BookStoreApi.Utilities;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Books
{
    public class BookRepository : Repository<Book,BookDto>, IBookRepository
    {
        public BookRepository(string identificator="IdBook") : base(identificator)
        {
        }

        public List<BookDto> GetByAutor(string idAutor)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.IdAutor.Equals(idAutor))).ToList();
            return mapper.Map<List<BookDto>>(list);
        }

        public List<BookDto> GetByAutor(string idAutor, int pag, int element)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.IdAutor.Equals(idAutor)))
                .OrderBy(w => w.BookTittle)
                .Skip((pag - 1) * element)
                .Take(element).ToList();
            return mapper.Map<List<BookDto>>(list);
        }

        public List<BookDto> GetByCategory(string idCategory)
        {
            List<Book>list = dbSet.Where(w => w.IdType.Equals(idCategory) 
            || w.BookType.BookType2.IdFather.Equals(idCategory))
                .ToList();
            return mapper.Map<List<BookDto>>(list);
        }

        public List<BookDto> GetByCategory(string idCategory, int pag, int element)
        {
            List<Book> list = dbSet.Where(w => w.IdType.Equals(idCategory) || w.BookType.BookType2.IdFather.Equals(idCategory))
               .OrderBy(w=>w.BookTittle)
               .Skip((pag-1)*element)
               .Take(element).ToList();
            return mapper.Map<List<BookDto>>(list);
        }

        public List<BookDto> GetByEdition(string idEdition)
        {
            var list = dbSet.Where(w => w.IdEdition.Equals(idEdition)).ToList();
            return mapper.Map<List<BookDto>>(list);
        }

        public List<BookDto> GetByEdition(string idEdition, int pag, int element)
        {
            var list = dbSet.Where(w => w.IdEdition.Equals(idEdition))
                 .OrderBy(w => w.BookTittle)
                 .Skip((pag - 1) * element).Take(element)
                 .ToList();
            return mapper.Map<List<BookDto>>(list);
        }

        public List<BookDto> GetByEditorial(string idEditorial)
        {
            var list = dbSet.Where(w => w.BookEditorial.Any(e => e.IdEditorial.Equals(idEditorial))).ToList();
            return mapper.Map<List<BookDto>>(list);
        }

        public List<BookDto> GetByEditorial(string idEditorial, int pag, int element)
        {
            var list = dbSet.Where(w => w.BookEditorial.Any(e => e.IdEditorial.Equals(idEditorial)))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<BookDto>>(list);
        }

        public List<BookDto> GetByGender(List<string> idGeners)
        {
            var list = dbSet.Where(w => w.Gender.Any(g => idGeners.Any(y=> y.Equals(g.IdGender)))).ToList();
            return mapper.Map<List<BookDto>>(list);
        }

        public List<BookDto> GetByGender(List<string> idGenders, int pag, int element)
        {
            var list = dbSet.Where(w => w.Gender.Any(g => idGenders.Any(y => y.Equals(g.IdGender))))
                 .OrderBy(w => w.BookTittle)
                 .Skip((pag - 1) * element).Take(element)
                 .ToList();
            return mapper.Map<List<BookDto>>(list);
        }



        public List<BookDto> SearchByName(string text)
        {
            var list = dbSet.Where(w => w.BookTittle.Contains(text)).ToList();
            return mapper.Map<List<BookDto>>(list);
        }
        public List<BookDto> SearchByName(string text,int pag,int element)
        {
            var list = dbSet.Where(w => w.BookTittle.Contains(text))
                .OrderBy(w => w.BookTittle)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<BookDto>>(list);
        }

        public List<BookDto> SearchByAutorName(string text)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.AutorName.Contains(text))).ToList();
            return mapper.Map<List<BookDto>>(list);
        }

        public List<BookDto> SearchByAutorName(string text, int pag, int element)
        {
            var list = dbSet.Where(w => w.Autor.Any(a => a.AutorName.Contains(text)))
                 .OrderBy(w => w.BookTittle)
                 .Skip((pag - 1) * element).Take(element).
                 ToList();
            return mapper.Map<List<BookDto>>(list);
        }
        public new  dynamic Insert(List<Book>list)
        {
            string message = "";
            var stores = Context.Store.ToList();
            List<Book> booksWithAutors = new List<Book>();
            List<Book> booksWithGender = new List<Book>();
            foreach (Book b in list)
            {
                if (b.Autor.Count>0)
                {
                    Book book = new Book
                    {
                        Autor = new List<Autor>(),
                        IdBook = b.IdBook
                    };
                    List<Autor> autors = b.Autor.ToList();
                    foreach (Autor autor in autors)
                    {
                        var search = Context.Autor.Find(autor.IdAutor);
                        if (search != null)
                        {
                            b.Autor.Remove(autor);
                            book.Autor.Add(autor);
                        }
                    }
                    if (book.Autor.Count>0)
                    {
                        booksWithAutors.Add(book);
                    }
                }
                if (b.Gender.Count > 0)
                {
                    Book book = new Book
                    {
                        Gender = new List<Gender>(),
                        IdBook = b.IdBook
                    };
                    List<Gender> genders = b.Gender.ToList();
                    foreach (Gender gender in genders)
                    {
                        var search = Context.Gender.Find(gender.IdGender);
                        if (search != null)
                        {
                            b.Gender.Remove(gender);
                            book.Gender.Add(gender);
                        }
                        if (book.Gender.Count>0)
                        {
                            booksWithGender.Add(book);
                        }
                    }
                }

            }
          
            AddBookToStore(stores,list);
            dbSet.AddRange(list);
            message += Save();
            if (booksWithAutors.Count>0)
            {
                foreach (Book bookWithAutor in booksWithAutors)
                {
                    AddAutorToBook(bookWithAutor);
                }
            }
            if (booksWithGender.Count>0)
            {
                foreach (Book bookWithGender in booksWithGender )
                {
                    AddGenderToBook(bookWithGender);
                }
            }
            return message += Save();
        }

        public new dynamic Update(List<Book> list)
        {
            foreach (Book entity in list)
            {
                dbSet.Attach(entity);
                Context.Entry(entity).State = EntityState.Modified;
                Save();
                UpdateBookAutors(entity);
                UpdateBookGenders(entity);
                UpdatePrice(entity);
            }
            return Save();
           

        }

        private void AddAutorToBook(Book b)
        {
            foreach (Autor autor in b.Autor)
            {

                var query = string.Format("Insert into BookAutor values('{0}','{1}')", b.IdBook, autor.IdAutor);
                Context.Database.ExecuteSqlCommand(query);
                
            }
        }
        private void AddGenderToBook(Book b)
        {
            foreach (Gender gender in b.Gender)
            {
                var query = string.Format("Insert into BookGender values('{0}','{1}')", b.IdBook,gender.IdGender);
        
                Context.Database.ExecuteSqlCommand(query);
            }
        }
        private void AddBookToStore(List<Store> stores,List<Book> list)
        {
            foreach (Store store in stores)
            {
                foreach (Book b in list)
                {
                    BookStore bookStore = new BookStore()
                    {
                        IdBookStore = IdGenerator.GetNewId(),
                        IdBook = b.IdBook,
                        BookPrice = b.Price,
                        Stock = 0,
                        IdStore = store.IdStore
                    };

                    Context.BookStore.Add(bookStore);
                }
            }
        }
        private void UpdatePrice(Book entity)
        {
            Context.BookStore.Where(w => w.IdBook.Equals(entity.IdBook)).ToList().ForEach(e=> e.BookPrice=entity.Price);
            Save();
        }

        public new dynamic Delete(List<string> ids)
        {
            string message = "";
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search!=null)
                {
                    if (!HasConnections(search.IdBook))
                    {
                        var query = string.Format("Delete from BookAutor where IdBook='{0}';", search.IdBook);
                        Context.Database.ExecuteSqlCommand(query);
                        message += Save();
                        Context.BookStore.RemoveRange(Context.BookStore.Where(w => w.IdBook.Equals(id)).ToList());
                        Context.WareHouseBook.RemoveRange(Context.WareHouseBook.Where(w => w.IdBook.Equals(id)).ToList());
                        DeleteBookAutors(search.Autor.ToList(), search);
                        DeleteBookGenders(search.Gender.ToList(), search);
                        dbSet.Remove(search);
                        message += Save();
                    }
                    else
                    {
                        message +="Can't delete a book that was sale, puchase..... with id "+ id;
                    }
    
                }
                else
                {
                    message += string.Format(" any book was found with this id :{0}",id);
                }
            }
            return message;
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
            return Context.SaleLine.Where(w => w.IdBook.Equals(id)) != null;
        }

        private bool HasReservations(string id)
        {
           return Context.Reservation.Where(w => w.IdBook.Equals(id)) != null;
        }

        private bool HasOrders(string id)
        {
            return Context.OrderLine.Where(w => w.IdBook.Equals(id)) != null;
        }

        private bool HasPurchase(string id)
        {
            return Context.PurchaseLine.Where(W => W.IdBook.Equals(id)) != null;
        }

        private bool HasShippings(string id)
        {
            return Context.SaleLine.Where(w => w.IdBook.Equals(id)) != null;
        }
        private void UpdateBookAutors(Book entity)
        {
            var autorsDb = Context.Autor.Where(w => w.Book.Any(b => b.IdBook.Equals(entity.IdBook))).ToList();
            var DataBaseDto = mapper.Map<List<AutorDto>>(autorsDb);
            DeleteBookAutors(autorsDb, entity);
            CreateBookAutors(entity, DataBaseDto);
        }

        private void UpdateBookGenders(Book entity)
        {
            var genersDb = Context.Gender.Where(w => w.Book.Any(b => b.IdBook.Equals(entity.IdBook))).ToList();
            DeleteBookGenders(genersDb,entity);
            CreateBookGenders(genersDb,entity);
        }

        private void DeleteBookGenders(List<Gender> list,Book entity)
        {
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
            }
        }

        private void CreateBookGenders(List<Gender> list,Book entity)
        {
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
            Save();
        }

        private void DeleteBookAutors(List<Autor>list,Book entity)
        {

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
            }
        }

        private void CreateBookAutors(Book entity, List<AutorDto> DataBaseDto)
        {

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
        }
        public List<BookStoreDto> Store(string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public dynamic RemoveImage(string idBook, string idImageFile)
        {
            throw new NotImplementedException();
        }

        public dynamic AddImage(string idBook, string idImageFile)
        {
            throw new NotImplementedException();
        }
    }
}