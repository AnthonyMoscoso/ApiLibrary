using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.WareHouses
{
    interface IWareHouseRepositorie : IRepositorie<WareHouse>
    {
        List<WareHouse> GetByPostalCode(string postalCode);
        List<WareHouse> GetByPostalCode(string postalCode, int pag, int element);
        List<WareHouse> GetByCountry(string country);
        List<WareHouse> GetByCountry(string country, int pag, int element);
        List<WareHouse> GetByPoblation(string poblation);
        List<WareHouse> GetByPoblation(string poblation, int pag, int element);
        WareHouse GetByEmployee(string idEmployee);
    }
}
