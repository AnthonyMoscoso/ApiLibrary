
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
    public class BookEditorialService : ServiceMapperBase<BookEditorialDto, BookEditorial>, IBookEditorialService
    {
        readonly new IBookEditorialRepository _repository;
        public BookEditorialService(IBookEditorialRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public double GetPurchasePrice(string idBook, string idEditorial)
        {
           return  _repository.GetPurchasePrice(idBook,idEditorial);
        }
    }
}
