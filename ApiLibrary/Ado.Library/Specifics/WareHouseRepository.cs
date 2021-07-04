using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using System.Linq;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;

namespace Ado.Library.Specifics
{ 
    public class WareHouseRepository : AdoRepository<WareHouse>, IWareHouseRepository
    {
      
        public WareHouseRepository(BookStoreEntities context, string identificator = "IdWareHouse") : base(context, identificator)
        {

        }


        public IEnumerable<WareHouse> GetByCountry(string country)
        {
            var list = dbSet.Where(w => w.Direction.Country.Equals(country));
            return list;
        }

        public IEnumerable<WareHouse> GetByCountry(string country, int pag, int element)
        {
            var list = dbSet.Where(w => w.Direction.Country.Equals(country))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return list;
        }

        public WareHouse GetByEmployee(string idEmployee)
        {
            var search = dbSet.Where(w => w.Employee.Any(e => e.IdPerson.Equals(idEmployee))).SingleOrDefault();
            return search;
        }

        public IEnumerable<WareHouse> GetByPoblation(string poblation)
        {
            var list = dbSet.Where(w => w.Direction.Poblation.Equals(poblation));
            return list;
        }

        public IEnumerable<WareHouse> GetByPoblation(string poblation, int pag, int element)
        {
            var list = dbSet.Where(w => w.Direction.Poblation.Equals(poblation))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return list;
        }

        public IEnumerable<WareHouse> GetByPostalCode(string postalCode)
        {
            var list = dbSet.Where(w => w.Direction.PostalCode.Equals(postalCode));
            return list;
        }

        public IEnumerable<WareHouse> GetByPostalCode(string postalCode, int pag, int element)
        {
            var list = dbSet.Where(w => w.Direction.PostalCode.Equals(postalCode))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                ;
            return list;
        }

        public new dynamic Delete(IEnumerable<string> ids)
        {
            string message = string.Empty;
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search != null)
                {
                    if (search.Direction != null)
                    {
                        _Context.Set<Direction>().Remove(search.Direction);
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