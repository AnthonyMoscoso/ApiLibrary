using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.DBAccess.Ado;
using Core.Services.Abstracts;
using System.Collections.Generic;
using Ado.Library;
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class EditorialService : ServiceMapperBase<EditorialDto, Editorial>, IEditorialService
    {
        readonly new IEditorialRepository _repository;
        public EditorialService(IEditorialRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<EditorialDto> SearchByName(string text)
        {
            IEnumerable<Editorial> result = _repository.SearchByName(text);
            return mapper.Map<IEnumerable<EditorialDto>>(result);
        }

        public IEnumerable<EditorialDto> SearchByName(string text, int pag, int element)
        {
            IEnumerable<Editorial> result = _repository.SearchByName(text,pag,element);
            return mapper.Map<IEnumerable<EditorialDto>>(result);
        }
    }
}
