using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.WareHouses;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.WareHouses
{
    public class WareHouseRepositorie : Repository<WareHouse>, IWareHouseRepositorie
    {
 
        public WareHouseRepositorie(string identificator="IdWareHouse") : base(identificator)
        {
           
        }

        public  new List<WareHouseDto> Get()
        {
            var list = dbSet.ToList();
            return mapper.Map<List<WareHouseDto>>(list);
        }

        public List<WareHouseDto> GetByCountry(string country)
        {
            var list = dbSet.Where(w => w.Direction.Country.Equals(country)).ToList();
            return mapper.Map<List<WareHouseDto>>(list);
        }

        public List<WareHouseDto> GetByCountry(string country, int pag, int element)
        {
            var list = dbSet.Where(w => w.Direction.Country.Equals(country))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<WareHouseDto>>(list);
        }

        public WareHouseDto GetByEmployee(string idEmployee)
        {
            var list = dbSet.Where(w => w.Employee.Any(e => e.IdPerson.Equals(idEmployee))).SingleOrDefault();
            return mapper.Map<WareHouseDto>(list);
        }

        public List<WareHouseDto> GetByPoblation(string poblation)
        {
            var list = dbSet.Where(w => w.Direction.Poblation.Equals(poblation)).ToList();
            return mapper.Map<List<WareHouseDto>>(list);
        }

        public List<WareHouseDto> GetByPoblation(string poblation, int pag, int element)
        {
            var list = dbSet.Where(w => w.Direction.Poblation.Equals(poblation))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<WareHouseDto>>(list);
        }

        public List<WareHouseDto> GetByPostalCode(string postalCode)
        {
            var list = dbSet.Where(w => w.Direction.PostalCode.Equals(postalCode)).ToList();
            return mapper.Map<List<WareHouseDto>>(list);
        }

        public List<WareHouseDto> GetByPostalCode(string postalCode, int pag, int element)
        {
            var list = dbSet.Where(w => w.Direction.PostalCode.Equals(postalCode))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<WareHouseDto>>(list);
        }
        public new dynamic Delete(List<string> ids)
        {
            string message = "";
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search != null)
                {
                    if (search.Direction != null)
                    {
                        Context.Direction.Remove(search.Direction);
                    }
                    dbSet.Remove(search);
                }
                else
                {
                    message += "any store wasn't found with this id = " + id;
                }

            }
            return Save();
        }
    }
}