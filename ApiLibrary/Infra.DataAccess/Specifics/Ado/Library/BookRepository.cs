using Models.Ado.Library;
using System.Collections.Generic;
using System.Linq;
using Core.DBAccess.Ado;
using BookStoreApi.Utilities.Enums;

namespace Ado.Library.Specifics
{
    public class BookRepository : AdoRepository<Book>, IBookRepository
    {

        public BookRepository(BookStoreEntities context,  string identificator = "IdBook") : base(context, identificator)
        {
        }


        public new dynamic Insert(Book entity)
        {
            List<string> querys = new List<string>();
            if (entity.Autor.Count > 0)
            {
                IEnumerable<Autor> book_autors = entity.Autor;
                foreach (Autor autor in book_autors)
                {
                    Autor search = _Context.Set<Autor>().Find(autor);
                    if (search != null)
                    {
                        entity.Autor.Remove(autor);
                        string query = $"Insert into BookAutor values ('{entity.IdBook}','{ autor.IdAutor}')";
                        querys.Add(query);
                    }
                }
            }
            if (entity.Gender.Count > 0)
            {

                IEnumerable<Gender> book_genders = entity.Gender;
                foreach (Gender gender in book_genders)
                {
                    Gender search = _Context.Set<Gender>().Find(gender.IdGender);
                    if (search != null)
                    {
                        entity.Gender.Remove(gender);
                        string query = $"Insert into BookGender values('{entity.IdBook}','{gender.IdGender}')";
                        querys.Add(query);
                    }
                }
            }
            base.Insert(entity);
            AddBookToStore(entity);
            AddBookToWareHouse(entity);
            querys.ForEach(query => base.ExecuteQuery(query));
            Save();
            return entity;
        }

        public new dynamic Update(Book entity)
        {
            return null;
        }

        private void AddBookToStore(Book b)
        {
            IEnumerable<Store> stores = _Context.Set<Store>();
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
            }
        }

