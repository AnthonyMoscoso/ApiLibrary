using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IAutorService : IServices<AutorDto>
    {
        IEnumerable<AutorDto> SearchByName(string text);
        IEnumerable<AutorDto> SearchByName(string text, int pag, int element);
        AutorDto GetByName(string name);
        bool ExistName(string name);
    }
}
