using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.Stores
{
    interface IStoreRepository : IRepository<Store>
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
