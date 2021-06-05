﻿using Models.Ado.Library;
using Nucleo.Utilities;
using Nucleo.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace Nucleo.DBAccess.Ado
{
    /// <summary>
    /// Generic repository <T> for generic methods 
    /// </summary>
    /// <typeparam name="TEntity">Entity on our orm in Ado.net</typeparam>
    /// <typeparam name="DtoEntity">Entity to map our TEntity </typeparam>
    public abstract class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, new()
    {

        // public DbContext _Context;
        public DbContext _Context { get; set; }
        public List<MessageControl> messages;
        public DbSet<TEntity> dbSet;
        public string name;
        public string Identificator;
        public string query;


        /// <summary>
        /// Construtor of our generic repository
        /// </summary>
        /// <param name="identificator">name of primary key column of our table</param>
        public Repository(DbContext context,string identificator)
        {
            _Context = context;
            dbSet = _Context.Set<TEntity>();
            name = typeof(TEntity).Name;
            Identificator = identificator;
            messages = new List<MessageControl>();
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
                    Save($"{name} with {Identificator} :{id} was delete corrertly", MessageCode.correct, MessageType.Delete);


                }
                else
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = MessageCode.error,
                        Type = MessageType.Not_Found,
                        Error = true,
                        Note = $"{name} with {Identificator} :{id} not was found"
                    };
                    messages.Add(message);
                }
            }

            return messages;
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
        /// method to get a list of entities through ids
        /// </summary>
        /// <param name="ids">string with our ids</param>
        /// <returns>our entities</returns>
        public IEnumerable<TEntity> GetList(string ids)
        {
            IEnumerable<string> list = ids.Split(',').ToList();
            foreach (string id in list)
            {

                TEntity search = dbSet.Find(id);
                if (search != null)
                {
                   yield return search;
                }
            }


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
        public TEntity Get(string id)
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
                Save($"{name} with {Identificator} {entity.GetHashCode()} was Insert", MessageCode.correct, MessageType.Insert);

            }


            return messages;



        }

        /// <summary>
        /// Method to insert a entity in our database
        /// </summary>
        /// <param name="entity">entity to insert</param>
        /// <returns>Message with the result of our method</returns>
        public dynamic Insert(TEntity entity)
        {

            dbSet.Add(entity);
            Save($"{name} with {Identificator} = {entity.GetHashCode()}  was insert", MessageCode.correct, MessageType.Insert);

            return messages;
        }

        /// <summary>
        /// Method to Save changes in our db
        /// </summary>
        /// <returns>Mesage with the result of this method</returns>
        public dynamic Save(string text = null, MessageCode Code = MessageCode.error, MessageType type = MessageType.Exception)
        {
            try
            {
                _Context.SaveChanges();
                MessageControl message = new MessageControl()
                {
                    Code = Code,
                    Type = type,
                    Error = false,
                    Note = text ?? "Changes saves "
                };
                messages.Add(message);
            }
            catch (DbEntityValidationException e)
            {
                MessageControl message = new MessageControl()
                {
                    Code = MessageCode.exception,
                    Type = MessageType.Exception,
                    Error = true,
                    Note = $"{e.InnerException.InnerException.Message ?? e.Message}"
                };
                messages.Add(message);
            }
            catch (DbUpdateException e)
            {
                MessageControl message = new MessageControl()
                {
                    Code = MessageCode.exception,
                    Type = MessageType.Exception,
                    Error = true,
                    Note = $"{e.InnerException.InnerException.Message ?? e.Message}"
                };
                messages.Add(message);
            }
            catch (SqlException e)
            {
                MessageControl message = new MessageControl()
                {
                    Code = MessageCode.exception,
                    Type = MessageType.Exception,
                    Error = true,
                    Note = $"{e.InnerException.InnerException.Message ?? e.Message}"
                };
                messages.Add(message);
            }
            catch (Exception e)
            {
                MessageControl message = new MessageControl()
                {
                    Code = MessageCode.exception,
                    Type = MessageType.Exception,
                    Error = true,
                    Note = $"{e.InnerException.InnerException.Message ?? e.Message}"
                };
                messages.Add(message);
            }
            return messages;
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
                Save($"entity was updated ", MessageCode.correct, MessageType.Update);


            }

            return messages;
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
            Save($"entity was updated ", MessageCode.correct, MessageType.Update);
            return messages;
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
            catch (Exception)
            {

            }
            finally
            {

            }

        }

        public dynamic Delete(string id)
        {

            TEntity search = dbSet.Find(id);
            if (search != null)
            {

                dbSet.Remove(search);
                Save($"{name} with {Identificator} :{id} was delete corrertly", MessageCode.correct, MessageType.Delete);


            }
            else
            {
                MessageControl message = new MessageControl()
                {
                    Code = MessageCode.error,
                    Type = MessageType.Not_Found,
                    Error = true,
                    Note = $"{name} with {Identificator} :{id} not was found"
                };
                messages.Add(message);
            }
            return messages;
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }
        public dynamic SqlQuery(string query)
        {
            _Context.Database.ExecuteSqlCommand(query);
            return Save();

        }

        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Count(predicate);
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate).SingleOrDefault();
        }
    }
}