        private void AddBookToWareHouse(Book b)
        {
            IEnumerable<WareHouse> wareHouses = _Context.Set<WareHouse>();
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
            }
        }

        private void UpdatePrice(Book entity)
        {
             List<BookStore> bookStores = _Context.Set<BookStore>().Where(w => w.IdBook.Equals(entity.IdBook)).ToList();
             bookStores.ForEach(e => e.BookPrice = entity.Price);
             Save(); 
        }

        public new dynamic Delete(IEnumerable<string> ids)
        {

            foreach (string id in ids)
            {
                Book search = GetSingle(id);
                if (search != null)
                {
                    if (!HasConnections(search.IdBook))
                    {

                        var query = $"Delete from BookAutor where IdBook='{search.IdBook}';";
                        ExecuteQuery(query);  
                        _Context.Set<BookStore>().RemoveRange(_Context.Set<BookStore>().Where(w => w.IdBook.Equals(id)));
                        _Context.Set<WareHouseBook>().RemoveRange(_Context.Set<WareHouseBook>().Where(w => w.IdBook.Equals(id)));
                        DeleteBookAutors(search.Autor.ToList(), search);
                        DeleteBookGenders(search.Gender.ToList(), search);
                        base.Delete(search.IdBook);


                    }                  
                }
            }
            return null;
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
           return  _Context.Set<SaleLine>().Where(w => w.IdBook.Equals(id)) != null;

        }

        private bool HasReservations(string id)
        {
           return _Context.Set<Reservation>().Where(w => w.IdBook.Equals(id)).ToList() != null;
        
        }

        private bool HasOrders(string id)
        {
            return _Context.Set<OrderLine>().Where(w => w.IdBook.Equals(id)).ToList() != null;

        }

        private bool HasPurchase(string id)
        {
            return _Context.Set<PurchaseLine>().Where(W => W.IdBook.Equals(id)).ToList() != null;

        }

        private bool HasShippings(string id)
        {
          return _Context.Set<Book>().Where(w => w.IdBook.Equals(id)).ToList() != null;

        }
        private void UpdateBookAutors(Book entity)
        {
            IEnumerable<Autor> autorsDb = _Context.Set<Autor>().Where(w => w.Book.Any(b => b.IdBook.Equals(entity.IdBook)));

            DeleteBookAutors(autorsDb.ToList(), entity);
            CreateBookAutors(entity, autorsDb.ToList());
            Save();
        }

        private void UpdateBookGenders(Book entity)
        {
            IEnumerable<Gender> genersDb = _Context.Set<Gender>().Where(w => w.Book.Any(b => b.IdBook.Equals(entity.IdBook)));
            DeleteBookGenders(genersDb, entity);
            CreateBookGenders(genersDb, entity);
            Save();
        }

        private void DeleteBookGenders(IEnumerable<Gender> list, Book entity)
        {
            if (list.Count() > 0)
            {
                List<Gender> genders = list.ToList(); 
                foreach (Gender gender in entity.Gender)
                {
                    if (!entity.Gender.Contains(gender))
                    {
                        genders.Remove(gender);
                        var query = string.Format("Delete from BookGender where IdBook='{0}' AND IdGender='{1}' ;", entity.IdBook, gender.IdGender);
                        _Context.Database.ExecuteSqlCommand(query);
                    }
                }

            }
             Save();

        }

        private void CreateBookGenders(IEnumerable<Gender> gendersFromDb, Book entity)
        {
            if (gendersFromDb.Count() > 0)
            {

                List<Gender> gendersBook = entity.Gender.ToList();
                foreach (Gender dto in gendersBook)
                {
                    Gender g = gendersBook.FirstOrDefault( w=> w.IdGender.Equals(dto.IdGender));
                    if (g!=null)
                    {
                        var query = string.Format("Insert into BookGender values('{0}','{1}')", entity.IdBook, dto.IdGender);
                        _Context.Database.ExecuteSqlCommand(query);
                    }

                }
            }
            else if (entity.Gender.Count > 0)
            {
                foreach (Gender gender in entity.Gender)
                {
                    var query = string.Format("Insert into BookGender values('{0}','{1}')", entity.IdBook, gender.IdGender);
                    _Context.Database.ExecuteSqlCommand(query);
                }

            }
            Save();
        }

        private void DeleteBookAutors(IList<Autor> autorsFromDb, Book entity)
        {

            if (autorsFromDb.Count() > 0)
            {


                foreach (Autor autor in autorsFromDb)
                {
                    Autor search = entity.Autor.FirstOrDefault(w => w.IdAutor.Equals(autor.IdAutor));
                    if (search!=null)
                    {
                        autorsFromDb.Remove(autor);
                        var query = string.Format("Delete from BookAutor where IdBook='{0}' AND IdAutor='{1}' ;", entity.IdBook, autor.IdAutor);
                        _Context.Database.ExecuteSqlCommand(query);
                    }
                }
               
            }
            Save();
        }

        private void CreateBookAutors(Book entity, List<Autor> AutorsFromDb)
        {

            if (entity.Autor.Count > 0)
            {
                
                if (AutorsFromDb.Count > 0)
                {
                    foreach (Autor autor in entity.Autor)
                    {
                        if (!AutorsFromDb.Contains(autor))
                        {
                            var query = string.Format("Insert into BookAutor values('{0}','{1}')", entity.IdBook, autor.IdAutor);
                            _Context.Database.ExecuteSqlCommand(query);
                        }
                    }
                    Save();
                }
                else
                {
                    foreach (Autor e in entity.Autor)
                    {
                        var query = string.Format("Insert into BookAutor values ('{0}','{1}'); ", entity.IdBook, e.IdAutor);
                        _Context.Database.ExecuteSqlCommand(query);
                    }
                    Save();
                }

            }
        }





    }
}