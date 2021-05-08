using BookStoreApi.Models.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Models.Utilities;
using BookStoreApi.Repositories.Abstract;
using BookStoreApi.Repositories.Abstract.Reservations;
using BookStoreApi.Repositories.Concrect.Reservations;
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
                .Skip((pag-1)*element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ReservationStoreDto>>(result);
        }

        public List<ReservationStoreDto> GetByStore(string idStore, DateTime date)
        {
            var result = dbSet.Where(w => w.IdStore.Equals(idStore)
            && DbFunctions.TruncateTime(w.Reservation.CreateDate).Equals(date))
                .ToList();
            return mapper.Map<List<ReservationStoreDto>>(result);
        }

        public List<ReservationStoreDto> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdStore.Equals(idStore)
          && DbFunctions.TruncateTime(w.Reservation.CreateDate).Equals(date))
               .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ReservationStoreDto>>(result);
        }

        public List<ReservationStoreDto> GetByStore(string idStore, DateTime start, DateTime end)
        {
            var result = dbSet.Where(w => w.IdStore.Equals(idStore)
            && DbFunctions.TruncateTime(start) >= DbFunctions.TruncateTime(w.Reservation.CreateDate)
            && DbFunctions.TruncateTime(end) <= DbFunctions.TruncateTime(w.Reservation.CreateDate)
            && DbFunctions.TruncateTime(start) >= DbFunctions.TruncateTime(w.Reservation.FinishReservationDate.Value)
            && DbFunctions.TruncateTime(end) <= DbFunctions.TruncateTime(w.Reservation.FinishReservationDate.Value))
                .ToList();
            return mapper.Map<List<ReservationStoreDto>>(result);
        }

        public List<ReservationStoreDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            var result = dbSet.Where(w => w.IdStore.Equals(idStore)
                && DbFunctions.TruncateTime(start) >= DbFunctions.TruncateTime(w.Reservation.CreateDate)
                && DbFunctions.TruncateTime(end) <= DbFunctions.TruncateTime(w.Reservation.CreateDate)
                && DbFunctions.TruncateTime(start) >= DbFunctions.TruncateTime(w.Reservation.FinishReservationDate.Value)
                && DbFunctions.TruncateTime(end) <= DbFunctions.TruncateTime(w.Reservation.FinishReservationDate.Value))
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ReservationStoreDto>>(result);
        }

        public dynamic Insert(List<ReservationStoreDto> list)
        {
          
            foreach (ReservationStoreDto dto in list)
            {
                var reser = mapper.Map<Reservation>(dto);
                var r_store = mapper.Map<ReservationStore>(dto);
            
                try
                {
                    Context.Reservation.Add(reser);
                    dbSet.Add(r_store);
                    Context.SaveChanges();
                    MessageControl message = new MessageControl()
                    {
                        Code = Utilities.Enums.MessageCode.correct,
                        Error = false,
                        Type = Utilities.Enums.MessageType.Insert,
                        Note = $"{name} with id {Identificator} : {dto.IdReservation} was insert"
                    };
                    messages.Add(message);
                }
                catch (DbUpdateException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Utilities.Enums.MessageCode.exception,
                        Error = false,
                        Type = Utilities.Enums.MessageType.Exception,
                        Note = $"{e.InnerException.InnerException.Message}"
                    };
                    messages.Add(message);
                    Context.Reservation.Remove(reser);
                    dbSet.Remove(r_store);
                }
                catch (SqlException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Utilities.Enums.MessageCode.exception,
                        Error = false,
                        Type = Utilities.Enums.MessageType.Exception,
                        Note = $"{e.InnerException.InnerException.Message}"
                    };
                    messages.Add(message);
                    Context.Reservation.Remove(reser);
                    dbSet.Remove(r_store);
                }
                catch (Exception e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Utilities.Enums.MessageCode.exception,
                        Error = false,
                        Type = Utilities.Enums.MessageType.Exception,
                        Note = $"{e.InnerException.InnerException.Message}"
                    };
                    messages.Add(message);
                    Context.Reservation.Remove(reser);
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
                var r_store = mapper.Map<ReservationStore>(dto);

                try
                {
                    var search = dbSet.Find(dto.IdReservation);
                    if (search!=null)
                    {
                        messages.Add(reservationRepository.Update(reser));
                        messages.Add(Update(r_store));
                    }
                    else
                    {
                        MessageControl message = new MessageControl()
                        {
                            Code = Utilities.Enums.MessageCode.error,
                            Error = false,
                            Type = Utilities.Enums.MessageType.Not_Found,
                            Note = $"{name} with  {Identificator} : {dto.IdReservation} not was found"
                        };
                        messages.Add(message);
                    }
                    
                   
                }
                catch (DbUpdateException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Utilities.Enums.MessageCode.exception,
                        Error = false,
                        Type = Utilities.Enums.MessageType.Exception,
                        Note = $"{e.InnerException.InnerException.Message}"
                    };
                    messages.Add(message);
                }
                catch (SqlException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Utilities.Enums.MessageCode.exception,
                        Error = false,
                        Type = Utilities.Enums.MessageType.Exception,
                        Note = $"{e.InnerException.InnerException.Message}"
                    };
                    messages.Add(message);
                }
                catch (Exception e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Utilities.Enums.MessageCode.exception,
                        Error = false,
                        Type = Utilities.Enums.MessageType.Exception,
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
                        MessageControl message = new MessageControl()
                        {
                            Code = Utilities.Enums.MessageCode.correct,
                            Error = false,
                            Type = Utilities.Enums.MessageType.Delete,
                            Note = $"{name} with {Identificator} :{id} was delete"
                        };
                    }
                    catch (DbUpdateException e)
                    {
                        MessageControl message = new MessageControl()
                        {
                            Code = Utilities.Enums.MessageCode.exception,
                            Error = false,
                            Type = Utilities.Enums.MessageType.Exception,
                            Note = $"{e.InnerException.InnerException.Message}"
                        };
                        messages.Add(message);
                    }
                    catch (SqlException e)
                    {
                        MessageControl message = new MessageControl()
                        {
                            Code = Utilities.Enums.MessageCode.exception,
                            Error = false,
                            Type = Utilities.Enums.MessageType.Exception,
                            Note = $"{e.InnerException.InnerException.Message}"
                        };
                        messages.Add(message);
                    }
                    catch (Exception e)
                    {
                        MessageControl message = new MessageControl()
                        {
                            Code = Utilities.Enums.MessageCode.exception,
                            Error = false,
                            Type = Utilities.Enums.MessageType.Exception,
                            Note = $"{e.InnerException.InnerException.Message}"
                        };
                        messages.Add(message);
                    }

                }
                else
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = Utilities.Enums.MessageCode.error,
                        Error = false,
                        Type = Utilities.Enums.MessageType.Not_Found,
                        Note = $"{name} with  {Identificator} : {id} not was found"
                    };
                    messages.Add(message);
                }
            }
            return messages;
        }


    
    }
}