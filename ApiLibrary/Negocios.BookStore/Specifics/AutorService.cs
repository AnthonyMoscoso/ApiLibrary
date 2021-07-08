using Models.Ado.Library;
using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using Core.Services.Abstracts;
using System.Collections.Generic;
using System.Linq;
using Ado.Library;
using Logger.Specifics;
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class AutorService : ServiceMapperBase<AutorDto, Autor>, IAutorService
    {
        new readonly IAutorRepository _repository;
        public AutorService(IAutorRepository repository) : base(repository)
        {
            _repository = repository;
           
        }

        public bool ExistName(string name)
        {
           return   _repository.ExistName(name);
        }

        public AutorDto GetByName(string name)
        {
            Autor entity  = _repository.GetByName(name);
            return mapper.Map<AutorDto>(entity);

        }

        public IEnumerable<AutorDto> SearchByName(string text)
        {
            IEnumerable<Autor> result = _repository.Get(w => w.AutorName.Contains(text));
            return mapper.Map<IEnumerable<AutorDto>>(result);
        }

        public IEnumerable<AutorDto> SearchByName(string text, int pag, int element)
        {
            IEnumerable<Autor> result = _repository.Get(w => w.AutorName.Contains(text)).OrderBy(w=> w.AutorName).Skip((pag - 1) * element).Take(element);
            return mapper.Map<IEnumerable<AutorDto>>(result);
        }



    }
}
