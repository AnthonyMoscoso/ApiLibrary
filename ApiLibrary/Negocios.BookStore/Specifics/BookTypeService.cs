using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System.Collections.Generic;
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class BookTypeService : ServiceMapperBase<BookTypeDto, BookType>, IBookTypeService
    {
        readonly new  IBookTypeRepository _repository;
        public BookTypeService(IBookTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public BookTypeDto GetByName(string text)
        {
            BookType result = _repository.GetByName(text);
            return mapper.Map<BookTypeDto>(result);
        }

        public IEnumerable<BookTypeDto> SearchByName(string text)
        {
            IEnumerable<BookType> result = _repository.SearchByName(text);
            return mapper.Map<IEnumerable<BookTypeDto>>(result);
        }

        public IEnumerable<BookTypeDto> SearchByName(string text, int pag, int element)
        {
            IEnumerable<BookType> result = _repository.SearchByName(text, pag, element);
            return mapper.Map<IEnumerable<BookTypeDto>>(result);
        }
    }
}
