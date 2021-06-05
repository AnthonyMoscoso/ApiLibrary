using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IGenderService : IServices<GenderDto>
    {
        IEnumerable<GenderDto> SearchByName(string text);
        IEnumerable<GenderDto> SearchByName(string text, int pag, int element);
    }
}
