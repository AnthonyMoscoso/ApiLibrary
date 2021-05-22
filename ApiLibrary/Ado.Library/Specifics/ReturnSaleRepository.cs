using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using Models.Ado.Library;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using Nucleo.DBAccess.Ado;
using Nucleo.Utilities;
using Nucleo.Utilities.Enums;
using Ado.Library;

namespace Models.Repositories.Concrect.Returns
{
    public class ReturnSaleRepository : Repository<ReturnSale, ReturnSaleDto>, IReturnSaleRepository
    {
        public ReturnSaleRepository(string identificator = "IdReturn") : base(identificator)
        {
        }


        public dynamic Insert(IList<ReturnSaleDto> list)
        {

            foreach (ReturnSaleDto returns in list)
            {
                ReturnSale r = new ReturnSale();
                try
                {
                    if (!string.IsNullOrEmpty(returns.IdStore))
                    {
                        r = mapper.Map<ReturnSale>(returns);
                        dbSet.Add(r);
                        Context.BookStore.Where(w => w.IdStore.Equals(returns.IdStore) && w.IdBook.Equals(returns.IdBook)).SingleOrDefault().Stock += returns.Quantity;
                        InsertReturnStore(returns.IdReturn,returns.IdStore);
                    }
                    else if (!string.IsNullOrEmpty(returns.IdWareHouse))
                    {
                        r = mapper.Map<ReturnSale>(returns);
                        dbSet.Add(r);
                        Context.WareHouseBook.Where(w => w.IdWareHouse.Equals(returns.IdWareHouse) && w.IdBook.Equals(returns.IdBook)).SingleOrDefault().Stock += returns.Quantity;
                        InsertReturnWareHouse(returns.IdReturn,returns.IdWareHouse);
                    }
                    Context.SaveChanges();
                    MessageControl message = new MessageControl()
                    {
                        Code = MessageCode.correct,
                        Type = MessageType.Insert,
                        Error = true,
                        Note = $"{name} with {Identificator} : {returns.IdReturn} was insert",
                    };
                    messages.Add(message);
                }
                #region catch block
                catch (DbUpdateException e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = MessageCode.exception,
                        Type = MessageType.Exception,
                        Error = true,
                        Note = $"{e.InnerException.InnerException.Message}",
                    };
                    dbSet.Remove(r);
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
                    dbSet.Remove(r);
                    messages.Add(message);
                }
                catch (Exception e)
                {
                    MessageControl message = new MessageControl()
                    {
                        Code = MessageCode.exception,
                        Type = MessageType.Exception,
                        Error = true,
                        Note = $"{e.InnerException.InnerException.Message}",
                    };
                    dbSet.Remove(r);
                    messages.Add(message);
                }
                #endregion

            }
            return messages;
        }



        #region Date
        public List<ReturnSaleDto> GetByDate(DateTime date)
        {
            var result = dbSet.Where(w => w.CreateDate.Date.Equals(date.Date)).ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }

