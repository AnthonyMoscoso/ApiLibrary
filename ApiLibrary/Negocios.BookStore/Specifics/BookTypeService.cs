using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.DBAccess.Ado;
using Nucleo.Services.Abstracts;
using System.Collections.Generic;

namespace Negocios.BookStoreServices.Specifics
{
    public class BookTypeService : ServiceMapperBase<BookTypeDto, BookType>, IBookTypeService
    {
        IBookTypeRepository _Irepository;
        public BookTypeService(IBookTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public BookTypeDto GetByName(string text)
        {
            
            return mapper.Map<BookTypeDto>(_Irepository.GetByName(text));
        }

        public IEnumerable<BookTypeDto> SearchByName(string text)
        {
            return mapper.Map<IEnumerable<BookTypeDto>>(_Irepository.SearchByName(text));
        }

        public IEnumerable<BookTypeDto> SearchByName(string text, int pag, int element)
        {
            return mapper.Map<IEnumerable<BookTypeDto>>(_Irepository.SearchByName(text,pag,element));
        }
    }
}
