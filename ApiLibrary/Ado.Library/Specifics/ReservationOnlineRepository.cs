using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;
using Core.Logger.Repository.Specifics;

namespace Ado.Library.Specifics
{
    public class ReservationOnlineRepository : AdoRepository<ReservationOnline> ,IReservationOnlineRepository
    {
        public ReservationOnlineRepository(BookStoreEntities context, string identificator="IdReservation") : base(context,identificator)
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

        public IEnumerable<ReservationOnline> GetReservations(string idWareHouse)
        {
            IEnumerable<ReservationOnline> result = dbSet.Where(w => w.IdWareHouse.Equals(idWareHouse)).ToList();
            return (result);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
    /*    public new dynamic Delete(List<string> ids)
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
        }*/
    }
}