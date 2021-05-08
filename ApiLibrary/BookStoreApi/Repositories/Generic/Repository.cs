using AutoMapper;
using BookStoreApi.Models;
using BookStoreApi.Models.Library;
using BookStoreApi.Models.Utilities;
using BookStoreApi.Utilities.Enums;
using LibraryApiRest.Enums;
using LibraryApiRest.Repositories.Abstract;
using Mappers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace LibraryApiRest.Repositories.Concrect
{
    public class Repository<TEntity,DtoEntity> : IRepository<TEntity> 
        where DtoEntity  : class , new()
        where TEntity : class,new()
    {
        public BookStoreEntities Context;
        public List<MessageControl> messages ;
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
            messages = new List<MessageControl>();
        }

        public dynamic Delete(List<string> ids)
        {
            foreach (string id  in ids)
            {
                
                TEntity search = dbSet.Find(id);
                if (search!=null)
                {
                   
                    try
                    {
                        dbSet.Remove(search);
                        Context.SaveChanges();
                        MessageControl message = new MessageControl()
                        {
                            Code = MessageCode.correct,
                            Type = MessageType.Delete,
                            Error = false,
                            Note = $"{name} with {Identificator} :{id} was delete corrertly"
                        };
                        messages.Add(message);
                    }
                    catch(DbUpdateException e)
                    {
                        MessageControl message = new MessageControl()
                        {
                            Code = MessageCode.exception,
                            Type = MessageType.Exception,
                            Error = true,
                            Note = $"{e.InnerException.InnerException.Message}"
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
                            Note = $"{e.InnerException.InnerException.Message}"
                        };
                        messages.Add(message);
                    }
                   
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
        public dynamic Get()
        {

            var list = dbSet.ToList();
            return mapper.Map<List<DtoEntity>>(list);
        }

        public dynamic GetList(string ids)
        {
            List<string> list = ids.Split(',').ToList();
            List<TEntity> entities = new List<TEntity>();
            foreach (string id in list)
            {

                TEntity search = dbSet.Find(id);
                if (search != null)
                {
                    entities.Add(search);
                }
            }

            return mapper.Map<List<DtoEntity>>(entities);
        }

        public dynamic Get(int elements, int pag)
        {
   
      
            List<TEntity> list = dbSet.OrderBy(x =>Identificator).Skip((pag-1)*elements).Take(elements).ToList();
            
            return mapper.Map<List<DtoEntity>>(list);
        }

        public dynamic Get(string id)
        {
            var search = dbSet.Find(id);
            return search != null ? (dynamic) mapper.Map<DtoEntity>(search) : (dynamic)"Not was found";

        }

        public dynamic Insert(List<TEntity> list)
        {
            foreach (TEntity entity in list)
            {
                try
                {
                   
                    dbSet.Add(entity);
                    Context.SaveChanges();
                    MessageControl message = new MessageControl()
                    {
                        Code = MessageCode.correct,
                        Type = MessageType.Insert,
                        Error = false,
                        Note = $"{name} with {Identificator} {entity.GetHashCode()} was Insert",

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
                        Note = $"{e.InnerException.InnerException.Message}",
                    };
                    dbSet.Remove(entity);
                    messages.Add(message);
                }
                catch (SqlException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = MessageCode.exception,
                        Type = MessageType.Exception,
                        Error = true,
                        Note = $"{e.InnerException.InnerException.Message}",
                    };
                    dbSet.Remove(entity);
                    messages.Add(message);
                }
            }

            return messages;



        }

        public dynamic Insert(TEntity entity)
        {
            try
            {
                dbSet.Add(entity);
                Context.SaveChanges();
                MessageControl message = new MessageControl()
                {
                    Code = MessageCode.correct,
                    Type = MessageType.Insert,
                    Note = $"{name} with {Identificator} = {entity.GetHashCode()}  was insert",
                    Error = false
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
                    Note = $"{e.InnerException.InnerException.Message}",
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
                    Note = $"{e.InnerException.InnerException.Message}",
                };
                messages.Add(message);
            }
            return messages;
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
            catch (SqlException e)
            {
                return e.Message;
            }
        }

        public dynamic Update(List<TEntity> list)
        {
            foreach (TEntity entity in list)
            {
                try
                {
                    dbSet.Attach(entity);
                    Context.Entry(entity).State = EntityState.Modified;
                    Context.SaveChanges();
                    MessageControl message = new MessageControl()
                    {
                        Code = MessageCode.correct,
                        Type = MessageType.Update,
                        Error = false,
                        Note = "",
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
                        Note = $"{e.InnerException}",
                    };
                    messages.Add(message);
                }
        
            }
            
            return  messages;
        }

        public dynamic Update(TEntity entity)
        {
           
                try
                {
                    dbSet.Attach(entity);
                    Context.Entry(entity).State = EntityState.Modified;
                    Context.SaveChanges();
                    MessageControl message = new MessageControl()
                    {
                        Code = MessageCode.correct,
                        Type = MessageType.Update,
                        Error = false,
                        Note = "",
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
                        Note = $"{e.InnerException}",
                    };
                    messages.Add(message);
                }

            

            return messages;
        }

        public int Count()
        {
            return dbSet.Count();
        }
    }
}