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
    public class GenderService : ServiceMapperBase<GenderDto, Gender>, IGenderService
    {
        readonly new IGenderRepository _repository;
        public GenderService(IGenderRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<GenderDto> SearchByName(string text)
        {
            IEnumerable<Gender> result = _repository.SearchByName(text);
            return mapper.Map<IEnumerable<GenderDto>>(result);
        }

        public IEnumerable<GenderDto> SearchByName(string text, int pag, int element)
        {
            IEnumerable<Gender> result = _repository.SearchByName(text,pag,element);
            return mapper.Map<IEnumerable<GenderDto>>(result);

        }
    }
}
