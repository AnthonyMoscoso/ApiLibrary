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
    public class PermitService : ServiceMapperBase<PermitDto, Permit>, IPermitService
    {
        readonly new IPermitRepository _repository;
        public PermitService(IPermitRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<PermitDto> SearchByName(string text)
        {
            IEnumerable<Permit> result = _repository.SearchByName(text);
            return mapper.Map<IEnumerable<PermitDto>>(result);
        }

        public IEnumerable<PermitDto> SearchByName(string text, int pag, int element)
        {
            IEnumerable<Permit> result = _repository.SearchByName(text);
            return mapper.Map<IEnumerable<PermitDto>>(result);
        }
    }
}
