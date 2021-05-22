using Models.Ado.Library;
using Models.Dtos;
using Nucleo.DBAccess.Ado;
using System.Collections.Generic;

namespace Ado.Library
{
    public interface IWareHouseRepositorie : IRepository<WareHouse>
    {
        List<WareHouseDto> GetByPostalCode(string postalCode);
        List<WareHouseDto> GetByPostalCode(string postalCode, int pag, int element);
        List<WareHouseDto> GetByCountry(string country);
        List<WareHouseDto> GetByCountry(string country, int pag, int element);
        List<WareHouseDto> GetByPoblation(string poblation);
        List<WareHouseDto> GetByPoblation(string poblation, int pag, int element);
        WareHouseDto GetByEmployee(string idEmployee);
    }
}
