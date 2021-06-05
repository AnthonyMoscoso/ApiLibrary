using Models.Ado.Library;
using Models.Dtos;
using Nucleo.DBAccess.Ado;
using System.Collections.Generic;

namespace Ado.Library
{
    public interface IWareHouseRepository : IRepository<WareHouse>
    {
        IEnumerable<WareHouse> GetByPostalCode(string postalCode);
        IEnumerable<WareHouse> GetByPostalCode(string postalCode, int pag, int element);
        IEnumerable<WareHouse> GetByCountry(string country);
        IEnumerable<WareHouse> GetByCountry(string country, int pag, int element);
        IEnumerable<WareHouse> GetByPoblation(string poblation);
        IEnumerable<WareHouse> GetByPoblation(string poblation, int pag, int element);
        WareHouse GetByEmployee(string idEmployee);
    }
}
