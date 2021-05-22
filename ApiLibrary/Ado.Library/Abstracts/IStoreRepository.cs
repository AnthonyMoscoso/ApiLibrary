using Models.Ado.Library;
using System.Collections.Generic;
using Nucleo.DBAccess.Ado;

namespace Ado.Library
{
    public interface IStoreRepository : IRepository<Store>
    {
        List<Store> GetByPostalCode(string postalCode);
        List<Store> GetByPostalCode(string postalCode,int pag,int element);
        List<Store> GetByCountry(string country);
        List<Store> GetByCountry(string country,int pag,int element);
        List<Store> GetByPoblation(string poblation);
        List<Store> GetByPoblation(string poblation, int pag, int element);
        Store GetByEmployee(string idEmployee);
    }
}
