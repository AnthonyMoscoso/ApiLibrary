using Models.Ado.Library;
using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface IProviderService : IServices<ProviderDto>
    {
        IEnumerable<ProviderDto> SearchByName(string text);
        IEnumerable<ProviderDto> SearchByName(string text, int pag, int element);
    }
}
