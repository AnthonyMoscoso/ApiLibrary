using Models.Ado.Library;
using System.Collections.Generic;
using Core.DBAccess.Ado;

namespace Ado.Library
{
    public interface IStoreRepository : IRepository<Store>
    {
        IEnumerable<Store> GetByPostalCode(string postalCode);
        IEnumerable<Store> GetByPostalCode(string postalCode, int pag, int element);
        IEnumerable<Store> GetByCountry(string country);
        IEnumerable<Store> GetByCountry(string country, int pag, int element);
        IEnumerable<Store> GetByPoblation(string poblation);
        IEnumerable<Store> GetByPoblation(string poblation, int pag, int element);
        Store GetByEmployee(string idEmployee);
    }
}
