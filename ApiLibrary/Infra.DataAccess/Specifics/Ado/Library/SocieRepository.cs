using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using Models.Ado.Library;
using System.Linq;
using Core.DBAccess.Ado;
using Models.Dtos;
using Ado.Library;


namespace Ado.Library.Specifics
{
    public class SocieRepository : AdoRepository<Socie>, ISocieRepository
    {
        readonly new IPersonRepository repositorie;
        public SocieRepository(BookStoreEntities context, string identificator="IdSocie") : base(context,identificator)
        {
            
        }



        /*  public dynamic DeleteDesactivates()
          {

              IEnumerable<Socie> search = dbSet.Where(w => (w.DesactivateDate.Value.Day - DateTime.Now.Day) >= 15).ToList();
              ICollection<string> ids = new List<string>();
              foreach (Socie entity in search)
              {
                  ids.Add(entity.IdPerson);
              }
              Delete(ids);
              personRepositorie .Delete(ids);       
              return ids;
          }*/

        public void DesactivateAccount(string idSocie)
        {
            dbSet.Where(w => w.IdPerson.Equals(idSocie)).SingleOrDefault().DesactivateDate = DateTime.Now;
            Save();
        }

        public IEnumerable<Socie> GetByDate(DateTime date)
        {
            IEnumerable<Socie> list = dbSet.Where(w => w.RegisterDate.Date.Equals(date.Date));
            return list;
        }

        public IEnumerable<Socie> GetByDate(DateTime start, DateTime end)
        {
            IEnumerable<Socie> list = dbSet.Where(w => w.RegisterDate.Date >= start.Date && w.RegisterDate.Date <= end.Date);
            return list;
        }

        public Socie GetByDni(string dni)
        {
            Socie entity = dbSet.Where(w => w.Person.Dni.Equals(dni)).FirstOrDefault();
            return (entity);
        }

        public IEnumerable<Socie> GetDesactivates()
        {
            IEnumerable<Socie> list = dbSet.Where(w => w.DesactivateDate.HasValue);
            return list;
        }

        /*public void ReactivateAccount(string idSocie)
        {
            Socie search = dbSet.Where(w => w.IdPerson.Equals(idSocie)).SingleOrDefault();
            search.DesactivateDate= null;
            IEnumerable<Socie> list = new List<Socie>()
            {
                search
            };
            Update(list);
        }
        */
        public IEnumerable<Socie> SearchByName(string text)
        {
            IEnumerable<Socie> list = dbSet.Where(e => (e.Person.NamePerson).Contains(name));
            return list;
        }

        public IEnumerable<Socie> SearchByName(string text, int pag, int element)
        {
            IEnumerable<Socie> list = dbSet.Where(e => (e.Person.NamePerson).Contains(name))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return list;
        }



    }
}