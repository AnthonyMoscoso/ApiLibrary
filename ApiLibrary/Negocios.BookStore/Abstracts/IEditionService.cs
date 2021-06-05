using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IEditionService : IServices<EditionDto>
    {
        IEnumerable<EditionDto> SearchByName(string text);

        IEnumerable<EditionDto> SearchByName(string text, int pag, int element);
    }
}
