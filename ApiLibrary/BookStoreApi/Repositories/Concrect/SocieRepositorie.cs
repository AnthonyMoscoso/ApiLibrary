using BookStoreApi.Models.Library;
using BookStoreApi.Repositories.Abstract.Persons;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Persons
{
    public class SocieRepositorie : Repositorie<Socie>, ISocieRepositorie
    {
        readonly PersonRepositorie _PersonRepositorie;
        public SocieRepositorie(string identificator="IdSocie") : base(identificator)
        {
            _PersonRepositorie = new PersonRepositorie();
        }

        public dynamic DeleteDesactivates()
        {

            var list = dbSet.Where(w => (w.DesactivateDate.Value.Day - DateTime.Now.Day) >= 15).ToList();
            List<string> ids = new List<string>();
            foreach (Socie entity in list)
            {
                ids.Add(entity.IdSocie);
            }
            Delete(ids);
            _PersonRepositorie.Delete(ids);       
            return ids;
        }

        public void DesactivateAccount(string idSocie)
        {
            dbSet.Where(w => w.IdSocie.Equals(idSocie)).SingleOrDefault().DesactivateDate = DateTime.Now;
        }

        public List<Socie> GetByDate(DateTime date)
        {
            return dbSet.Where(w => w.RegisterDate.Date.Equals(date.Date)).ToList();
        }

        public List<Socie> GetByDate(DateTime start, DateTime end)
        {
            return dbSet.Where(w=> w.RegisterDate.Date>=start.Date && w.RegisterDate.Date<=end.Date).ToList();
        }

        public List<Socie> GetByDni(string dni)
        {
            return dbSet.Where(w=> w.Person.Dni.Equals(dni)).ToList();
        }

        public List<Socie> GetDesactivates()
        {
            return dbSet.Where(w => w.DesactivateDate.HasValue).ToList();
        }

        public void ReactivateAccount(string idSocie)
        {
            Socie search = dbSet.Where(w => w.IdSocie.Equals(idSocie)).SingleOrDefault();
            search.DesactivateDate= null;
            List<Socie> list = new List<Socie>()
            {
                search
            };
            Update(list);
        }

        public List<Socie> SearchByName(string text)
        {
            return dbSet.Where(e => (e.Person.NamePerson ).Contains(name)).ToList();
        }

        public List<Socie> SearchByName(string text, int pag, int element)
        {
            return dbSet.Where(e => (e.Person.NamePerson ).Contains(name))
                .Skip((pag - 1) * element).Take(element).ToList();
        }
    }
}