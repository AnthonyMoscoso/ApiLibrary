using BookStoreApi.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Stores;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Stores
{
    public class StoreRepositorie : Repository<Store,StoreDto>, IStoreRepositorie
    {
        public StoreRepositorie(string identificator = "IdStore") : base(identificator)
        {
        }

        public new List<StoreDto> Get(){
            var list = dbSet.ToList();
            return mapper.Map<List<StoreDto>>(list);
        }
        public List<Store> GetByCountry(string country)
        {
            return dbSet.Where(w => w.Direction.IdDirection.Equals(country)).ToList();
        }

        public List<Store> GetByCountry(string country, int pag, int element)
        {
            return dbSet.Where(w => w.Direction.IdDirection.Equals(country))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public Store GetByEmployee(string idEmployee)
        {
            return dbSet.Where(w => w.Employee.Any(e => e.IdPerson.Equals(idEmployee))).SingleOrDefault();
        }

        public List<Store> GetByPoblation(string poblation)
        {
            return dbSet.Where(w => w.Direction.Poblation.Equals(poblation)).ToList();
        }

        public List<Store> GetByPoblation(string poblation, int pag, int element)
        {
            return dbSet.Where(w => w.Direction.Poblation.Equals(poblation))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public List<Store> GetByPostalCode(string postalCode)
        {
            return dbSet.Where(w => w.Direction.PostalCode.Equals(postalCode)).ToList();
        }

        public List<Store> GetByPostalCode(string postalCode, int pag, int element)
        {
            return dbSet.Where(w => w.Direction.PostalCode.Equals(postalCode))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
        }

        public new dynamic Delete(List<string> ids)
        {
            string message = "";
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search!=null)
                {
                    if (search.Direction!=null)
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