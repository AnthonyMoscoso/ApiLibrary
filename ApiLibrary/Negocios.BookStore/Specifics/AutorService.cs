using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.Services.Abstracts;
using System.Collections.Generic;
using System.Linq;

namespace Negocios.BookStoreServices.Specifics
{
    public class AutorService : ServiceMapperBase<AutorDto, Autor>, IAutorService
    {
        readonly new IAutorRepository _repository;
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
            return Map(entity);

        }

        public IEnumerable<AutorDto> SearchByName(string text)
        {

            return Map(_repository.Get(w => w.AutorName.Contains(text)));
        }

        public IEnumerable<AutorDto> SearchByName(string text, int pag, int element)
        {
            return Map(_repository.Get(w => w.AutorName.Contains(text)).Skip((pag - 1) * element).Take(element));
        }



    }
}
