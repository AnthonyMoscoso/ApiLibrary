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
using Ado.Library;
using Core.Logger.Abstracts;

namespace Business.BookStoreServices.Specifics
{
    public class ProviderService : ServiceMapperBase<ProviderDto, Providers>, IProviderService
    {
        readonly new IProviderRepository _repository;
        public ProviderService(IProviderRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<ProviderDto> SearchByName(string text)
        {
            IEnumerable<Providers> result = _repository.SearchByName(text);
            return mapper.Map<IEnumerable<ProviderDto>>(result);
        }

        public IEnumerable<ProviderDto> SearchByName(string text, int pag, int element)
        {
            IEnumerable<Providers> result = _repository.SearchByName(text,pag,element);
            return mapper.Map<IEnumerable<ProviderDto>>(result);
        }
    }
}