        public List<ReturnSaleDto> GetByDate(DateTime date, int pag, int element)
        {
            var result = dbSet.Where(w => w.CreateDate.Date.Equals(date.Date))
                .OrderBy(W => W.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }

        public List<ReturnSaleDto> GetByDate(DateTime start, DateTime end)
        {
            var result = dbSet.Where(w => w.CreateDate.Date >= start.Date && w.CreateDate.Date <= end.Date).ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }

        public List<ReturnSaleDto> GetByDate(DateTime start, DateTime end, int pag, int element)
        {
            var result = dbSet.Where(w => w.CreateDate.Date >= start.Date && w.CreateDate.Date <= end.Date)
                 .OrderBy(W => W.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }
        #endregion

        #region Method 
        public List<ReturnSaleDto> GetByMethod(int RepaymentMethod)
        {
            var result = dbSet.Where(w => w.RepaymentMethod == RepaymentMethod).ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }

        public List<ReturnSaleDto> GetByMethod(int RepaymentMethod, int pag, int element)
        {
            var result = dbSet.Where(w => w.RepaymentMethod == RepaymentMethod)
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }

        public List<ReturnSaleDto> GetByMethod(int RepaymentMethod, string idStore)
        {
            var result = dbSet.Where(w => w.RepaymentMethod == RepaymentMethod && w.Store.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }

        public List<ReturnSaleDto> GetByMethod(int RepaymentMethod, string idStore, int pag, int element)
        {
            var result = dbSet.Where(w => w.RepaymentMethod == RepaymentMethod && w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }
        #endregion

        #region Motive 
        public List<ReturnSaleDto> GetByMotive(string motive)
        {
            var result = dbSet.Where(w => w.ReturnMotive.Equals(motive)).ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }

        public List<ReturnSaleDto> GetByMotive(string motive, int pag, int element)
        {
            var result = dbSet.Where(w => w.ReturnMotive.Equals(motive))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }

        public List<ReturnSaleDto> GetByMotive(string motive, string idStore)
        {
            var result = dbSet.Where(w => w.ReturnMotive.Equals(motive)
            && w.Store.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }

        public List<ReturnSaleDto> GetByMotive(string motive, string idStore, int pag, int element)
        {
            var result = dbSet.Where(w => w.ReturnMotive.Equals(motive) && w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element)
                .ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }
        #endregion

        #region Sale 
        public List<ReturnSaleDto> GetBySale(string idSale)
        {
            var result = dbSet.Where(w => w.IdSale.Equals(idSale)).ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }
        #endregion

        #region Store 
        public List<ReturnSaleDto> GetByStore(string idStore)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore)).ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }

        public List<ReturnSaleDto> GetByStore(string idStore, int pag, int element)
        {
            var result = dbSet.Where(w => w.Store.IdStore.Equals(idStore))
                .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element).Take(element).ToList();
            return mapper.Map<List<ReturnSaleDto>>(result);
        }

        public IList<ReturnSaleDto> GetByWareHouse(string idWareHouse)
        {
            throw new NotImplementedException();
        }

        public IList<ReturnSaleDto> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IList<ReturnSaleDto> GetByWareHouse(string idWareHouse, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IList<ReturnSaleDto> GetByWareHouse(string idWareHouse, DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        IList<ReturnSaleDto> IReturnSaleRepository.GetByStore(string idStore)
        {
            throw new NotImplementedException();
        }

        IList<ReturnSaleDto> IReturnSaleRepository.GetByStore(string idStore, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IList<ReturnSaleDto> GetByStore(string idStore, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IList<ReturnSaleDto> GetByStore(string idStore, DateTime start, DateTime end, int pag, int element)
        {
            throw new NotImplementedException();
        }

        public dynamic Update(IList<ReturnSaleDto> list)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region Private Methods

        private void InsertReturnWareHouse(string idReturn, string idWareHouse)
        {
            try
            {
                var query = $"Insert into ReturnWareHouse values ('{idReturn}','{idWareHouse}');";
                Context.Database.ExecuteSqlCommand(query);
                MessageControl message = new MessageControl()
                {
                    Code = MessageCode.exception,
                    Type = MessageType.Exception,
                    Error = true,
                    Note = $"ReturnWareHouse with {Identificator} : {idReturn} was insert",
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
            catch (Exception e)
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

        }

        private void InsertReturnStore(string idReturn, string idStore)
        {
            try
            {
                var query = $"Insert into ReturnStore values ('{idReturn}','{idStore}');";
                Context.Database.ExecuteSqlCommand(query);
                MessageControl message = new MessageControl()
                {
                    Code = MessageCode.exception,
                    Type = MessageType.Exception,
                    Error = true,
                    Note = $"ReturnStore with {Identificator} : {idReturn} was insert",
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
            catch (Exception e)
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

        }


        #endregion
    }
}