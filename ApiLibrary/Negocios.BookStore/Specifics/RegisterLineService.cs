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
    public class RegisterLineService : ServiceMapperBase<RegisterLineDto, RegisterLine>, IRegisterLineService
    {
        public RegisterLineService(IRegisterLineRepository repository) : base(repository)
        {
        }

        public IEnumerable<RegisterLineDto> GetByRegister(string idRegister)
        {
            IEnumerable<RegisterLine> result = _repository.Get(w=> w.IdRegister.Equals(idRegister));
            return mapper.Map<IEnumerable<RegisterLineDto>>(result);
        }
    }
}
