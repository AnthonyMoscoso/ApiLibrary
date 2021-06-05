using Models.Ado.Library;
using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IProviderService : IServices<ProviderDto>
    {
        IEnumerable<Providers> SearchByName(string text);
        IEnumerable<Providers> SearchByName(string text, int pag, int element);
    }
}
