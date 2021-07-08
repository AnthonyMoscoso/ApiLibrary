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
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class RolService : ServiceMapperBase<RolDto, Rol>, IRolService
    {
        public RolService(IRolRepository repository) : base(repository)
        {
        }

        public IEnumerable<RolDto> SearchByName(string text)
        {
            IEnumerable<Rol> result = _repository.Get(w => w.RolName.Contains(text));
            return mapper.Map<IEnumerable<RolDto>>(result);
        }

        public IEnumerable<RolDto> SearchByName(string text, int pag, int element)
        {
            IEnumerable<Rol> result = _repository.Get(w => w.RolName.Contains(text)).Skip((pag - 1) * element).Take(element);
            return mapper.Map<IEnumerable<RolDto>>(result);
        }
    }
}
