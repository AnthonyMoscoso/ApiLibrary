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

namespace Models.Repositories.Concrect.Books
{
    public class BookRepository : Repository<Book,BookDto>, IBookRepository
    {
        public BookRepository(string identificator="IdBook") : base(identificator)
        {
        }

        #region Autor
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

        #endregion

        #region Category
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

        #endregion

        #region Edition
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

        #endregion

        #region Editorial
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

        #endregion

        #region gender
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

        #endregion


        #region Search By Name
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

        #endregion


        #region Search By Autor Name
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
        #endregion


        public new  dynamic Insert(List<Book>list)
        {
            List<string> querys = new List<string>();

            foreach (Book b in list)
            {

                if (b.Autor.Count>0)
                {            
                    List<Autor> book_autors = b.Autor.ToList();
                    
                    foreach (Autor autor in book_autors)
                    {
                        var search = Context.Autor.Find(autor.IdAutor);
                        if (search != null)
                        {
                            b.Autor.Remove(autor);
                            var query = string.Format("Insert into BookAutor values ('{0}','{1}')", b.IdBook, autor.IdAutor);
                            querys.Add(query);
                        }
                    }
                }
                if (b.Gender.Count > 0)
                {

                    List<Gender> book_genders = b.Gender.ToList();
                    foreach (Gender gender in book_genders)
                    {
                        var search = Context.Gender.Find(gender.IdGender);
                        if (search != null)
                        {
                            b.Gender.Remove(gender);
                            var query = string.Format("Insert into BookGender values('{0}','{1}')", b.IdBook, gender.IdGender);
                            querys.Add(query);
                        }
                    }
                }

                try
                {
                   
                    dbSet.Add(b);
                  
                    AddBookToStore(b);
                    AddBookToWareHouse(b);
                    Context.SaveChanges();
                    querys.ForEach(query => Context.Database.ExecuteSqlCommand(query));
                    Context.SaveChanges();
                    MessageControl message = new MessageControl()
                    {
                       Code = Nucleo.Utilities.Enums.MessageCode.correct,
                       Error = false,
                       Type = Nucleo.Utilities.Enums.MessageType.Insert,
                       Note = $"{name} with {Identificator} : {b.IdBook} was insert"
                    };
                    messages.Add(message);
                }
                catch(DbUpdateException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Nucleo.Utilities.Enums.MessageCode.exception,
                        Error = true,
                        Type = Nucleo.Utilities.Enums.MessageType.Exception,
                        Note = e.InnerException.InnerException.Message
                    };
                    dbSet.Remove(b);
                    messages.Add(message);
                }
                catch(SqlException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Nucleo.Utilities.Enums.MessageCode.exception,
                        Error = true,
                        Type = Nucleo.Utilities.Enums.MessageType.Exception,
                        Note = e.InnerException.InnerException.Message
                    };
                    dbSet.Remove(b);
                    messages.Add(message);
                }
                catch (Exception e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Nucleo.Utilities.Enums.MessageCode.exception,
                        Error = true,
                        Type = Nucleo.Utilities.Enums.MessageType.Exception,
                        Note = e.InnerException.InnerException.Message
                    };
                    dbSet.Remove(b);
                    messages.Add(message);
                }
    


            }
          
           

            return messages;
    
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

      
        
        private void AddBookToStore(Book b)
        {
            List<Store> stores = Context.Store.ToList();
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
                    Context.BookStore.Add(bookStore);
            }             
        }

        private void AddBookToWareHouse(Book b)
        {
            List<WareHouse> wareHouses = Context.WareHouse.ToList();
            foreach (WareHouse ware in wareHouses)
            {
                WareHouseBook wareHouseBook = new WareHouseBook()
                {
                        IdWareHouse = ware.IdWareHouse,
                        IdBook = b.IdBook,
                        IdWareHouseBook = IdGenerator.GetNewId(),
                        Stock =0,
                        
                 };
                Context.WareHouseBook.Add(wareHouseBook);
            }
        }

        private void UpdatePrice(Book entity)
        {
            Context.BookStore.Where(w => w.IdBook.Equals(entity.IdBook)).ToList().ForEach(e=> e.BookPrice=entity.Price);
            Save();
        }

        public new dynamic Delete(List<string> ids)
        {
           
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search!=null)
                {
                    if (!HasConnections(search.IdBook))
                    {
                        try
                        {
                            var query = string.Format("Delete from BookAutor where IdBook='{0}';", search.IdBook);
                            Context.Database.ExecuteSqlCommand(query);

                            Context.BookStore.RemoveRange(Context.BookStore.Where(w => w.IdBook.Equals(id)).ToList());
                            Context.WareHouseBook.RemoveRange(Context.WareHouseBook.Where(w => w.IdBook.Equals(id)).ToList());

                            DeleteBookAutors(search.Autor.ToList(), search);
                            DeleteBookGenders(search.Gender.ToList(), search);
                            dbSet.Remove(search);

                            Context.SaveChanges();
                        }
                        catch (DbUpdateException e)
                        {
                            MessageControl message = new MessageControl()
                            {
                                Code = Nucleo.Utilities.Enums.MessageCode.exception,
                                Error = true,
                                Type = Nucleo.Utilities.Enums.MessageType.Exception,
                                Note = e.InnerException.InnerException.Message
                            };
                           
                            messages.Add(message);
                        }
                        catch (SqlException e)
                        {
                            MessageControl message = new MessageControl()
                            {
                                Code = Nucleo.Utilities.Enums.MessageCode.exception,
                                Error = true,
                                Type = Nucleo.Utilities.Enums.MessageType.Exception,
                                Note = e.InnerException.InnerException.Message
                            };
                            
                            messages.Add(message);
                        }
                        catch (Exception e)
                        {
                            MessageControl message = new MessageControl()
                            {
                                Code = Nucleo.Utilities.Enums.MessageCode.exception,
                                Error = true,
                                Type = Nucleo.Utilities.Enums.MessageType.Exception,
                                Note = e.InnerException.InnerException.Message
                            };
                            
                            messages.Add(message);
                        }
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
                        Note = $"any {name} was found with this {Identificator} :{id}"
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
            bool exists = Context.SaleLine.Where(w => w.IdBook.Equals(id)).ToList() != null;
            if (exists)
            {
                MessageControl message = new MessageControl()
                {
                    Code = Nucleo.Utilities.Enums.MessageCode.correct,
                    Error = false,
                    Type = Nucleo.Utilities.Enums.MessageType.Delete,
                    Note = $"{name} with {Identificator} :{id} have Sales"
                };
                messages.Add(message);
            }
            return exists ;
        }

        private bool HasReservations(string id)
        {
            bool exists = Context.Reservation.Where(w => w.IdBook.Equals(id)).ToList() != null;
            if (exists)
            {
                MessageControl message = new MessageControl()
                {
                    Code = Nucleo.Utilities.Enums.MessageCode.correct,
                    Error = false,
                    Type = Nucleo.Utilities.Enums.MessageType.Delete,
                    Note = $"{name} with {Identificator} :{id} have Reservations"
                };
                messages.Add(message);
            }
            return exists;
        }

        private bool HasOrders(string id)
        {
            bool exists = Context.OrderLine.Where(w => w.IdBook.Equals(id)).ToList() != null;
            if (exists)
            {
                MessageControl message = new MessageControl()
                {
                    Code = Nucleo.Utilities.Enums.MessageCode.correct,
                    Error = false,
                    Type = Nucleo.Utilities.Enums.MessageType.Delete,
                    Note = $"{name} with {Identificator} :{id} have Orders"
                };
                messages.Add(message);
            }
            return exists;
        }

        private bool HasPurchase(string id)
        {
            bool exists = Context.PurchaseLine.Where(W => W.IdBook.Equals(id)).ToList() != null;
            if (exists)
            {
                MessageControl message = new MessageControl()
                {
                    Code = Nucleo.Utilities.Enums.MessageCode.correct,
                    Error = false,
                    Type = Nucleo.Utilities.Enums.MessageType.Delete,
                    Note = $"{name} with {Identificator} :{id} have Purchases"
                };
                messages.Add(message);
            }

            return exists;
        }

        private bool HasShippings(string id)
        {
            bool exists = Context.SaleLine.Where(w => w.IdBook.Equals(id)).ToList() != null;
            if (exists)
            {
                MessageControl message = new MessageControl()
                {
                    Code = Nucleo.Utilities.Enums.MessageCode.correct,
                    Error = false,
                    Type = Nucleo.Utilities.Enums.MessageType.Delete,
                    Note = $"{name} with {Identificator} :{id} have Shippings"
                };
                messages.Add(message);
            }
           
            return exists;
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