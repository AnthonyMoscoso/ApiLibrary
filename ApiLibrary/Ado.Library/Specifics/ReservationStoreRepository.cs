using Models.Ado.Library;
using Models.Models.Dtos;
using Models.Repositories.Concrect.Reservations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using Nucleo.DBAccess.Ado;
using Nucleo.Utilities;
using Ado.Library;

namespace Models.Repositories.Concrect
{
    public class ReservationStoreRepository : Repository<ReservationStore, ReservationStoreDto>, IReservationStoreRepository
    {
        readonly IReservationRepository reservationRepository = new ReservationRepository();
        public ReservationStoreRepository(string identificator ="IdReservation") : base(identificator)
        {
        }

        public List<ReservationStoreDto> GetByStore(string idStore)
        {
            var result = dbSet.Where(w => w.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<ReservationStoreDto>>(result);
        }

        public List<ReservationStoreDto> GetByStore(string idStore, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdStore.Equals(idStore))
                   .OrderBy(w => w.Reservation.CreateDate)
                .Skip((pag-1)*element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ReservationStoreDto>>(result);
        }

        public List<ReservationStoreDto> GetByStore(string idStore, DateTime start, DateTime end)
        {
            var result = dbSet.Where(w => w.IdStore.Equals(idStore)
              && (DbFunctions.TruncateTime(w.Reservation.CreateDate) >= DbFunctions.TruncateTime(start) && DbFunctions.TruncateTime(end) >= DbFunctions.TruncateTime(w.Reservation.CreateDate)
                || (DbFunctions.TruncateTime(w.Reservation.FinishReservationDate.Value) >= DbFunctions.TruncateTime(start) && DbFunctions.TruncateTime(end) >= DbFunctions.TruncateTime(w.Reservation.FinishReservationDate.Value))
                || !w.Reservation.FinishReservationDate.HasValue))
                .ToList();
            return mapper.Map<List<ReservationStoreDto>>(result);
        }

        public List<ReservationStoreDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdStore.Equals(idStore)
                 && (DbFunctions.TruncateTime(w.Reservation.CreateDate) >= DbFunctions.TruncateTime(start) && DbFunctions.TruncateTime(end) >= DbFunctions.TruncateTime(w.Reservation.CreateDate)
                || (DbFunctions.TruncateTime(w.Reservation.FinishReservationDate.Value) >= DbFunctions.TruncateTime(start) && DbFunctions.TruncateTime(end) >= DbFunctions.TruncateTime(w.Reservation.FinishReservationDate.Value))
                || !w.Reservation.FinishReservationDate.HasValue))
                 .OrderBy(w => w.Reservation.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ReservationStoreDto>>(result);
        }

        public dynamic Insert(List<ReservationStoreDto> list)
        {
          
            foreach (ReservationStoreDto dto in list)
            {

                var r_store = mapper.Map<ReservationStore>(dto);
            
                try
                {
                    dbSet.Add(r_store);
                    Context.SaveChanges();
                    MessageControl message = new MessageControl()
                    {
                        Code = Nucleo.Utilities.Enums.MessageCode.correct,
                        Error = false,
                        Type = Nucleo.Utilities.Enums.MessageType.Insert,
                        Note = $"{name} with id {Identificator} : {dto.IdReservation} was insert"
                    };
                    messages.Add(message);
                }
                catch (DbUpdateException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Nucleo.Utilities.Enums.MessageCode.exception,
                        Error = false,
                        Type = Nucleo.Utilities.Enums.MessageType.Exception,
                        Note = $"{e.InnerException.InnerException.Message}"
                    };
                    messages.Add(message);

                    dbSet.Remove(r_store);
                }
                catch (SqlException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Nucleo.Utilities.Enums.MessageCode.exception,
                        Error = false,
                        Type = Nucleo.Utilities.Enums.MessageType.Exception,
                        Note = $"{e.InnerException.InnerException.Message}"
                    };
                    messages.Add(message);

                    dbSet.Remove(r_store);
                }
                catch (Exception e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Nucleo.Utilities.Enums.MessageCode.exception,
                        Error = false,
                        Type = Nucleo.Utilities.Enums.MessageType.Exception,
                        Note = $"{e.InnerException.InnerException.Message}"
                    };
                    messages.Add(message);

