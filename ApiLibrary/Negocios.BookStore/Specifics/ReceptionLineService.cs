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
    public class ReceptionLineService : ServiceMapperBase<ReceptionLineDto, ReceptionLine>, IReceptionLineService
    {
        readonly new  IReceptionLineRepository _repository;
        public ReceptionLineService(IReceptionLineRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<ReceptionLineDto> GetByReception(string idReception)
        {
            IEnumerable<ReceptionLine> result = _repository.GetByReception(idReception);
            return mapper.Map<IEnumerable<ReceptionLineDto>>(result);
        }
    }
}
