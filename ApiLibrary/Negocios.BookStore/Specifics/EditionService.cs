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
    public class EditionService : ServiceMapperBase<EditionDto, Edition>, IEditionService
    {
        readonly new IEditionRepository _repository;
        public EditionService(IEditionRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<EditionDto> SearchByName(string text)
        {
            IEnumerable<Edition> result = _repository.SearchByName(text);
            return mapper.Map<IEnumerable<EditionDto>>(result);
        }

        public IEnumerable<EditionDto> SearchByName(string text, int pag, int element)
        {
            IEnumerable<Edition> result = _repository.SearchByName(text,pag,element);
            return mapper.Map<IEnumerable<EditionDto>>(result);
        }
    }
}
