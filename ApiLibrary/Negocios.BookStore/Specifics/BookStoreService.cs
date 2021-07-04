using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Specifics
{
    public class BookStoreService : ServiceMapperBase<BookStoreDto, BookStore>, IBookStoreService
    {
        readonly new IBookStoreRepository _repository;
        public BookStoreService(IBookStoreRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public int GetStock(string idBook, string idStore)
        {
           return _repository.GetStock(idBook,idStore);
        }
    }
}
