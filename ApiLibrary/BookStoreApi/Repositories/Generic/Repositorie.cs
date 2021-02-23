using BookStoreApi.Models;
using BookStoreApi.Models.Library;
using LibraryApiRest.Enums;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryApiRest.Repositories.Concrect
{
    public class Repositorie<TEntity> : IRepositorie<TEntity> 
        where TEntity : class,new()
    {
       public BookStoreEntities Context;

        public DbSet<TEntity> dbSet;
        public string name;
        public string Identificator;
        public string query;
        public Repositorie(string identificator)
        {
            Context = new BookStoreEntities();
            dbSet = Context.Set<TEntity>();
            name = typeof(TEntity).Name;
            Identificator = identificator;
            
        }

        public dynamic Delete(List<string> ids)
        {
            string message = "";
            foreach (string id  in ids)
            {

                query = string.Format("Select * from {0} where {1}={2}",name,Identificator,id);
                TEntity search = dbSet.SqlQuery(query).SingleOrDefault();
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

        public dynamic Get(List<string> ids)
        {
            string message = "";
            List<TEntity> entities = new List<TEntity>();
            foreach (string id in ids)
            {
                query = string.Format("Select * from {0} where {1}={2}", name, Identificator, id);
                TEntity search = dbSet.SqlQuery(query).SingleOrDefault();
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

        public dynamic Get(int elements, int page)
        {
            int skip = page == 1 ? 0 : elements*page; 
            List<TEntity> list = dbSet.Skip(skip).Take(elements).ToList();
            return list;
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