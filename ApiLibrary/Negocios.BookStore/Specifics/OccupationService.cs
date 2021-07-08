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
    public class OccupationService : ServiceMapperBase<OccupationDto, Occupation>, IOccupationService
    {
        readonly new IOccupationRepository _repository;
        public OccupationService(IOccupationRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<OccupationDto> SearchByName(string text)
        {
            IEnumerable<Occupation> result = _repository.SearchByName(text);
            return mapper.Map<IEnumerable<OccupationDto>>(result);
        }

        public IEnumerable<OccupationDto> SearchByName(string text, int pag, int element)
        {
            IEnumerable<Occupation> result = _repository.SearchByName(text,pag,element);
            return mapper.Map<IEnumerable<OccupationDto>>(result);
        }
    }
}
