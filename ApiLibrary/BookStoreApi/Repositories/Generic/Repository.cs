using AutoMapper;
using BookStoreApi.Models;
using BookStoreApi.Models.Library;
using LibraryApiRest.Enums;
using LibraryApiRest.Repositories.Abstract;
using Mappers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryApiRest.Repositories.Concrect
{
    public class Repository<TEntity> : IRepository<TEntity> 
        where TEntity : class,new()
    {
       public BookStoreEntities Context;

        public DbSet<TEntity> dbSet;
        public string name;
        public string Identificator;
        public string query;
        public IMapper mapper;
        public Repository(string identificator)
        {
            Context = new BookStoreEntities();
            dbSet = Context.Set<TEntity>();
            name = typeof(TEntity).Name;
            Identificator = identificator;
            mapper = AutoMapperConfig.MapperConfiguration.CreateMapper();
        }

        public dynamic Delete(List<string> ids)
        {
            string message = "";
            foreach (string id  in ids)
            {

                TEntity search = dbSet.Find(id);
                if (search!=null)
                {
                    dbSet.Remove(search);
                    message +=  Save();
                }
                else
                {
                    message += "Entity whith Id =" + id +" not was found";
                }
            }

            return message;
        }
        public dynamic Get()
        {
            return dbSet.ToList();
        }

        public dynamic GetList(string ids)
        {
            List<string> list = ids.Split(',').ToList();
            string message = "";
            List<TEntity> entities = new List<TEntity>();
            foreach (string id in list)
            {

                TEntity search = dbSet.Find(id);
                if (search != null)
                {
                    entities.Add(search);
                }
                else
                {
                    message += "Entity whith Id =" + id + " not was found";
                }
            }

            return entities;
        }

        public dynamic Get(int elements, int pag)
        {
   
      
            List<TEntity> list = dbSet.OrderBy(x =>Identificator).Skip((pag-1)*elements).Take(elements).ToList();
            return list;
        }

        public dynamic Get(string id)
        {
            var search = dbSet.Find(id);
            return search != null ? (dynamic)search : (dynamic)"Not was found";

        }

        public dynamic Insert(List<TEntity> list)
        {
            try
            {
                dbSet.AddRange(list);
                return Save();
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public dynamic Insert(TEntity entity)
        {
            try
            {
                dbSet.Add(entity);
                return Save();
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public dynamic Save()
        {
            try
            {
                Context.SaveChanges();
                return "Changes saves ";
            }
            catch (DbEntityValidationException e)
            {
                return e.Message;
            }
            catch (SqlException)
            {
                return "Error";
            }
        }

        public dynamic Update(List<TEntity> list)
        {
            foreach (TEntity entity in list)
            {
                dbSet.Attach(entity);
                Context.Entry(entity).State = EntityState.Modified;
            }
 
            return Save(); ;
        }
    }
}