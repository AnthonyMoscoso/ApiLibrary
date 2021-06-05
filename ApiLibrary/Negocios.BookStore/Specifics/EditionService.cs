using Ado.Library;
using Models.Ado.Library;
using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using Nucleo.DBAccess.Ado;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Specifics
{
    public class EditionService : ServiceMapperBase<EditionDto, Edition>, IEditionService
    {
        public EditionService(IEditionRepository repository) : base(repository)
        {
        }

        public IEnumerable<EditionDto> SearchByName(string text)
        {
            return Map(_repository.Get(w=> w.EditionName.Contains(text)));
        }

        public IEnumerable<EditionDto> SearchByName(string text, int pag, int element)
        {
            return Map(_repository.Get(w => w.EditionName.Contains(text)).Skip((pag-1)*element).Take(element));
        }
    }
}
