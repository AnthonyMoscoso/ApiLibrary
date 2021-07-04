using Models.Dtos;
using Core.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BookStoreServices.Abstracts
{
    public interface ITaxesService : IServices<TaxesDto>
    {
        IEnumerable<TaxesDto> SearchByName(string text);
        IEnumerable<TaxesDto> SearchByName(string text, int pag, int element);
        IEnumerable<TaxesDto> GetByType(int type);
        IEnumerable<TaxesDto> GetByType(int type, int pag, int element);
    }
}
