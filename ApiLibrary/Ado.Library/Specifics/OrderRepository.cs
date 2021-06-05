using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Models.Ado.Library;
using Nucleo.DBAccess.Ado;
using Ado.Library;

namespace Ado.Library.Specifics
{
    public class OrderRepository : Repository<Orders>, IOrderRepository
    {
        public OrderRepository(BookStoreEntities context,string identificator="IdOrder") : base(context,identificator)
        {
        }

        public new dynamic Update(IEnumerable<Orders> list)
        {
            string message = "";
            foreach (Orders o in list)
            {
                if (o.OrderLine.Count > 0)
                {
                    foreach (OrderLine line in o.OrderLine)
                    {
                        OrderLine searchLine = _Context.Set<OrderLine>().Find(line.IdOrderLine);
                        if (searchLine != null)
                        {
                            if (!searchLine.LastUpdateDate.Equals(line.LastUpdateDate))
                            {
                                _Context.Set<OrderLine>().Attach(line);
                                _Context.Entry(line).State = EntityState.Modified;
                            }
                        }
                    }

                }

                dbSet.Attach(o);
                _Context.Entry(o).State = EntityState.Modified;
                message += Save();
            }
            return Save();
        }

        public new dynamic Delete(IEnumerable<string> ids)
        {
            string message = "";
            foreach (string id in ids)
            {
                var search = dbSet.Find(id);
                if (search != null)
                {
                    IEnumerable<OrderLine> lines = search.OrderLine.ToList(); ;
                    foreach (OrderLine line in lines)
                    {
                        _Context.Set<OrderLine>().Remove(line);
                    }
                    dbSet.Remove(search);
                    message += Save();
                }
                else
                {
                    message += "\nNo was found any Order with this id " + id;
                }


            }

            return message;
        }


        public IEnumerable<Orders> GetByDate(DateTime date)
        {
            IEnumerable<Orders> search = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date));
            return search;
        }

        public IEnumerable<Orders> GetByDate(DateTime date, int pag, int element)
        {
            IEnumerable<Orders> search = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
            return search;
        }

        public IEnumerable<Orders> GetByDate(DateTime dateStart, DateTime dateEnd)
        {
            IEnumerable<Orders> search = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(dateStart) && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(dateEnd));
            return search;
        }

        public IEnumerable<Orders> GetByDate(DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            IEnumerable<Orders> search = dbSet.Where(w => w.CreateDate >= dateStart && w.CreateDate <= dateEnd)
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return search;
        }


        public IEnumerable<Orders> GetByStore(string idStore)
        {
            IEnumerable<Orders> search = dbSet.Where(w => w.IdStore.Equals(idStore));
            return search;
        }

        public IEnumerable<Orders> GetByStore(string idStore, int pag, int element)
        {
            IEnumerable<Orders> search = dbSet.Where(w => w.IdStore.Equals(idStore))
                 .OrderBy(w => w.CreateDate)
                .Skip((pag - 1) * element)
                .Take(element);
            return search;
        }
        public IEnumerable<Orders> GetByStore(string idStore, DateTime date)
        {
            IEnumerable<Orders> search = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date) && w.IdStore.Equals(idStore));
            return search;
        }

        public IEnumerable<Orders> GetByStore(string idStore, DateTime date, int pag, int element)
        {
            IEnumerable<Orders> search = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date) && w.IdStore.Equals(idStore))
                  .OrderBy(w => w.CreateDate)
                 .Skip((pag - 1) * element)
                 .Take(element);
            return search;
        }

        public IEnumerable<Orders> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd)
        {
            IEnumerable<Orders> search = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(dateStart) && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(dateEnd) && w.IdStore.Equals(idStore));
            return search;
        }

        public IEnumerable<Orders> GetByStore(string idStore, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            IEnumerable<Orders> search = dbSet.Where(w => DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(dateStart) && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(dateEnd) && w.IdStore.Equals(idStore)).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
            return search;
        }


        public IEnumerable<Orders> GetByWareHouse(string idWareHouse, DateTime date)
        {
            IEnumerable<Orders> search = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date));
            return search;
        }

        public IEnumerable<Orders> GetByWareHouse(string idWareHouse, DateTime date, int pag, int element)
        {
            IEnumerable<Orders> search = dbSet.Where(w => w.WareHouse.IdWareHouse.Equals(idWareHouse) && DbFunctions.TruncateTime(w.CreateDate) == DbFunctions.TruncateTime(date)).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
            return search;
        }

        public IEnumerable<Orders> GetByWareHouse(string idWareHouse)
        {
            IEnumerable<Orders> search = dbSet.Where(w => w.IdWareHouse.Equals(idWareHouse));
            return search;
        }

        public IEnumerable<Orders> GetByWareHouse(string idWareHouse, int pag, int element)
        {
            IEnumerable<Orders> search = dbSet.Where(w => w.IdWareHouse.Equals(idWareHouse)).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
            return search;
        }

        public IEnumerable<Orders> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd)
        {
            IEnumerable<Orders> search = dbSet.Where(w => w.IdWareHouse.Equals(idWareHouse) && DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(dateStart) && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(dateEnd));
            return search;
        }

        public IEnumerable<Orders> GetByWareHouse(string idWareHouse, DateTime dateStart, DateTime dateEnd, int pag, int element)
        {
            IEnumerable<Orders> search = dbSet.Where(w => w.IdWareHouse.Equals(idWareHouse) && DbFunctions.TruncateTime(w.CreateDate) >= DbFunctions.TruncateTime(dateStart) && DbFunctions.TruncateTime(w.CreateDate) <= DbFunctions.TruncateTime(dateEnd)).OrderBy(w => w.CreateDate).Skip((pag - 1) * element).Take(element);
            return search;
        }
    }
}