                    dbSet.Remove(r_store);
                }
            }
            return messages;
        }

        public dynamic Update(List<ReservationStoreDto> list)
        {
            foreach (ReservationStoreDto dto in list)
            {
                var reser = mapper.Map<Reservation>(dto);
                

                try
                {
                    var search = dbSet.Find(dto.IdReservation);
                    if (search!=null)
                    {

                        messages.AddRange(reservationRepository.Update(reser));
                        dbSet.Attach(search);
                        Context.Entry(search).State = EntityState.Modified;
                        Save();
                    }
                    else
                    {
                        MessageControl message = new MessageControl()
                        {
                            Code = Nucleo.Utilities.Enums.MessageCode.error,
                            Error = false,
                            Type = Nucleo.Utilities.Enums.MessageType.Not_Found,
                            Note = $"{name} with  {Identificator} : {dto.IdReservation} not was found"
                        };
                        messages.Add(message);
                    }
                    
                   
                }
                catch (DbUpdateException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Nucleo.Utilities.Enums.MessageCode.exception,
                        Error = false,
                        Type = Nucleo.Utilities.Enums.MessageType.Exception,
                        Note = $"{e.InnerException.InnerException.Message}"
                    };
                    messages.Add(message);
                }
                catch (SqlException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Nucleo.Utilities.Enums.MessageCode.exception,
                        Error = false,
                        Type = Nucleo.Utilities.Enums.MessageType.Exception,
                        Note = $"{e.InnerException.InnerException.Message}"
                    };
                    messages.Add(message);
                }
                catch (Exception e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Nucleo.Utilities.Enums.MessageCode.exception,
                        Error = false,
                        Type = Nucleo.Utilities.Enums.MessageType.Exception,
                        Note = $"{e.InnerException.InnerException.Message}"
                    };
                    messages.Add(message);
                }
            }
            return messages;
        }

        public new dynamic Delete(List<string>ids)
        {
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search!=null)
                {
                    try
                    {
                        dbSet.Remove(search);
                        Context.Reservation.Remove(Context.Reservation.Find(id));
                        Context.SaveChanges();
                        MessageControl message = new MessageControl()
                        {
                            Code = Nucleo.Utilities.Enums.MessageCode.correct,
                            Error = false,
                            Type = Nucleo.Utilities.Enums.MessageType.Delete,
                            Note = $"{name} with {Identificator} :{id} was delete"
                        };
                        messages.Add(message);
                    }
                    catch (DbUpdateException e)
                    {
                        MessageControl message = new MessageControl()
                        {
                            Code = Nucleo.Utilities.Enums.MessageCode.exception,
                            Error = false,
                            Type = Nucleo.Utilities.Enums.MessageType.Exception,
                            Note = $"{e.InnerException.InnerException.Message}"
                        };
                        messages.Add(message);
                    }
                    catch (SqlException e)
                    {
                        MessageControl message = new MessageControl()
                        {
                            Code = Nucleo.Utilities.Enums.MessageCode.exception,
                            Error = false,
                            Type = Nucleo.Utilities.Enums.MessageType.Exception,
                            Note = $"{e.InnerException.InnerException.Message}"
                        };
                        messages.Add(message);
                    }
                    catch (Exception e)
                    {
                        MessageControl message = new MessageControl()
                        {
                            Code = Nucleo.Utilities.Enums.MessageCode.exception,
                            Error = false,
                            Type = Nucleo.Utilities.Enums.MessageType.Exception,
                            Note = $"{e.InnerException.InnerException.Message}"
                        };
                        messages.Add(message);
                    }

                }
                else
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Nucleo.Utilities.Enums.MessageCode.error,
                        Error = false,
                        Type = Nucleo.Utilities.Enums.MessageType.Not_Found,
                        Note = $"{name} with  {Identificator} : {id} not was found"
                    };
                    messages.Add(message);
                }
            }
            return messages;
        }

        public int Count(string idStore)
        {
            return dbSet.Count(w => w.IdStore.Equals(idStore));
        }
        public int Count(string idStore, DateTime start, DateTime end)
        {
            return dbSet.Count(w => w.IdStore.Equals(idStore)
                         && (DbFunctions.TruncateTime(w.Reservation.CreateDate) >= DbFunctions.TruncateTime(start) && DbFunctions.TruncateTime(end) >= DbFunctions.TruncateTime(w.Reservation.CreateDate)
                || (DbFunctions.TruncateTime(w.Reservation.FinishReservationDate.Value) >= DbFunctions.TruncateTime(start) && DbFunctions.TruncateTime(end) >= DbFunctions.TruncateTime(w.Reservation.FinishReservationDate.Value))
                || !w.Reservation.FinishReservationDate.HasValue));
        }
    }
}