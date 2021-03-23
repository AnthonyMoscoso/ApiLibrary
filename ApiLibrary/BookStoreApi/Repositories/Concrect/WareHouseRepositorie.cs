using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.WareHouses;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.WareHouses
{
    public class WareHouseRepositorie : Repositorie<WareHouse>, IWareHouseRepositorie
    {
 
        public WareHouseRepositorie(string identificator="IdWareHouse") : base(identificator)
        {
           
        }

        public List<WareHouse> GetByCountry(string country)
        {
            return dbSet.Where(w => w.Direction.IdDirection.Equals(country)).ToList();
        }

        public List<WareHouse> GetByCountry(string country, int pag, int element)
        {
            return dbSet.Where(w => w.Direction.IdDirection.Equals(country)).Skip((pag - 1) * element).Take(element).ToList();
        }

        public WareHouse GetByEmployee(string idEmployee)
        {
            return dbSet.Where(w => w.Employee.Any(e => e.IdEmployee.Equals(idEmployee))).SingleOrDefault();
        }

        public List<WareHouse> GetByPoblation(string poblation)
        {
            return dbSet.Where(w => w.Direction.Poblation.Equals(poblation)).ToList();
        }

        public List<WareHouse> GetByPoblation(string poblation, int pag, int element)
        {
            return dbSet.Where(w => w.Direction.Poblation.Equals(poblation)).Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<WareHouse> GetByPostalCode(string postalCode)
        {
            return dbSet.Where(w => w.Direction.PostalCode.Equals(postalCode)).ToList();
        }

        public List<WareHouse> GetByPostalCode(string postalCode, int pag, int element)
        {
            return dbSet.Where(w => w.Direction.PostalCode.Equals(postalCode)).Skip((pag - 1) * element).Take(element).ToList();
        }
       
    }
}