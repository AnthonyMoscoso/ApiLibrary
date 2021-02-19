using BookStoreApi.Models;
using BookStoreApi.Models.Library;
using LibraryApiRest.Enums;
using LibraryApiRest.Models;
using LibraryApiRest.Models.Abstract;
using LibraryApiRest.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryApiRest.Repositories.Concrect
{
    public class Repositorie<TEntity> : IRepositorie<TEntity> where TEntity : class, IEntidad
    {
       public BookStoreEntities Context;

        public DbSet<TEntity> dbSet;
        public string name;
        public Repositorie()
        {
            Context = new BookStoreEntities();
            dbSet = Context.Set<TEntity>();
            name = typeof(TEntity).Name;
        }

        public dynamic Delete(List<string> ids)
        {
            string message = "";
            foreach (string id  in ids)
            {
                TEntity search = dbSet.Where(w => w.Id == id).SingleOrDefault();
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
                TEntity search = dbSet.Where(w => w.Id == id).SingleOrDefault();
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
            foreach (TEntity t in list)
            {
                TEntity search = dbSet.Where(w=> w.Id==t.Id).SingleOrDefault();
                if (search!=null)
                {
                    search = t;
                    Context.Entry(search).State = EntityState.Modified;
                    return Save();
                }

            }
            return null;
        }
    }
}