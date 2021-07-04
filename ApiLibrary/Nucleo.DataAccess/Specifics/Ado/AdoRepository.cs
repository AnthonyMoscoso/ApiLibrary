using Core.DataAccess.Abstracts;
using Core.Logger.Abstracts;
using Core.Logger.Models;
using Core.Logger.Repository.Specifics;
using Core.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
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
        public List<MessageLog> messages;
        public DbSet<TEntity> dbSet;
        public string name;
        public string Identificator;
        public string query;
        public ILogService _log;


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
            messages = new List<MessageLog>();
            _log = new DbSerilogService("") ;
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
                    Save($"{name} with {Identificator} :{id} was delete corrertly", MessageCode.information);
                }
                else
                {
                    _log.Write($"{name} with {Identificator} :{id} not was found");             
                }
            }
            return Save();
          
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

        /// <summary>
        /// Method to insert a list of our entity in our database
        /// </summary>
        /// <param name="list">list of entity</param>
        /// <returns>List of message with the result of inserts</returns>
        public dynamic Insert(IEnumerable<TEntity> list)
        {
            foreach (TEntity entity in list)
            {

                dbSet.Add(entity);
                Save($"{name} with {Identificator} {entity.GetHashCode()} was Insert", MessageCode.information);

            }
            return Save();

         //   return messages;



        }

        /// <summary>
        /// Method to insert a entity in our database
        /// </summary>
        /// <param name="entity">entity to insert</param>
        /// <returns>Message with the result of our method</returns>
        public dynamic Insert(TEntity entity)
        {

            dbSet.Add(entity);
            return Save($"{name} with {Identificator} = {entity.GetHashCode()}  was insert", MessageCode.information);

          //  return messages;
        }

        /// <summary>
        /// Method to Save changes in our db
        /// </summary>
        /// <returns>Mesage with the result of this method</returns>
        public dynamic  Save(string text = null, MessageCode Code = MessageCode.error)
        {
            try
            {
                _Context.SaveChanges();
                _log.Write(text);
            }
            catch (DbEntityValidationException e)
            {
                _log.Write( $"{e.InnerException.InnerException.Message ?? e.Message}", MessageCode.exception);
            }
            catch (DbUpdateException e)
            {
                _log.Write($"{e.InnerException.InnerException.Message ?? e.Message}", MessageCode.exception);                   
            }
            catch (SqlException e)
            {
                _log.Write( $"{e.InnerException.InnerException.Message ?? e.Message}", MessageCode.exception);
            }
            catch (Exception e)
            {
                _log.Write($"{e.InnerException.InnerException.Message ?? e.Message}", MessageCode.exception);
            }
            return null;
       
        }

        /// <summary>
        /// Method to update a list of entities 
        /// </summary>
        /// <param name="list">List of our entity</param>
        /// <returns>a message with the result of this method</returns>
        public dynamic Update(IEnumerable<TEntity> list)
        {
            foreach (TEntity entity in list)
            {
                dbSet.Attach(entity);
                _Context.Entry(entity).State = EntityState.Modified;
              return  Save($"entity was updated ", MessageCode.information);


            }
            return Save();

           // return messages;
        }

        /// <summary>
        /// Method to update a entity in our database
        /// </summary>
        /// <param name="entity">Our entity to update</param>
        /// <returns>a message with the result of this method</returns>
        public dynamic Update(TEntity entity)
        {

            dbSet.Attach(entity);
            _Context.Entry(entity).State = EntityState.Modified;
           return  Save($"entity was updated ", MessageCode.information);
           // return messages;
        }

        /// <summary>
        /// Method that return quantity of our entity <T> in database
        /// </summary>
        /// <returns>int quantity</returns>
        public int Count()
        {
            int count = dbSet.Count();

            return count;
        }

        public void Dispose()
        {
            try
            {
                _Context.Dispose();
            }
            catch (Exception e)
            {
                _log.Write($"{e.InnerException.InnerException.Message ?? e.Message}", MessageCode.exception);
            }

        }

        public dynamic Delete(string id)
        {

            TEntity search = dbSet.Find(id);
            if (search != null)
            {

                dbSet.Remove(search);
                Save($"{name} with {Identificator} :{id} was delete corrertly", MessageCode.information);
            }
            else
            {
                MessageLog message = new MessageLog()
                {  
                    Code = MessageCodeNames.error,
                    Note = $"{name} with {Identificator} :{id} not was found"
                };
                messages.Add(message);
            }
            return Save();
         //   return messages;
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }
        public void ExecuteQuery(string query)
        {
            _Context.Database.ExecuteSqlCommand(query);

          //  return Save();

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