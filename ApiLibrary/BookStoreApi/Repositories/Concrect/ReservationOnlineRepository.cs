using BookStoreApi.Models.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Models.Utilities;
using BookStoreApi.Repositories.Abstract;
using BookStoreApi.Utilities.Enums;
using LibraryApiRest.Repositories.Concrect;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BookStoreApi.Repositories.Concrect
{
    public class ReservationOnlineRepository : Repository<ReservationOnline, ReservationOnlineDto> ,IReservationOnlineRepository
    {
        public ReservationOnlineRepository(string identificator="IdReservation") : base(identificator)
        {
        }

        public int Count(string idWareHouse)
        {
            return dbSet.Count(w => w.IdWareHouse.Equals(idWareHouse));
        }

        public int Count(string idWareHouse, DateTime start, DateTime end)
        {
            return dbSet.Count(w=> w.IdWareHouse.Equals(idWareHouse) 
            && DbFunctions.TruncateTime(start)>= w.Reservation.CreateDate
            && DbFunctions.TruncateTime(end)<= w.Reservation.FinishReservationDate.Value);
        }

        public List<ReservationOnlineDto> GetReservations(string idWareHouse)
        {
            var result = dbSet.Where(w => w.IdWareHouse.Equals(idWareHouse)).ToList();
            return mapper.Map<List<ReservationOnlineDto>>(result);
        }

        public dynamic Insert(List<ReservationOnlineDto> list)
        {
            foreach (ReservationOnlineDto dto in list)
            {
                var reservation_online = mapper.Map<ReservationOnline>(dto);
                try
                {
                    dbSet.Add(reservation_online);
                    Context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = MessageCode.exception,
                        Error = true,
                        Type = MessageType.Exception,
                        Note = e.InnerException.InnerException.Message
                    };
                    messages.Add(message);
                    dbSet.Remove(reservation_online);
                }
                catch (SqlException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = MessageCode.exception,
                        Error = true,
                        Type = MessageType.Exception,
                        Note = e.InnerException.InnerException.Message
                    };
                    messages.Add(message);
                    dbSet.Remove(reservation_online);
                }
                catch (Exception e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = MessageCode.exception,
                        Error = true,
                        Type = MessageType.Exception,
                        Note = e.InnerException.InnerException.Message
                    };
                    messages.Add(message);
                    dbSet.Remove(reservation_online);
                }
            }
            return messages;
        }

        public dynamic Update(List<ReservationOnlineDto> list)
        {

            return messages;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public new dynamic Delete(List<string> ids)
        {
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search!=null)
                {
                    try
                    {
                        dbSet.Remove(dbSet.Find(id));
                        Context.ReservationOnline.Remove(Context.ReservationOnline.Find(id));
                        Context.SaveChanges();
                        MessageControl message = new MessageControl()
                        {
                            Code = MessageCode.correct,
                            Error = true,
                            Type = MessageType.Delete,
                            Note = $"{name} with {Identificator} : {id} was delete"
                        };
                        messages.Add(message);
                    }
                    catch (DbUpdateException e)
                    {
                        MessageControl message = new MessageControl()
                        {
                            Code = MessageCode.exception,
                            Error = true,
                            Type = MessageType.Exception,
                            Note = e.InnerException.InnerException.Message
                        };
                        messages.Add(message);
                    }
                    catch (SqlException e)
                    {
                        MessageControl message = new MessageControl()
                        {
                            Code = MessageCode.exception,
                            Error = true,
                            Type = MessageType.Exception,
                            Note = e.InnerException.InnerException.Message
                        };
                        messages.Add(message);
                    }
                    catch (Exception e)
                    {
                        MessageControl message = new MessageControl()
                        {
                            Code = MessageCode.exception,
                            Error = true,
                            Type = MessageType.Exception,
                            Note = e.InnerException.InnerException.Message
                        };
                        messages.Add(message);
                    }
                }
                else
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = MessageCode.error,
                        Error = true,
                        Type = MessageType.Not_Found,
                        Note = $"{name} with {Identificator} : {id} not was found"
                    };
                    messages.Add(message);
                }
            }
            return messages;
        }
    }
}