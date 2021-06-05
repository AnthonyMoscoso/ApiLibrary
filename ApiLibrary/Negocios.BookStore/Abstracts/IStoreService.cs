using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IStoreService : IServices<StoreDto>
    {
        IEnumerable<StoreDto> GetByPostalCode(string postalCode);
        IEnumerable<StoreDto> GetByPostalCode(string postalCode, int pag, int element);
        IEnumerable<StoreDto> GetByCountry(string country);
        IEnumerable<StoreDto> GetByCountry(string country, int pag, int element);
        IEnumerable<StoreDto> GetByPoblation(string poblation);
        IEnumerable<StoreDto> GetByPoblation(string poblation, int pag, int element);
        StoreDto GetByEmployee(string idEmployee);
    }
}
