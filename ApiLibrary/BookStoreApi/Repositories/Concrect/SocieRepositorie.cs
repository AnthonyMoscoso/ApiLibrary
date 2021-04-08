using BookStoreApi.Models.Library;
using BookStoreApi.Models.Request;
using BookStoreApi.Repositories.Abstract.Persons;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect.Persons
{
    public class SocieRepositorie : Repository<Socie>, ISocieRepositorie
    {
        readonly PersonRepositorie personRepositorie ;
        public SocieRepositorie(string identificator="IdSocie") : base(identificator)
        {
            personRepositorie  = new PersonRepositorie();
        }

        public dynamic Insert(List<SocieDto> dtos)
        {
            try
            {
                List<Socie> list = mapper.Map<List<Socie>>(dtos);
                dbSet.AddRange(list);
            }
            catch
            {

            }
            return Save();
        }
        public  new dynamic Delete(List<string>ids)
        {
            string message = "";
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search != null)
                {

                    Person person = Context.Person.Find(id);
                    Context.Person.Remove(person);
                    dbSet.Remove(search);
                    message += Save();
                }
                else
                {
                    message += string.Format("any employee was found with this id {0}", id); ;
                }
            }
            return message;
        }
        public dynamic Update(List<SocieDto> list)
        {
            string message = "";
            try
            {
                List<Person> people = mapper.Map<List<Person>>(list);
                message += personRepositorie.Update(people);
                foreach (SocieDto dto in list)
                {
                    Socie entity = mapper.Map<Socie>(dto);
                    dbSet.Attach(entity);
                    Context.Entry(entity).State = EntityState.Modified;
                    message += Save();


                }

            }
            catch (SqlException)
            {

            }
            return message;
        }
        public dynamic DeleteDesactivates()
        {

            var list = dbSet.Where(w => (w.DesactivateDate.Value.Day - DateTime.Now.Day) >= 15).ToList();
            List<string> ids = new List<string>();
            foreach (Socie entity in list)
            {
                ids.Add(entity.IdPerson);
            }
            Delete(ids);
            personRepositorie .Delete(ids);       
            return ids;
        }

        public void DesactivateAccount(string idSocie)
        {
            dbSet.Where(w => w.IdPerson.Equals(idSocie)).SingleOrDefault().DesactivateDate = DateTime.Now;
            Save();
        }

        public List<SocieDto> GetByDate(DateTime date)
        {
            var list = mapper.Map<List<SocieDto>>(dbSet.Where(w => w.RegisterDate.Date.Equals(date.Date)).ToList());
            return list;
        }

        public List<SocieDto> GetByDate(DateTime start, DateTime end)
        {
            var list = dbSet.Where(w => w.RegisterDate.Date >= start.Date && w.RegisterDate.Date <= end.Date).ToList();
            return mapper.Map<List<SocieDto>>(list);
        }

        public SocieDto GetByDni(string dni)
        {
            var entity = dbSet.Where(w => w.Person.Dni.Equals(dni)).FirstOrDefault();
            return mapper.Map<SocieDto>(entity);
        }

        public List<SocieDto> GetDesactivates()
        {
            var list = dbSet.Where(w => w.DesactivateDate.HasValue).ToList();
            return mapper.Map<List<SocieDto>>(list);
        }

        public void ReactivateAccount(string idSocie)
        {
            Socie search = dbSet.Where(w => w.IdPerson.Equals(idSocie)).SingleOrDefault();
            search.DesactivateDate= null;
            List<Socie> list = new List<Socie>()
            {
                search
            };
            Update(list);
        }

        public List<SocieDto> SearchByName(string text)
        {
            var list = dbSet.Where(e => (e.Person.NamePerson ).Contains(name)).ToList();
            return mapper.Map<List<SocieDto>>(list);
        }

        public List<SocieDto> SearchByName(string text, int pag, int element)
        {
            var list = dbSet.Where(e => (e.Person.NamePerson ).Contains(name))
                .OrderBy(w=> w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<SocieDto>>(list);
        }

        public new List<SocieDto> Get()
        {
            var list = dbSet.ToList();
            return mapper.Map<List<SocieDto>>(list);
        }

        public new List<SocieDto> Get(int pag,int element)
        {
            var list = dbSet.OrderBy(w=> w.CreateDate).Skip((pag-1)*element).Take(element).ToList();
            return mapper.Map<List<SocieDto>>(list);
        }

        public new SocieDto Get(string id) {
            var entity = dbSet.Find(id);
            return mapper.Map<SocieDto>(entity);
        }
    }
}