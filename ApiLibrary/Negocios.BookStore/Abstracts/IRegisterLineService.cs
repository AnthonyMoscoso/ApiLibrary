using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IRegisterLineService : IServices<RegisterLineDto>
    {
        IEnumerable<ReceptionLineDto> GetByReception(string idReception);
    }
}
