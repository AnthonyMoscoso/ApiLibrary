using Models.Dtos;
using System.Collections.Generic;
using Models.Ado.Library;
using System.Linq;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        public StoreRepository(BookStoreEntities context,string identificator="IdStore") : base(context,identificator)
        {
        }


        public IEnumerable<Store> GetByCountry(string country)
        {
            return dbSet.Where(w => w.Direction.IdDirection.Equals(country));
        }

        public IEnumerable<Store> GetByCountry(string country, int pag, int element)
        {
            return dbSet.Where(w => w.Direction.IdDirection.Equals(country))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
        }

        public Store GetByEmployee(string idEmployee)
        {
            return dbSet.Where(w => w.Employee.Any(e => e.IdPerson.Equals(idEmployee))).SingleOrDefault();
        }

        public IEnumerable<Store> GetByPoblation(string poblation)
        {
            return dbSet.Where(w => w.Direction.Poblation.Equals(poblation));
        }

        public IEnumerable<Store> GetByPoblation(string poblation, int pag, int element)
        {
            return dbSet.Where(w => w.Direction.Poblation.Equals(poblation)).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
        }

        public IEnumerable<Store> GetByPostalCode(string postalCode)
        {
            return dbSet.Where(w => w.Direction.PostalCode.Equals(postalCode));
        }

        public IEnumerable<Store> GetByPostalCode(string postalCode, int pag, int element)
        {
            return dbSet.Where(w => w.Direction.PostalCode.Equals(postalCode)).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
        }

        /*   public new dynamic Delete(IEnumerable<string> ids)
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
           }*/
    }
}