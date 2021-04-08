using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApi.Repositories.Abstract.WareHouses
{
    interface IWareHouseRepositorie : IRepository<WareHouse>
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
