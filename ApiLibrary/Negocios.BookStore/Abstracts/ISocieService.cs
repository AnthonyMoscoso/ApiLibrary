using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface ISocieService : IServices <SocieDto>
    {
        SocieDto GetByDni(string dni);
        IEnumerable<SocieDto> GetByDate(DateTime date);
        IEnumerable<SocieDto> GetByDate(DateTime start, DateTime end);
        IEnumerable<SocieDto> GetDesactivates();
        IEnumerable<SocieDto> SearchByName(string text);
        IEnumerable<SocieDto> SearchByName(string text, int pag, int element);
    }
}
