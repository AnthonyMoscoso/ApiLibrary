using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IEditorialService : IServices<EditorialDto>
    {
        IEnumerable<EditorialDto> SearchByName(string text);
        IEnumerable<EditorialDto> SearchByName(string text, int pag, int element);
    }
}
