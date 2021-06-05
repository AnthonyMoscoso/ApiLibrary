using Models.Dtos;
using Nucleo.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Abstracts
{
    public interface IWareHouseService : IServices<WareHouseDto> 
    {
        IEnumerable<WareHouseDto> GetByPostalCode(string postalCode);
        IEnumerable<WareHouseDto> GetByPostalCode(string postalCode, int pag, int element);
        IEnumerable<WareHouseDto> GetByCountry(string country);
        IEnumerable<WareHouseDto> GetByCountry(string country, int pag, int element);
        IEnumerable<WareHouseDto> GetByPoblation(string poblation);
        IEnumerable<WareHouseDto> GetByPoblation(string poblation, int pag, int element);
        WareHouseDto GetByEmployee(string idEmployee);
    }
}
