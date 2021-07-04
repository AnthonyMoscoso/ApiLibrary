using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System.Collections.Generic;

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
            
            return mapper.Map<BookTypeDto>(_repository.GetByName(text));
        }

        public IEnumerable<BookTypeDto> SearchByName(string text)
        {
            return mapper.Map<IEnumerable<BookTypeDto>>(_repository.SearchByName(text));
        }

        public IEnumerable<BookTypeDto> SearchByName(string text, int pag, int element)
        {
            return mapper.Map<IEnumerable<BookTypeDto>>(_repository.SearchByName(text,pag,element));
        }
    }
}
