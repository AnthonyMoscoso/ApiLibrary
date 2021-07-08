using Core.DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DBAccess.Ado
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class AdoRepository<TEntity> : IRepository<TEntity> , ISqlQueryRepository
        where TEntity : class, new()
    {

        // public DbContext _Context;
        public DbContext _Context { get; set; }
        public DbSet<TEntity> dbSet;
        public string name;
        public string Identificator;
        public string query;

        /// <summary>
        /// Construtor of our generic repository
        /// </summary>
        /// <param name="identificator">name of primary key column of our table</param>
        public AdoRepository(DbContext context,string identificator)
        {
            _Context = context;
            dbSet = _Context.Set<TEntity>();
            name = typeof(TEntity).Name;
            Identificator = identificator;         
           
        }

        /// <summary>
        /// Method to delete a list of entitys from our database about a list of id
        /// </summary>
        /// <param name="ids">list of ids</param>
        /// <returns>List of message with the result of our method </returns>
        public dynamic Delete(IEnumerable<string> ids)
        {
            foreach (string id in ids)
            {

                TEntity search = dbSet.Find(id);
                if (search != null)
                {
                    dbSet.Remove(search);
                    Save();
                }
            }
            return null;
          
        }

        /// <summary>
        /// Method  to get all entitys from our database
        /// </summary>
        /// <returns>list of entitys from the database</returns>
        public IEnumerable<TEntity> Get()
        {
            IEnumerable<TEntity> list = dbSet;
            return list;
        }

     
        /// <summary>
        /// Method to get our entity paginates from our database
        /// </summary>
        /// <param name="elements">num of element to take</param>
        /// <param name="pag">num of pag  </param>
        /// <returns>the list paginate</returns>
        public IEnumerable<TEntity> Get(int elements, int pag)
        {
            IEnumerable<TEntity> list = dbSet.OrderBy(x => Identificator).Skip((pag - 1) * elements).Take(elements).ToList();
            return list;
        }

        /// <summary>
        /// Method to get a specific entity for the id
        /// </summary>
        /// <param name="id">id to find our entity</param>
        /// <returns>entity by id or null</returns>
        public TEntity GetSingle(string id)
        {
            TEntity search = dbSet.Find(id);

            return search;

        }


        public dynamic Insert(IEnumerable<TEntity> list)
        {

            dbSet.AddRange(list);
            return Save();

        }


        public dynamic Insert(TEntity entity)
        {
            dbSet.Add(entity);       
            Save();
            return entity;
        }

        public dynamic Save()
        {
            _Context.SaveChanges();
            return null;
        }

       
        public dynamic Update(IEnumerable<TEntity> list)
        {
            foreach (TEntity entity in list)
            {
                dbSet.Attach(entity);
                _Context.Entry(entity).State = EntityState.Modified;
                Save();
            }
            return Save();

        }


        public dynamic Update(TEntity entity)
        {

            dbSet.Attach(entity);
            _Context.Entry(entity).State = EntityState.Modified;
            return  Save();
        }


        public int Count()
        {
            int count = dbSet.Count();
            return count;
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

        public dynamic Delete(string id)
        {
            TEntity search = dbSet.Find(id);
            if (search != null)
            {
                dbSet.Remove(search);
            }
            return Save();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }
        public void ExecuteQuery(string query)
        {
            _Context.Database.ExecuteSqlCommand(query);
        }

        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Count(predicate);
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate).SingleOrDefault();
        }

        public IEnumerable<TEntity> GetOrderBy(string order)
        {
            return dbSet.OrderBy(w=> order);
        }

        public IEnumerable<TEntity> GetOrderBy(int elements, int pag, string order)
        {
            return dbSet.OrderBy(w => order).Skip((pag - 1) * elements).Take(elements);
        }

        public IEnumerable<TEntity> GetOrderBy(Expression<Func<TEntity, bool>> predicate, string order)
        {
            return dbSet.Where(predicate).OrderBy(w => order);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, int pag, int element, string order)
        {
            return dbSet.Where(predicate).OrderBy(w=> order).Skip((pag-1)*element).Take(element);
        }
    }
}