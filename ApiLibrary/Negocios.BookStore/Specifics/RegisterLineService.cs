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
    public class RegisterLineService : ServiceMapperBase<RegisterLineDto, RegisterLine>, IRegisterLineService
    {
        public RegisterLineService(IRegisterLineRepository repository) : base(repository)
        {
        }

        public IEnumerable<ReceptionLineDto> GetByReception(string idReception)
        {
            throw new NotImplementedException();
        }
    }
}
